using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace NQP
{
    public partial class FormMain : Form
    {
        NQPSolver nqps;
        int n;

        PictureBox[,] chessDesk;
        Stopwatch stopwatch = new Stopwatch();

        public FormMain()
        {
            InitializeComponent();
        }

        private void button_RunTask_Click(object sender, EventArgs e)
        {
            
            //Initialize start variables
            n = Convert.ToInt32(numericUpDown_TaskDimention.Value);
            nqps = new NQPSolver(n);

            //Running main func
            stopwatch.Start();
            nqps.RunNQPtask();
            stopwatch.Stop();

            //Displaying result
            numericUpDown_IndexOfSolution.Maximum = nqps.FinalSolutionSet.Count - 1;
            numericUpDown_IndexOfSolution.Enabled = true;

            dataGridView_RunTimeInfo.Rows.Add();
            dataGridView_RunTimeInfo[0, dataGridView_RunTimeInfo.Rows.Count - 1].Value = n.ToString();
            dataGridView_RunTimeInfo[1, dataGridView_RunTimeInfo.Rows.Count - 1].Value = nqps.FinalSolutionSet.Count.ToString();
            dataGridView_RunTimeInfo[2, dataGridView_RunTimeInfo.Rows.Count - 1].Value = stopwatch.ElapsedMilliseconds.ToString();
            dataGridView_RunTimeInfo[3, dataGridView_RunTimeInfo.Rows.Count - 1].Value = stopwatch.Elapsed.ToString();
            stopwatch.Reset();
            
            
        }

        private void numericUpDown_IndexOfSolution_ValueChanged(object sender, EventArgs e)
        {
            DrawChessDesk();
            DisplaySolution(Convert.ToInt32(numericUpDown_IndexOfSolution.Value));
        }

        private void DrawChessDesk()
        {
            //Clearing components
            panel_ChessDesk.Controls.Clear();
            chessDesk = new PictureBox[n, n];

            //Calculating new cell size
            int cellSize = panel_ChessDesk.Height / n;

            //Building chess desk
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //Creating new cell
                    var newPictureBox = new PictureBox()
                    {
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(cellSize * i, cellSize * j),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    
                    //Adding new cell to desk
                    panel_ChessDesk.Controls.Add(newPictureBox);
                    chessDesk[i, j] = newPictureBox;
                    
                    //Coloring cell
                    if (i % 2 == 0)
                        newPictureBox.BackColor = j % 2 != 0 ? Color.DarkGray : Color.White;
                    else
                        newPictureBox.BackColor = j % 2 != 0 ? Color.White : Color.DarkGray;
                }
            }
        }

        private void DisplaySolution(int indexOfSolution)
        {
            for (int i = 0; i < n; i++)
            {
                Image queen = Image.FromFile("Queen.png");
                chessDesk[i, nqps.FinalSolutionSet[indexOfSolution][i]].Image = queen;
            }
        }        
    }
}