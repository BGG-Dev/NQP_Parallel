
namespace NQP
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Control = new System.Windows.Forms.Panel();
            this.textBox_SpendedTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_IndexOfSolution = new System.Windows.Forms.NumericUpDown();
            this.textBox_SolutionCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_RunTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_TaskDimention = new System.Windows.Forms.NumericUpDown();
            this.panel_ChessDesk = new System.Windows.Forms.Panel();
            this.panel_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IndexOfSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TaskDimention)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Control
            // 
            this.panel_Control.BackColor = System.Drawing.Color.White;
            this.panel_Control.Controls.Add(this.textBox_SpendedTime);
            this.panel_Control.Controls.Add(this.label4);
            this.panel_Control.Controls.Add(this.label3);
            this.panel_Control.Controls.Add(this.numericUpDown_IndexOfSolution);
            this.panel_Control.Controls.Add(this.textBox_SolutionCount);
            this.panel_Control.Controls.Add(this.label2);
            this.panel_Control.Controls.Add(this.button_RunTask);
            this.panel_Control.Controls.Add(this.label1);
            this.panel_Control.Controls.Add(this.numericUpDown_TaskDimention);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(270, 761);
            this.panel_Control.TabIndex = 0;
            // 
            // textBox_SpendedTime
            // 
            this.textBox_SpendedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SpendedTime.Location = new System.Drawing.Point(12, 626);
            this.textBox_SpendedTime.Name = "textBox_SpendedTime";
            this.textBox_SpendedTime.ReadOnly = true;
            this.textBox_SpendedTime.Size = new System.Drawing.Size(246, 29);
            this.textBox_SpendedTime.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spended time (sec):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Index of solution to display:";
            // 
            // numericUpDown_IndexOfSolution
            // 
            this.numericUpDown_IndexOfSolution.Enabled = false;
            this.numericUpDown_IndexOfSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_IndexOfSolution.Location = new System.Drawing.Point(11, 311);
            this.numericUpDown_IndexOfSolution.Name = "numericUpDown_IndexOfSolution";
            this.numericUpDown_IndexOfSolution.Size = new System.Drawing.Size(231, 29);
            this.numericUpDown_IndexOfSolution.TabIndex = 5;
            this.numericUpDown_IndexOfSolution.ValueChanged += new System.EventHandler(this.numericUpDown_IndexOfSolution_ValueChanged);
            // 
            // textBox_SolutionCount
            // 
            this.textBox_SolutionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SolutionCount.Location = new System.Drawing.Point(12, 193);
            this.textBox_SolutionCount.Name = "textBox_SolutionCount";
            this.textBox_SolutionCount.ReadOnly = true;
            this.textBox_SolutionCount.Size = new System.Drawing.Size(231, 29);
            this.textBox_SolutionCount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Solution count:";
            // 
            // button_RunTask
            // 
            this.button_RunTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RunTask.Location = new System.Drawing.Point(12, 88);
            this.button_RunTask.Name = "button_RunTask";
            this.button_RunTask.Size = new System.Drawing.Size(160, 31);
            this.button_RunTask.TabIndex = 2;
            this.button_RunTask.Text = "Run NQP";
            this.button_RunTask.UseVisualStyleBackColor = true;
            this.button_RunTask.Click += new System.EventHandler(this.button_RunTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task dimention:";
            // 
            // numericUpDown_TaskDimention
            // 
            this.numericUpDown_TaskDimention.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_TaskDimention.Location = new System.Drawing.Point(12, 40);
            this.numericUpDown_TaskDimention.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_TaskDimention.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TaskDimention.Name = "numericUpDown_TaskDimention";
            this.numericUpDown_TaskDimention.Size = new System.Drawing.Size(160, 29);
            this.numericUpDown_TaskDimention.TabIndex = 0;
            this.numericUpDown_TaskDimention.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // panel_ChessDesk
            // 
            this.panel_ChessDesk.BackColor = System.Drawing.Color.White;
            this.panel_ChessDesk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ChessDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChessDesk.Location = new System.Drawing.Point(270, 0);
            this.panel_ChessDesk.Name = "panel_ChessDesk";
            this.panel_ChessDesk.Size = new System.Drawing.Size(800, 761);
            this.panel_ChessDesk.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 761);
            this.Controls.Add(this.panel_ChessDesk);
            this.Controls.Add(this.panel_Control);
            this.MinimumSize = new System.Drawing.Size(1085, 799);
            this.Name = "FormMain";
            this.Text = "NQP";
            this.panel_Control.ResumeLayout(false);
            this.panel_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IndexOfSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TaskDimention)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel panel_ChessDesk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_TaskDimention;
        private System.Windows.Forms.TextBox textBox_SolutionCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_RunTask;
        private System.Windows.Forms.NumericUpDown numericUpDown_IndexOfSolution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SpendedTime;
        private System.Windows.Forms.Label label4;
    }
}

