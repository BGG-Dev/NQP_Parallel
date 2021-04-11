using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace NQP
{
    public partial class FormMain : Form
    {
        NQP_Solver nqps;
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
            nqps = new NQP_Solver(n);

            //Running main func
            stopwatch.Start();
            nqps.RunNQPtask();
            stopwatch.Stop();
            
            //Preparing result
            numericUpDown_IndexOfSolution.Maximum = nqps.FinalSolutionSet.Count - 1;
            textBox_SpendedTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            textBox_SolutionCount.Text = nqps.FinalSolutionSet.Count.ToString();
            stopwatch.Reset();
            numericUpDown_IndexOfSolution.Enabled = true;
        }

        private void numericUpDown_IndexOfSolution_ValueChanged(object sender, EventArgs e)
        {
            DrawChessDesk();
            DisplaySolution(Convert.ToInt32(numericUpDown_IndexOfSolution.Value));
        }

        private void DrawChessDesk()
        {
            panel_ChessDesk.Controls.Clear();
            int cellSize = panel_ChessDesk.Height / n;

            chessDesk = new PictureBox[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var newPictureBox = new PictureBox()
                    {
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(cellSize * i, cellSize * j),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    
                    panel_ChessDesk.Controls.Add(newPictureBox);
                                        
                    chessDesk[i, j] = newPictureBox;
                    
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
