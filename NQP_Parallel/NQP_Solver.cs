using System.Collections.Generic;
using System.Threading.Tasks;

namespace NQP
{
    class NQP_Solver
    {
        private readonly int n;

        private readonly List<int[]> finalSolutionSet;

        public IReadOnlyList<int[]> FinalSolutionSet => finalSolutionSet;

        public NQP_Solver(int n)
        {
            this.n = n;
            finalSolutionSet = new List<int[]>();
        }

        public void RunNQPtask()
        {
            bool[,] startChessField = new bool[n, n];

            //Initialize of solution set
            List<int[]>[] solutionSet = new List<int[]>[n];

            //Calling main func
            Parallel.For(0, n, (i, state) =>
            {
                solutionSet[i] = new List<int[]>();
                int[] figuresPosForCurrentStream = new int[n];
                figuresPosForCurrentStream[0] = i;
                var nextChessField = MarkFields(0, i, startChessField);
                RunIteration(1, nextChessField, solutionSet[i], figuresPosForCurrentStream);
            });

            //Concatinating result
            for (int i = 0; i < n; i++)
            {
                finalSolutionSet.AddRange(solutionSet[i]);
            }
        }

        private void RunIteration(int indexOfCurrentFigure, bool[,] currentChessField, List<int[]> solutions, int[] figuresPos)
        {
            if (indexOfCurrentFigure == n)
            {
                //Adding solution to list
                int[] temp = new int[n];
                for (int i = 0; i < n; i++)
                {
                    temp[i] = figuresPos[i];
                }
                solutions.Add(temp);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!currentChessField[indexOfCurrentFigure, i])
                {
                    //Placing figure
                    figuresPos[indexOfCurrentFigure] = i;
                    var nextChessField = MarkFields(indexOfCurrentFigure, i, currentChessField);

                    //Going next
                    RunIteration(indexOfCurrentFigure + 1, nextChessField, solutions, figuresPos);
                }
            }

            return;
        }

        private bool[,] MarkFields(int cIndex, int rIndex, bool[,] originChessField)
        {
            //Cloning desk
            bool[,] chessField = originChessField.Clone() as bool[,];

            //column and row
            for (int i = 0; i < n; i++)
            {
                chessField[cIndex, i] = chessField[i, rIndex] = true;
            }

            //main diagonal
            for (int c = cIndex, r = rIndex; c < n && r < n; c++, r++)
            {
                chessField[c, r] = true;
            }
            for (int c = cIndex, r = rIndex; c >= 0 && r >= 0; c--, r--)
            {
                chessField[c, r] = true;
            }

            //additional diagonal
            for (int c = cIndex, r = rIndex; c >= 0 && r < n; c--, r++)
            {
                chessField[c, r] = true;
            }
            for (int c = cIndex, r = rIndex; c < n && r >= 0; c++, r--)
            {
                chessField[c, r] = true;
            }

            return chessField;
        }
    }
}
