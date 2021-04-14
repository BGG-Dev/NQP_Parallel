
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.button_RunTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_TaskDimention = new System.Windows.Forms.NumericUpDown();
            this.panel_ChessDesk = new System.Windows.Forms.Panel();
            this.dataGridView_RunTimeInfo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_IndexOfSolution = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Column_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SolutionsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MStime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_HMSMStime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TaskDimention)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RunTimeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IndexOfSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Control
            // 
            this.panel_Control.BackColor = System.Drawing.Color.White;
            this.panel_Control.Controls.Add(this.label2);
            this.panel_Control.Controls.Add(this.dataGridView_RunTimeInfo);
            this.panel_Control.Controls.Add(this.label3);
            this.panel_Control.Controls.Add(this.numericUpDown_IndexOfSolution);
            this.panel_Control.Controls.Add(this.button_RunTask);
            this.panel_Control.Controls.Add(this.label1);
            this.panel_Control.Controls.Add(this.numericUpDown_TaskDimention);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(662, 761);
            this.panel_Control.TabIndex = 0;
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
            this.panel_ChessDesk.Location = new System.Drawing.Point(662, 0);
            this.panel_ChessDesk.Name = "panel_ChessDesk";
            this.panel_ChessDesk.Size = new System.Drawing.Size(822, 761);
            this.panel_ChessDesk.TabIndex = 1;
            // 
            // dataGridView_RunTimeInfo
            // 
            this.dataGridView_RunTimeInfo.AllowUserToAddRows = false;
            this.dataGridView_RunTimeInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_RunTimeInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_RunTimeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RunTimeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_n,
            this.Column_SolutionsCount,
            this.Column_MStime,
            this.Column_HMSMStime});
            this.dataGridView_RunTimeInfo.Location = new System.Drawing.Point(12, 275);
            this.dataGridView_RunTimeInfo.Name = "dataGridView_RunTimeInfo";
            this.dataGridView_RunTimeInfo.Size = new System.Drawing.Size(641, 474);
            this.dataGridView_RunTimeInfo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Index of solution to display:";
            // 
            // numericUpDown_IndexOfSolution
            // 
            this.numericUpDown_IndexOfSolution.Enabled = false;
            this.numericUpDown_IndexOfSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_IndexOfSolution.Location = new System.Drawing.Point(12, 178);
            this.numericUpDown_IndexOfSolution.Name = "numericUpDown_IndexOfSolution";
            this.numericUpDown_IndexOfSolution.Size = new System.Drawing.Size(231, 29);
            this.numericUpDown_IndexOfSolution.TabIndex = 5;
            this.numericUpDown_IndexOfSolution.ValueChanged += new System.EventHandler(this.numericUpDown_IndexOfSolution_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Run time info:";
            // 
            // Column_n
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_n.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_n.HeaderText = "n";
            this.Column_n.Name = "Column_n";
            this.Column_n.ReadOnly = true;
            this.Column_n.Width = 50;
            // 
            // Column_SolutionsCount
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_SolutionsCount.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_SolutionsCount.HeaderText = "Solutions count";
            this.Column_SolutionsCount.Name = "Column_SolutionsCount";
            this.Column_SolutionsCount.ReadOnly = true;
            this.Column_SolutionsCount.Width = 200;
            // 
            // Column_MStime
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_MStime.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_MStime.HeaderText = "time (ms)";
            this.Column_MStime.Name = "Column_MStime";
            this.Column_MStime.ReadOnly = true;
            this.Column_MStime.Width = 170;
            // 
            // Column_HMSMStime
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_HMSMStime.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column_HMSMStime.HeaderText = "time (h/m/s/ms)";
            this.Column_HMSMStime.Name = "Column_HMSMStime";
            this.Column_HMSMStime.ReadOnly = true;
            this.Column_HMSMStime.Width = 170;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.panel_ChessDesk);
            this.Controls.Add(this.panel_Control);
            this.MinimumSize = new System.Drawing.Size(1085, 799);
            this.Name = "FormMain";
            this.Text = "NQP_Parallel";
            this.panel_Control.ResumeLayout(false);
            this.panel_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TaskDimention)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RunTimeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IndexOfSolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel panel_ChessDesk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_TaskDimention;
        private System.Windows.Forms.Button button_RunTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_RunTimeInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_IndexOfSolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_n;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SolutionsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MStime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_HMSMStime;
    }
}

