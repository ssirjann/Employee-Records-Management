namespace EmployeeRecordManagement
{
    partial class EmployeeForm
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
            this.components = new System.ComponentModel.Container();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.designationLabel = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.designationTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.HourlyWageLabel = new System.Windows.Forms.Label();
            this.HourlyWageTxt = new System.Windows.Forms.TextBox();
            this.departmentCBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(248, 544);
            // 
            // windowTitle
            // 
            this.windowTitle.TabIndex = 2;
            this.windowTitle.Text = "Employee Form";
            // 
            // IDLabel
            // 
            this.IDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.IDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IDLabel.Location = new System.Drawing.Point(299, 146);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(99, 31);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDTxt
            // 
            this.IDTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.IDTxt.BackColor = System.Drawing.SystemColors.Window;
            this.IDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.IDTxt.Location = new System.Drawing.Point(398, 147);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(317, 29);
            this.IDTxt.TabIndex = 0;
            this.IDTxt.Enter += new System.EventHandler(this.RemoveError);
            this.IDTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IntField_KeyDown);
            // 
            // addressLabel
            // 
            this.addressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.addressLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addressLabel.Location = new System.Drawing.Point(299, 217);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(99, 31);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressTxt
            // 
            this.addressTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.addressTxt.BackColor = System.Drawing.SystemColors.Window;
            this.addressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addressTxt.Location = new System.Drawing.Point(398, 218);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(317, 29);
            this.addressTxt.TabIndex = 2;
            this.addressTxt.Enter += new System.EventHandler(this.RemoveError);
            // 
            // designationLabel
            // 
            this.designationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.designationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.designationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.designationLabel.Location = new System.Drawing.Point(740, 293);
            this.designationLabel.Name = "designationLabel";
            this.designationLabel.Size = new System.Drawing.Size(99, 31);
            this.designationLabel.TabIndex = 4;
            this.designationLabel.Text = "Designation";
            this.designationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTxt
            // 
            this.emailTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.emailTxt.BackColor = System.Drawing.SystemColors.Window;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.emailTxt.Location = new System.Drawing.Point(398, 293);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(317, 29);
            this.emailTxt.TabIndex = 4;
            this.emailTxt.Enter += new System.EventHandler(this.RemoveError);
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.emailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailLabel.Location = new System.Drawing.Point(299, 293);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(99, 31);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.Location = new System.Drawing.Point(740, 148);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(99, 31);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTxt
            // 
            this.nameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameTxt.Location = new System.Drawing.Point(838, 149);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(318, 29);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.Enter += new System.EventHandler(this.RemoveError);
            // 
            // departmentLabel
            // 
            this.departmentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.departmentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.departmentLabel.Location = new System.Drawing.Point(299, 365);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(99, 31);
            this.departmentLabel.TabIndex = 4;
            this.departmentLabel.Text = "Department";
            this.departmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneLabel
            // 
            this.phoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.phoneLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneLabel.Location = new System.Drawing.Point(740, 216);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(99, 31);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // designationTxt
            // 
            this.designationTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.designationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.designationTxt.Location = new System.Drawing.Point(838, 294);
            this.designationTxt.Name = "designationTxt";
            this.designationTxt.Size = new System.Drawing.Size(317, 29);
            this.designationTxt.TabIndex = 5;
            this.designationTxt.Enter += new System.EventHandler(this.RemoveError);
            // 
            // phoneTxt
            // 
            this.phoneTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.phoneTxt.Location = new System.Drawing.Point(838, 217);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(318, 29);
            this.phoneTxt.TabIndex = 3;
            this.phoneTxt.Enter += new System.EventHandler(this.RemoveError);
            // 
            // HourlyWageLabel
            // 
            this.HourlyWageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.HourlyWageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourlyWageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HourlyWageLabel.Location = new System.Drawing.Point(737, 365);
            this.HourlyWageLabel.Name = "HourlyWageLabel";
            this.HourlyWageLabel.Size = new System.Drawing.Size(102, 31);
            this.HourlyWageLabel.TabIndex = 4;
            this.HourlyWageLabel.Text = "Hourly Wage";
            this.HourlyWageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HourlyWageTxt
            // 
            this.HourlyWageTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.HourlyWageTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HourlyWageTxt.Location = new System.Drawing.Point(839, 366);
            this.HourlyWageTxt.Name = "HourlyWageTxt";
            this.HourlyWageTxt.Size = new System.Drawing.Size(317, 29);
            this.HourlyWageTxt.TabIndex = 7;
            this.HourlyWageTxt.Enter += new System.EventHandler(this.RemoveError);
            this.HourlyWageTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IntField_KeyDown);
            // 
            // departmentCBox
            // 
            this.departmentCBox.BackColor = System.Drawing.Color.White;
            this.departmentCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentCBox.FormattingEnabled = true;
            this.departmentCBox.Location = new System.Drawing.Point(398, 364);
            this.departmentCBox.Name = "departmentCBox";
            this.departmentCBox.Size = new System.Drawing.Size(317, 32);
            this.departmentCBox.TabIndex = 6;
            this.departmentCBox.Enter += new System.EventHandler(this.RemoveError);
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(957, 451);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(77, 34);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(1053, 451);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(77, 34);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 535);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.departmentCBox);
            this.Controls.Add(this.HourlyWageTxt);
            this.Controls.Add(this.HourlyWageLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.designationTxt);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.designationLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.IDLabel);
            this.Name = "EmployeeForm";
            this.Text = "Employee Records Management - Employee Form";
            this.Enter += new System.EventHandler(this.RemoveError);
            this.Controls.SetChildIndex(this.IDLabel, 0);
            this.Controls.SetChildIndex(this.IDTxt, 0);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.Controls.SetChildIndex(this.designationLabel, 0);
            this.Controls.SetChildIndex(this.nameTxt, 0);
            this.Controls.SetChildIndex(this.addressLabel, 0);
            this.Controls.SetChildIndex(this.departmentLabel, 0);
            this.Controls.SetChildIndex(this.emailTxt, 0);
            this.Controls.SetChildIndex(this.phoneLabel, 0);
            this.Controls.SetChildIndex(this.designationTxt, 0);
            this.Controls.SetChildIndex(this.addressTxt, 0);
            this.Controls.SetChildIndex(this.phoneTxt, 0);
            this.Controls.SetChildIndex(this.emailLabel, 0);
            this.Controls.SetChildIndex(this.HourlyWageLabel, 0);
            this.Controls.SetChildIndex(this.HourlyWageTxt, 0);
            this.Controls.SetChildIndex(this.leftPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.departmentCBox, 0);
            this.Controls.SetChildIndex(this.saveBtn, 0);
            this.Controls.SetChildIndex(this.cancelBtn, 0);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label designationLabel;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox designationTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label HourlyWageLabel;
        private System.Windows.Forms.TextBox HourlyWageTxt;
        private System.Windows.Forms.ComboBox departmentCBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}
