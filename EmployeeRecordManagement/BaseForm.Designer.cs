namespace EmployeeRecordManagement
{
    partial class BaseForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.windowTitle = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.headContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.headContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.topPanel.Controls.Add(this.windowTitle);
            this.topPanel.Location = new System.Drawing.Point(246, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(909, 96);
            this.topPanel.TabIndex = 3;
            // 
            // windowTitle
            // 
            this.windowTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowTitle.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.windowTitle.Location = new System.Drawing.Point(0, 0);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(909, 96);
            this.windowTitle.TabIndex = 3;
            this.windowTitle.Text = "Window title goes here";
            this.windowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.leftPanel.Controls.Add(this.headContainer);
            this.leftPanel.Location = new System.Drawing.Point(0, -1);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(248, 533);
            this.leftPanel.TabIndex = 2;
            // 
            // headContainer
            // 
            this.headContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.headContainer.Controls.Add(this.label1);
            this.headContainer.Controls.Add(this.title);
            this.headContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.headContainer.Location = new System.Drawing.Point(0, 0);
            this.headContainer.Name = "headContainer";
            this.headContainer.Size = new System.Drawing.Size(248, 96);
            this.headContainer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(24, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(206, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Employee Records";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1150, 529);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Records Management";
            this.topPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.headContainer.ResumeLayout(false);
            this.headContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headContainer;
        private System.Windows.Forms.Label title;
        protected System.Windows.Forms.Panel topPanel;
        protected System.Windows.Forms.Panel leftPanel;
        protected System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.Label label1;
    }
}