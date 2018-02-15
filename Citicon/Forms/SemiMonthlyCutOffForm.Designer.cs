namespace Citicon.Forms
{
    partial class SemiMonthlyCutOffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemiMonthlyCutOffForm));
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.FirstCutOffRadioButton = new System.Windows.Forms.RadioButton();
            this.SecondCutOffRadioButton = new System.Windows.Forms.RadioButton();
            this.DoneButton = new System.Windows.Forms.Button();
            this.CancelFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(12, 9);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(33, 17);
            this.YearLabel.TabIndex = 0;
            this.YearLabel.Text = "Year";
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Location = new System.Drawing.Point(15, 29);
            this.YearNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.YearNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.YearNumericUpDown.Name = "YearNumericUpDown";
            this.YearNumericUpDown.Size = new System.Drawing.Size(123, 25);
            this.YearNumericUpDown.TabIndex = 1;
            this.YearNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(144, 29);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(262, 25);
            this.MonthComboBox.TabIndex = 2;
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(141, 9);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(46, 17);
            this.MonthLabel.TabIndex = 3;
            this.MonthLabel.Text = "Month";
            // 
            // FirstCutOffRadioButton
            // 
            this.FirstCutOffRadioButton.AutoSize = true;
            this.FirstCutOffRadioButton.Location = new System.Drawing.Point(15, 60);
            this.FirstCutOffRadioButton.Name = "FirstCutOffRadioButton";
            this.FirstCutOffRadioButton.Size = new System.Drawing.Size(89, 21);
            this.FirstCutOffRadioButton.TabIndex = 4;
            this.FirstCutOffRadioButton.TabStop = true;
            this.FirstCutOffRadioButton.Text = "1st Cut-Off";
            this.FirstCutOffRadioButton.UseVisualStyleBackColor = true;
            // 
            // SecondCutOffRadioButton
            // 
            this.SecondCutOffRadioButton.AutoSize = true;
            this.SecondCutOffRadioButton.Location = new System.Drawing.Point(110, 60);
            this.SecondCutOffRadioButton.Name = "SecondCutOffRadioButton";
            this.SecondCutOffRadioButton.Size = new System.Drawing.Size(94, 21);
            this.SecondCutOffRadioButton.TabIndex = 5;
            this.SecondCutOffRadioButton.TabStop = true;
            this.SecondCutOffRadioButton.Text = "2nd Cut-Off";
            this.SecondCutOffRadioButton.UseVisualStyleBackColor = true;
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.Red;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(200, 85);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(100, 40);
            this.DoneButton.TabIndex = 13;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelFormButton.BackColor = System.Drawing.Color.White;
            this.CancelFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelFormButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelFormButton.ForeColor = System.Drawing.Color.Red;
            this.CancelFormButton.Location = new System.Drawing.Point(306, 85);
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(100, 40);
            this.CancelFormButton.TabIndex = 14;
            this.CancelFormButton.Text = "Cancel";
            this.CancelFormButton.UseVisualStyleBackColor = false;
            this.CancelFormButton.Click += new System.EventHandler(this.CancelFormButton_Click);
            // 
            // SemiMonthlyCutOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 137);
            this.Controls.Add(this.CancelFormButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.SecondCutOffRadioButton);
            this.Controls.Add(this.FirstCutOffRadioButton);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.YearNumericUpDown);
            this.Controls.Add(this.YearLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SemiMonthlyCutOffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Cut-Off";
            this.Load += new System.EventHandler(this.SemiMonthlyCutOffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button CancelFormButton;
        public System.Windows.Forms.NumericUpDown YearNumericUpDown;
        public System.Windows.Forms.ComboBox MonthComboBox;
        public System.Windows.Forms.RadioButton FirstCutOffRadioButton;
        public System.Windows.Forms.RadioButton SecondCutOffRadioButton;
    }
}