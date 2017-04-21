namespace Citicon.Forms.Dialogs
{
    partial class AddEditTransitMixerDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditTransitMixerDialog));
            this.PhysicalNumberLabel = new System.Windows.Forms.Label();
            this.PhysicalNumberTextBox = new System.Windows.Forms.TextBox();
            this.PlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.PlateNumberLabel = new System.Windows.Forms.Label();
            this.VolumeCapacityLabel = new System.Windows.Forms.Label();
            this.VolumeCapacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CancelOperationButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DefaultDriverCheckBox = new System.Windows.Forms.CheckBox();
            this.DefaultDriverComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeCapacityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PhysicalNumberLabel
            // 
            this.PhysicalNumberLabel.AutoSize = true;
            this.PhysicalNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.PhysicalNumberLabel.Name = "PhysicalNumberLabel";
            this.PhysicalNumberLabel.Size = new System.Drawing.Size(58, 17);
            this.PhysicalNumberLabel.TabIndex = 0;
            this.PhysicalNumberLabel.Text = "T.M. No.";
            // 
            // PhysicalNumberTextBox
            // 
            this.PhysicalNumberTextBox.Location = new System.Drawing.Point(15, 29);
            this.PhysicalNumberTextBox.Name = "PhysicalNumberTextBox";
            this.PhysicalNumberTextBox.Size = new System.Drawing.Size(303, 25);
            this.PhysicalNumberTextBox.TabIndex = 1;
            this.PhysicalNumberTextBox.TextChanged += new System.EventHandler(this.PhysicalNumberTextBox_TextChanged);
            // 
            // PlateNumberTextBox
            // 
            this.PlateNumberTextBox.Location = new System.Drawing.Point(15, 77);
            this.PlateNumberTextBox.Name = "PlateNumberTextBox";
            this.PlateNumberTextBox.Size = new System.Drawing.Size(303, 25);
            this.PlateNumberTextBox.TabIndex = 3;
            this.PlateNumberTextBox.TextChanged += new System.EventHandler(this.PlateNumberTextBox_TextChanged);
            // 
            // PlateNumberLabel
            // 
            this.PlateNumberLabel.AutoSize = true;
            this.PlateNumberLabel.Location = new System.Drawing.Point(12, 57);
            this.PlateNumberLabel.Name = "PlateNumberLabel";
            this.PlateNumberLabel.Size = new System.Drawing.Size(61, 17);
            this.PlateNumberLabel.TabIndex = 2;
            this.PlateNumberLabel.Text = "Plate No.";
            // 
            // VolumeCapacityLabel
            // 
            this.VolumeCapacityLabel.AutoSize = true;
            this.VolumeCapacityLabel.Location = new System.Drawing.Point(12, 105);
            this.VolumeCapacityLabel.Name = "VolumeCapacityLabel";
            this.VolumeCapacityLabel.Size = new System.Drawing.Size(82, 17);
            this.VolumeCapacityLabel.TabIndex = 4;
            this.VolumeCapacityLabel.Text = "Vol. Capacity";
            // 
            // VolumeCapacityNumericUpDown
            // 
            this.VolumeCapacityNumericUpDown.DecimalPlaces = 3;
            this.VolumeCapacityNumericUpDown.Location = new System.Drawing.Point(15, 125);
            this.VolumeCapacityNumericUpDown.Name = "VolumeCapacityNumericUpDown";
            this.VolumeCapacityNumericUpDown.Size = new System.Drawing.Size(303, 25);
            this.VolumeCapacityNumericUpDown.TabIndex = 5;
            this.VolumeCapacityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VolumeCapacityNumericUpDown.ThousandsSeparator = true;
            this.VolumeCapacityNumericUpDown.ValueChanged += new System.EventHandler(this.VolumeCapacityNumericUpDown_ValueChanged);
            // 
            // CancelOperationButton
            // 
            this.CancelOperationButton.BackColor = System.Drawing.Color.White;
            this.CancelOperationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelOperationButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelOperationButton.ForeColor = System.Drawing.Color.Red;
            this.CancelOperationButton.Location = new System.Drawing.Point(218, 215);
            this.CancelOperationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelOperationButton.Name = "CancelOperationButton";
            this.CancelOperationButton.Size = new System.Drawing.Size(100, 35);
            this.CancelOperationButton.TabIndex = 123;
            this.CancelOperationButton.Text = "CANCEL";
            this.CancelOperationButton.UseVisualStyleBackColor = false;
            this.CancelOperationButton.Click += new System.EventHandler(this.CancelOperationButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Red;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(110, 215);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 35);
            this.SaveButton.TabIndex = 122;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DefaultDriverCheckBox
            // 
            this.DefaultDriverCheckBox.AutoSize = true;
            this.DefaultDriverCheckBox.Checked = true;
            this.DefaultDriverCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultDriverCheckBox.Location = new System.Drawing.Point(15, 157);
            this.DefaultDriverCheckBox.Name = "DefaultDriverCheckBox";
            this.DefaultDriverCheckBox.Size = new System.Drawing.Size(107, 21);
            this.DefaultDriverCheckBox.TabIndex = 124;
            this.DefaultDriverCheckBox.Text = "Default Driver";
            this.DefaultDriverCheckBox.UseVisualStyleBackColor = true;
            this.DefaultDriverCheckBox.CheckedChanged += new System.EventHandler(this.DefaultDriverCheckBox_CheckedChanged);
            // 
            // DefaultDriverComboBox
            // 
            this.DefaultDriverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefaultDriverComboBox.FormattingEnabled = true;
            this.DefaultDriverComboBox.Location = new System.Drawing.Point(15, 184);
            this.DefaultDriverComboBox.Name = "DefaultDriverComboBox";
            this.DefaultDriverComboBox.Size = new System.Drawing.Size(303, 25);
            this.DefaultDriverComboBox.TabIndex = 125;
            this.DefaultDriverComboBox.SelectedIndexChanged += new System.EventHandler(this.DefaultDriverComboBox_SelectedIndexChanged);
            // 
            // AddEditTransitMixerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 264);
            this.Controls.Add(this.DefaultDriverComboBox);
            this.Controls.Add(this.DefaultDriverCheckBox);
            this.Controls.Add(this.CancelOperationButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.VolumeCapacityNumericUpDown);
            this.Controls.Add(this.VolumeCapacityLabel);
            this.Controls.Add(this.PlateNumberTextBox);
            this.Controls.Add(this.PlateNumberLabel);
            this.Controls.Add(this.PhysicalNumberTextBox);
            this.Controls.Add(this.PhysicalNumberLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditTransitMixerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit Transit Mixer";
            this.Load += new System.EventHandler(this.AddEditTransitMixerDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeCapacityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhysicalNumberLabel;
        private System.Windows.Forms.TextBox PhysicalNumberTextBox;
        private System.Windows.Forms.TextBox PlateNumberTextBox;
        private System.Windows.Forms.Label PlateNumberLabel;
        private System.Windows.Forms.Label VolumeCapacityLabel;
        private System.Windows.Forms.NumericUpDown VolumeCapacityNumericUpDown;
        private System.Windows.Forms.Button CancelOperationButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox DefaultDriverCheckBox;
        private System.Windows.Forms.ComboBox DefaultDriverComboBox;
    }
}