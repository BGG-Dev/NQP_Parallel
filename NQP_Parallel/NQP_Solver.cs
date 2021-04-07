using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NQP
{
    class NQP_Solver
    {
        private int N;

        public List<int[]> FinalSolutionSet;

        private int[,] FiguresPos;

        public void RunNQPtask(int n)
        {
            //Initialize start variables
            N = n;
            FinalSolutionSet = new List<int[]>();
            bool[,] startChessField = new bool[N, N];
            FiguresPos = new int[N, N];

            //Initialize of solution set
            List<int[]>[] SolutionSet = new List<int[]>[N];
            for (int i = 0; i < N; i++)
            {
                SolutionSet[i] = new List<int[]>();
            }

            //Calling main func
            Parallel.For(0, N, (i, state) =>
            {
                FiguresPos[i, 0] = i;
                bool[,] nextChessField = startChessField.Clone() as bool[,];
                MarkFields(0, i, ref nextChessField);
                RunIteration(1, nextChessField, i, SolutionSet[i]);
            });

            //Concatinating result
            for (int i = 0; i < N; i++)
            {
                FinalSolutionSet.AddRange(SolutionSet[i]);
            }
        }

        private void RunIteration(int indexOfCurrentFigure, bool[,] currentChessField, int indexOfStream, List<int[]> Solutions)
        {
            if (indexOfCurrentFigure == N)
            {
                int[] temp = new int[N];
                for (int i = 0; i < N; i++)
                {
                    temp[i] = FiguresPos[indexOfStream, i];
                }
                Solutions.Add(temp);
                return;
            }

            for (int i = 0; i < N; i++)
            {
                if (!currentChessField[indexOfCurrentFigure, i])
                {
                    FiguresPos[indexOfStream, indexOfCurrentFigure] = i;
                    bool[,] nextChessField = currentChessField.Clone() as bool[,];
                    MarkFields(indexOfCurrentFigure, i, ref nextChessField);

                    RunIteration(indexOfCurrentFigure + 1, nextChessField, indexOfStream, Solutions);
                }
            }

            return;
        }

        private void MarkFields(int cIndex, int rIndex, ref bool[,] chessField)
        {
            //column and row
            for (int i = 0; i < N; i++)
            {
                chessField[cIndex, i] = true;
                chessField[i, rIndex] = true;
            }

            //main diagonal
            int delta = 0;
            while((cIndex + delta < N) && (rIndex + delta < N))
            {
                chessField[cIndex + delta, rIndex + delta] = true;
                delta++;
            }
            delta = 0;
            while((cIndex - delta >= 0) && (rIndex - delta >= 0))
            {
                chessField[cIndex - delta, rIndex - delta] = true;
                delta++;
            }

            //additional diagonal
            delta = 0;
            while ((cIndex - delta >= 0) && (rIndex + delta < N))
            {
                chessField[cIndex - delta, rIndex + delta] = true;
                delta++;
            }
            delta = 0;
            while ((cIndex + delta < N) && (rIndex - delta >= 0))
            {
                chessField[cIndex + delta, rIndex - delta] = true;
                delta++;
            }
        }
    }
}
