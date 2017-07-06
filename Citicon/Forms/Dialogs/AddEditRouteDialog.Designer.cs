namespace Citicon.Forms.Dialogs
{
    partial class AddEditRouteDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditRouteDialog));
            this.RateLabel = new System.Windows.Forms.Label();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(12, 153);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(34, 17);
            this.RateLabel.TabIndex = 13;
            this.RateLabel.Text = "Rate";
            // 
            // ToTextBox
            // 
            this.ToTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToTextBox.Location = new System.Drawing.Point(15, 125);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(294, 25);
            this.ToTextBox.TabIndex = 12;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(12, 105);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(22, 17);
            this.ToLabel.TabIndex = 11;
            this.ToLabel.Text = "To";
            // 
            // FromTextBox
            // 
            this.FromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FromTextBox.Location = new System.Drawing.Point(15, 77);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(294, 25);
            this.FromTextBox.TabIndex = 10;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(12, 57);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(38, 17);
            this.FromLabel.TabIndex = 9;
            this.FromLabel.Text = "From";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(15, 29);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(294, 25);
            this.NameTextBox.TabIndex = 8;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(43, 17);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name";
            // 
            // RateNumericUpDown
            // 
            this.RateNumericUpDown.DecimalPlaces = 2;
            this.RateNumericUpDown.Location = new System.Drawing.Point(15, 174);
            this.RateNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RateNumericUpDown.Name = "RateNumericUpDown";
            this.RateNumericUpDown.Size = new System.Drawing.Size(294, 25);
            this.RateNumericUpDown.TabIndex = 14;
            this.RateNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RateNumericUpDown.ThousandsSeparator = true;
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.BackColor = System.Drawing.Color.White;
            this.CancelDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelDialogButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelDialogButton.ForeColor = System.Drawing.Color.Red;
            this.CancelDialogButton.Location = new System.Drawing.Point(209, 205);
            this.CancelDialogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(100, 35);
            this.CancelDialogButton.TabIndex = 123;
            this.CancelDialogButton.Text = "CANCEL";
            this.CancelDialogButton.UseVisualStyleBackColor = false;
            this.CancelDialogButton.Click += new System.EventHandler(this.CancelDialogButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Red;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(101, 205);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 35);
            this.SaveButton.TabIndex = 122;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddEditRouteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 252);
            this.Controls.Add(this.CancelDialogButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RateNumericUpDown);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditRouteDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit Routes";
            ((System.ComponentModel.ISupportInitialize)(this.RateNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.NumericUpDown RateNumericUpDown;
        private System.Windows.Forms.Button CancelDialogButton;
        private System.Windows.Forms.Button SaveButton;
    }
}