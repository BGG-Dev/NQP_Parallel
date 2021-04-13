using System.Collections.Generic;
using System.Threading.Tasks;

namespace NQP
{
    class NQPSolver
    {
        private readonly int n;

        private readonly List<int[]> finalSolutionSet;

        public IReadOnlyList<int[]> FinalSolutionSet => finalSolutionSet;

        public NQPSolver(int n)
        {
            this.n = n;
            finalSolutionSet = new List<int[]>();
        }

        public void RunNQPtask()
        {
            //Initialize start chess desk
            bool[,] startChessDesk = new bool[n, n];

            //Initialize of solution sets (n array of lists of int arrays)
            List<int[]>[] solutionSets = new List<int[]>[n];

            //Calling main func
            Parallel.For(0, n, (i, state) =>
            {
                //Initializing variables for current stream
                List<int[]> solutionSetForCurrentStream = new List<int[]>();
                solutionSets[i] = solutionSetForCurrentStream;
                int[] figuresPosForCurrentStream = new int[n];

                //Placing first figure on new desk
                figuresPosForCurrentStream[0] = i;
                var nextChessDesk = MarkFields(0, i, startChessDesk);

                //Running algorithm
                RunIteration(1, nextChessDesk, solutionSetForCurrentStream, figuresPosForCurrentStream);
            });

            //Concatinating result
            for (int i = 0; i < n; i++)
            {
                finalSolutionSet.AddRange(solutionSets[i]);
            }
        }

        private void RunIteration(int indexOfCurrentFigure, bool[,] currentChessDesk, List<int[]> solutions, int[] figuresPos)
        {
            if (indexOfCurrentFigure == n)
            {
                //Adding solution to list
                int[] temp = new int[n];
                figuresPos.CopyTo(temp, 0);
                solutions.Add(temp);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!currentChessDesk[indexOfCurrentFigure, i])
                {
                    //Placing figure
                    figuresPos[indexOfCurrentFigure] = i;
                    var nextChessDesk = MarkFields(indexOfCurrentFigure, i, currentChessDesk);

                    //Going next
                    RunIteration(indexOfCurrentFigure + 1, nextChessDesk, solutions, figuresPos);
                }
            }

            return;
        }

        private bool[,] MarkFields(int cIndex, int rIndex, bool[,] originChessDesk)
        {
            //Cloning desk
            bool[,] nextChessDesk = originChessDesk.Clone() as bool[,];

            //column and row
            for (int i = 0; i < n; i++)
            {
                nextChessDesk[cIndex, i] = nextChessDesk[i, rIndex] = true;
            }

            //main diagonal
            for (int c = cIndex, r = rIndex; c < n && r < n; c++, r++)
            {
                nextChessDesk[c, r] = true;
            }
            for (int c = cIndex, r = rIndex; c >= 0 && r >= 0; c--, r--)
            {
                nextChessDesk[c, r] = true;
            }

            //additional diagonal
            for (int c = cIndex, r = rIndex; c >= 0 && r < n; c--, r++)
            {
                nextChessDesk[c, r] = true;
            }
            for (int c = cIndex, r = rIndex; c < n && r >= 0; c++, r--)
            {
                nextChessDesk[c, r] = true;
            }

            return nextChessDesk;
        }
    }
}