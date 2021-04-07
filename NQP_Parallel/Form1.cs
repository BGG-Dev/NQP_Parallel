using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace NQP
{
    public partial class FormMain : Form
    {
        NQP_Solver nqps;
        int n;
        Stopwatch stopwatch = new Stopwatch();
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_RunTask_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(numericUpDown_TaskDimention.Value);
            nqps = new NQP_Solver();

            stopwatch.Start();
            nqps.RunNQPtask(n);
            stopwatch.Stop();
            
            InitializeTable();
            numericUpDown_IndexOfSolution.Maximum = nqps.FinalSolutionSet.Count - 1;
            textBox_SpendedTime.Text = stopwatch.ElapsedMilliseconds.ToString();
            stopwatch.Reset();
        }

        private void numericUpDown_IndexOfSolution_ValueChanged(object sender, EventArgs e)
        {
            DisplaySolution(Convert.ToInt32(numericUpDown_IndexOfSolution.Value));
        }
        private void InitializeTable()
        {
            dataGridView_DiagramView.Columns.Clear();
            textBox_SolutionCount.Text = nqps.FinalSolutionSet.Count.ToString();

            for (int i = 0; i < n; i++)
            {
                dataGridView_DiagramView.Columns.Add(i.ToString(), i.ToString());
                dataGridView_DiagramView.Rows.Add();
            }
        }

        private void DisplaySolution(int indexOfSolution)
        {
            for (int i = 0; i < dataGridView_DiagramView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView_DiagramView.RowCount; j++)
                {
                    dataGridView_DiagramView[i, j].Value = "";
                }
            }
            for (int i = 0; i < n; i++)
            {
                dataGridView_DiagramView[i, nqps.FinalSolutionSet[indexOfSolution][i]].Value = "T";
            }
        }
    }
}
