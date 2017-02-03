namespace EmployeeRecordManagement
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.payrollChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.closeBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payrollChart)).BeginInit();
            this.SuspendLayout();
            // 
            // windowTitle
            // 
            this.windowTitle.Text = "Earning Chart Based on Departments\' Total Earning";
            // 
            // payrollChart
            // 
            this.payrollChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.payrollChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.payrollChart.BorderlineWidth = 0;
            this.payrollChart.BorderSkin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.payrollChart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.payrollChart.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.payrollChart.BorderSkin.BorderColor = System.Drawing.Color.SaddleBrown;
            this.payrollChart.BorderSkin.PageColor = System.Drawing.SystemColors.WindowFrame;
            chartArea1.Name = "ChartArea1";
            this.payrollChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.payrollChart.Legends.Add(legend1);
            this.payrollChart.Location = new System.Drawing.Point(246, 94);
            this.payrollChart.Name = "payrollChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            series1.Legend = "Legend1";
            series1.Name = "chartSeries";
            this.payrollChart.Series.Add(series1);
            this.payrollChart.Size = new System.Drawing.Size(906, 435);
            this.payrollChart.TabIndex = 4;
            this.payrollChart.Text = "Payroll Chart";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(1061, 483);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(77, 34);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1150, 529);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.payrollChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Chart";
            this.Text = "Employee Records Management - Weekly earning chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            this.Controls.SetChildIndex(this.payrollChart, 0);
            this.Controls.SetChildIndex(this.leftPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.closeBtn, 0);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payrollChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart payrollChart;
        private System.Windows.Forms.Button closeBtn;

    }
}
