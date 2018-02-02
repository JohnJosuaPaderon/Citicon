namespace Citicon.Forms
{
    partial class SemiMonthlyPayrollForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemiMonthlyPayrollForm));
            this.BranchLabel = new System.Windows.Forms.Label();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.CutOffLabel = new System.Windows.Forms.Label();
            this.CutOffBeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CutOffToLabel = new System.Windows.Forms.Label();
            this.CutOffEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BranchLabel
            // 
            this.BranchLabel.AutoSize = true;
            this.BranchLabel.Location = new System.Drawing.Point(13, 13);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(47, 17);
            this.BranchLabel.TabIndex = 0;
            this.BranchLabel.Text = "Branch";
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(16, 34);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(197, 25);
            this.BranchComboBox.TabIndex = 1;
            // 
            // CutOffLabel
            // 
            this.CutOffLabel.AutoSize = true;
            this.CutOffLabel.Location = new System.Drawing.Point(216, 13);
            this.CutOffLabel.Name = "CutOffLabel";
            this.CutOffLabel.Size = new System.Drawing.Size(50, 17);
            this.CutOffLabel.TabIndex = 2;
            this.CutOffLabel.Text = "Cut-Off";
            // 
            // CutOffBeginDateTimePicker
            // 
            this.CutOffBeginDateTimePicker.CustomFormat = "MMMM d, yyyy";
            this.CutOffBeginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CutOffBeginDateTimePicker.Location = new System.Drawing.Point(219, 34);
            this.CutOffBeginDateTimePicker.Name = "CutOffBeginDateTimePicker";
            this.CutOffBeginDateTimePicker.Size = new System.Drawing.Size(197, 25);
            this.CutOffBeginDateTimePicker.TabIndex = 3;
            // 
            // CutOffToLabel
            // 
            this.CutOffToLabel.AutoSize = true;
            this.CutOffToLabel.Location = new System.Drawing.Point(425, 40);
            this.CutOffToLabel.Name = "CutOffToLabel";
            this.CutOffToLabel.Size = new System.Drawing.Size(20, 17);
            this.CutOffToLabel.TabIndex = 4;
            this.CutOffToLabel.Text = "to";
            // 
            // CutOffEndDateTimePicker
            // 
            this.CutOffEndDateTimePicker.CustomFormat = "MMMM d, yyyy";
            this.CutOffEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CutOffEndDateTimePicker.Location = new System.Drawing.Point(451, 34);
            this.CutOffEndDateTimePicker.Name = "CutOffEndDateTimePicker";
            this.CutOffEndDateTimePicker.Size = new System.Drawing.Size(197, 25);
            this.CutOffEndDateTimePicker.TabIndex = 5;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.Red;
            this.GenerateButton.FlatAppearance.BorderSize = 0;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.Location = new System.Drawing.Point(548, 65);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(100, 40);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SemiMonthlyPayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 642);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CutOffEndDateTimePicker);
            this.Controls.Add(this.CutOffToLabel);
            this.Controls.Add(this.CutOffBeginDateTimePicker);
            this.Controls.Add(this.CutOffLabel);
            this.Controls.Add(this.BranchComboBox);
            this.Controls.Add(this.BranchLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SemiMonthlyPayrollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semi-Monthly Payroll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BranchLabel;
        public System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.Label CutOffLabel;
        public System.Windows.Forms.DateTimePicker CutOffBeginDateTimePicker;
        private System.Windows.Forms.Label CutOffToLabel;
        public System.Windows.Forms.DateTimePicker CutOffEndDateTimePicker;
        private System.Windows.Forms.Button GenerateButton;
    }
}