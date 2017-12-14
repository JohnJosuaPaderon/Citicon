namespace Citicon.Forms.Dialogs
{
    partial class AddEditProjectDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditProjectDialog));
            this.ProjectDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.QuotationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.QuotationTypeLabel = new System.Windows.Forms.Label();
            this.InitialCementNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InitialPaymentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.InitialCementLabel = new System.Windows.Forms.Label();
            this.InitialPaymentLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.CompletedCheckBox = new System.Windows.Forms.CheckBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ProjectDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InitialCementNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialPaymentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectDetailsGroupBox
            // 
            this.ProjectDetailsGroupBox.Controls.Add(this.QuotationTypeComboBox);
            this.ProjectDetailsGroupBox.Controls.Add(this.QuotationTypeLabel);
            this.ProjectDetailsGroupBox.Controls.Add(this.InitialCementNumericUpDown);
            this.ProjectDetailsGroupBox.Controls.Add(this.InitialPaymentNumericUpDown);
            this.ProjectDetailsGroupBox.Controls.Add(this.TypeComboBox);
            this.ProjectDetailsGroupBox.Controls.Add(this.InitialCementLabel);
            this.ProjectDetailsGroupBox.Controls.Add(this.InitialPaymentLabel);
            this.ProjectDetailsGroupBox.Controls.Add(this.TypeLabel);
            this.ProjectDetailsGroupBox.Controls.Add(this.CompletedCheckBox);
            this.ProjectDetailsGroupBox.Controls.Add(this.LocationTextBox);
            this.ProjectDetailsGroupBox.Controls.Add(this.LocationLabel);
            this.ProjectDetailsGroupBox.Controls.Add(this.NameTextBox);
            this.ProjectDetailsGroupBox.Controls.Add(this.NameLabel);
            this.ProjectDetailsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ProjectDetailsGroupBox.Name = "ProjectDetailsGroupBox";
            this.ProjectDetailsGroupBox.Size = new System.Drawing.Size(413, 323);
            this.ProjectDetailsGroupBox.TabIndex = 1;
            this.ProjectDetailsGroupBox.TabStop = false;
            this.ProjectDetailsGroupBox.Text = "Project Details";
            // 
            // QuotationTypeComboBox
            // 
            this.QuotationTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuotationTypeComboBox.FormattingEnabled = true;
            this.QuotationTypeComboBox.Location = new System.Drawing.Point(10, 285);
            this.QuotationTypeComboBox.Name = "QuotationTypeComboBox";
            this.QuotationTypeComboBox.Size = new System.Drawing.Size(390, 25);
            this.QuotationTypeComboBox.TabIndex = 12;
            this.QuotationTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.QuotationTypeComboBox_SelectedIndexChanged);
            // 
            // QuotationTypeLabel
            // 
            this.QuotationTypeLabel.AutoSize = true;
            this.QuotationTypeLabel.Location = new System.Drawing.Point(7, 265);
            this.QuotationTypeLabel.Name = "QuotationTypeLabel";
            this.QuotationTypeLabel.Size = new System.Drawing.Size(97, 17);
            this.QuotationTypeLabel.TabIndex = 13;
            this.QuotationTypeLabel.Text = "Quotation Type";
            // 
            // InitialCementNumericUpDown
            // 
            this.InitialCementNumericUpDown.DecimalPlaces = 3;
            this.InitialCementNumericUpDown.Location = new System.Drawing.Point(10, 237);
            this.InitialCementNumericUpDown.Name = "InitialCementNumericUpDown";
            this.InitialCementNumericUpDown.Size = new System.Drawing.Size(390, 25);
            this.InitialCementNumericUpDown.TabIndex = 11;
            this.InitialCementNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InitialCementNumericUpDown.ValueChanged += new System.EventHandler(this.InitialCementNumericUpDown_ValueChanged);
            // 
            // InitialPaymentNumericUpDown
            // 
            this.InitialPaymentNumericUpDown.DecimalPlaces = 2;
            this.InitialPaymentNumericUpDown.Location = new System.Drawing.Point(10, 189);
            this.InitialPaymentNumericUpDown.Name = "InitialPaymentNumericUpDown";
            this.InitialPaymentNumericUpDown.Size = new System.Drawing.Size(390, 25);
            this.InitialPaymentNumericUpDown.TabIndex = 10;
            this.InitialPaymentNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InitialPaymentNumericUpDown.ValueChanged += new System.EventHandler(this.InitialPaymentNumericUpDown_ValueChanged);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(10, 141);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(390, 25);
            this.TypeComboBox.TabIndex = 3;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // InitialCementLabel
            // 
            this.InitialCementLabel.AutoSize = true;
            this.InitialCementLabel.Location = new System.Drawing.Point(7, 217);
            this.InitialCementLabel.Name = "InitialCementLabel";
            this.InitialCementLabel.Size = new System.Drawing.Size(86, 17);
            this.InitialCementLabel.TabIndex = 9;
            this.InitialCementLabel.Text = "Initial Cement";
            // 
            // InitialPaymentLabel
            // 
            this.InitialPaymentLabel.AutoSize = true;
            this.InitialPaymentLabel.Location = new System.Drawing.Point(7, 169);
            this.InitialPaymentLabel.Name = "InitialPaymentLabel";
            this.InitialPaymentLabel.Size = new System.Drawing.Size(91, 17);
            this.InitialPaymentLabel.TabIndex = 7;
            this.InitialPaymentLabel.Text = "Initial Payment";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(7, 121);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(35, 17);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "Type";
            // 
            // CompletedCheckBox
            // 
            this.CompletedCheckBox.AutoSize = true;
            this.CompletedCheckBox.Location = new System.Drawing.Point(313, 21);
            this.CompletedCheckBox.Name = "CompletedCheckBox";
            this.CompletedCheckBox.Size = new System.Drawing.Size(91, 21);
            this.CompletedCheckBox.TabIndex = 0;
            this.CompletedCheckBox.Text = "Completed";
            this.CompletedCheckBox.UseVisualStyleBackColor = true;
            this.CompletedCheckBox.CheckedChanged += new System.EventHandler(this.CompletedCheckBox_CheckedChanged);
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.BackColor = System.Drawing.Color.White;
            this.LocationTextBox.Location = new System.Drawing.Point(10, 93);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(390, 25);
            this.LocationTextBox.TabIndex = 2;
            this.LocationTextBox.TextChanged += new System.EventHandler(this.LocationTextBox_TextChanged);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(7, 73);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(57, 17);
            this.LocationLabel.TabIndex = 2;
            this.LocationLabel.Text = "Location";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.Location = new System.Drawing.Point(10, 45);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(390, 25);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(7, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(43, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Red;
            this.CancelButton.Location = new System.Drawing.Point(323, 341);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 35);
            this.CancelButton.TabIndex = 123;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Red;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(215, 341);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 35);
            this.SaveButton.TabIndex = 122;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddEditProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 388);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProjectDetailsGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditProjectDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit Project";
            this.Load += new System.EventHandler(this.AddEditProjectDialog_Load);
            this.ProjectDetailsGroupBox.ResumeLayout(false);
            this.ProjectDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InitialCementNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialPaymentNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProjectDetailsGroupBox;
        private System.Windows.Forms.Label InitialCementLabel;
        private System.Windows.Forms.Label InitialPaymentLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.CheckBox CompletedCheckBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NumericUpDown InitialCementNumericUpDown;
        private System.Windows.Forms.NumericUpDown InitialPaymentNumericUpDown;
        private System.Windows.Forms.ComboBox QuotationTypeComboBox;
        private System.Windows.Forms.Label QuotationTypeLabel;
    }
}