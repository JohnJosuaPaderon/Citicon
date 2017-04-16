namespace Citicon.Forms.Dialogs
{
    partial class AddEditHolidayDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditHolidayDialog));
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DateOccurLabel = new System.Windows.Forms.Label();
            this.DateOccurDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.CancelHolidayButton = new System.Windows.Forms.Button();
            this.SaveHolidayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(43, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(16, 33);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(333, 25);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // DateOccurLabel
            // 
            this.DateOccurLabel.AutoSize = true;
            this.DateOccurLabel.Location = new System.Drawing.Point(13, 61);
            this.DateOccurLabel.Name = "DateOccurLabel";
            this.DateOccurLabel.Size = new System.Drawing.Size(35, 17);
            this.DateOccurLabel.TabIndex = 2;
            this.DateOccurLabel.Text = "Date";
            // 
            // DateOccurDateTimePicker
            // 
            this.DateOccurDateTimePicker.CustomFormat = "MMMM dd, yyyy (dddd)";
            this.DateOccurDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOccurDateTimePicker.Location = new System.Drawing.Point(16, 82);
            this.DateOccurDateTimePicker.Name = "DateOccurDateTimePicker";
            this.DateOccurDateTimePicker.Size = new System.Drawing.Size(333, 25);
            this.DateOccurDateTimePicker.TabIndex = 3;
            this.DateOccurDateTimePicker.ValueChanged += new System.EventHandler(this.DateOccurDateTimePicker_ValueChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(13, 110);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(35, 17);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Type";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(16, 131);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(333, 25);
            this.TypeComboBox.TabIndex = 5;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // CancelHolidayButton
            // 
            this.CancelHolidayButton.BackColor = System.Drawing.Color.White;
            this.CancelHolidayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelHolidayButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelHolidayButton.ForeColor = System.Drawing.Color.Red;
            this.CancelHolidayButton.Location = new System.Drawing.Point(248, 162);
            this.CancelHolidayButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelHolidayButton.Name = "CancelHolidayButton";
            this.CancelHolidayButton.Size = new System.Drawing.Size(100, 35);
            this.CancelHolidayButton.TabIndex = 123;
            this.CancelHolidayButton.Text = "CANCEL";
            this.CancelHolidayButton.UseVisualStyleBackColor = false;
            this.CancelHolidayButton.Click += new System.EventHandler(this.CancelHolidayButton_Click);
            // 
            // SaveHolidayButton
            // 
            this.SaveHolidayButton.BackColor = System.Drawing.Color.Red;
            this.SaveHolidayButton.FlatAppearance.BorderSize = 0;
            this.SaveHolidayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveHolidayButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveHolidayButton.ForeColor = System.Drawing.Color.White;
            this.SaveHolidayButton.Location = new System.Drawing.Point(140, 162);
            this.SaveHolidayButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveHolidayButton.Name = "SaveHolidayButton";
            this.SaveHolidayButton.Size = new System.Drawing.Size(100, 35);
            this.SaveHolidayButton.TabIndex = 122;
            this.SaveHolidayButton.Text = "SAVE";
            this.SaveHolidayButton.UseVisualStyleBackColor = false;
            this.SaveHolidayButton.Click += new System.EventHandler(this.SaveHolidayButton_Click);
            // 
            // AddEditHolidayDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 208);
            this.Controls.Add(this.CancelHolidayButton);
            this.Controls.Add(this.SaveHolidayButton);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.DateOccurDateTimePicker);
            this.Controls.Add(this.DateOccurLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditHolidayDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit Holiday";
            this.Load += new System.EventHandler(this.AddEditHolidayDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label DateOccurLabel;
        private System.Windows.Forms.DateTimePicker DateOccurDateTimePicker;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button CancelHolidayButton;
        private System.Windows.Forms.Button SaveHolidayButton;
    }
}