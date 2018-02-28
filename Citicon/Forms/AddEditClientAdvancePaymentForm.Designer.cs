namespace Citicon.Forms
{
    partial class AddEditClientAdvancePaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditClientAdvancePaymentForm));
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.AddedValueLabel = new System.Windows.Forms.Label();
            this.AddedValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddedValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(12, 9);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(40, 17);
            this.ClientLabel.TabIndex = 0;
            this.ClientLabel.Text = "Client";
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.Location = new System.Drawing.Point(15, 29);
            this.ClientTextBox.Multiline = true;
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.ReadOnly = true;
            this.ClientTextBox.Size = new System.Drawing.Size(449, 50);
            this.ClientTextBox.TabIndex = 1;
            // 
            // AddedValueLabel
            // 
            this.AddedValueLabel.AutoSize = true;
            this.AddedValueLabel.Location = new System.Drawing.Point(12, 82);
            this.AddedValueLabel.Name = "AddedValueLabel";
            this.AddedValueLabel.Size = new System.Drawing.Size(82, 17);
            this.AddedValueLabel.TabIndex = 2;
            this.AddedValueLabel.Text = "Added Value";
            // 
            // AddedValueNumericUpDown
            // 
            this.AddedValueNumericUpDown.DecimalPlaces = 2;
            this.AddedValueNumericUpDown.Location = new System.Drawing.Point(15, 102);
            this.AddedValueNumericUpDown.Name = "AddedValueNumericUpDown";
            this.AddedValueNumericUpDown.Size = new System.Drawing.Size(449, 25);
            this.AddedValueNumericUpDown.TabIndex = 3;
            this.AddedValueNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddedValueNumericUpDown.ThousandsSeparator = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.Red;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(258, 141);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 40);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelFormButton.BackColor = System.Drawing.Color.White;
            this.CancelFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelFormButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelFormButton.ForeColor = System.Drawing.Color.Red;
            this.CancelFormButton.Location = new System.Drawing.Point(364, 141);
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(100, 40);
            this.CancelFormButton.TabIndex = 16;
            this.CancelFormButton.Text = "Cancel";
            this.CancelFormButton.UseVisualStyleBackColor = false;
            this.CancelFormButton.Click += new System.EventHandler(this.CancelFormButton_Click);
            // 
            // AddEditClientAdvancePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 193);
            this.Controls.Add(this.CancelFormButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddedValueNumericUpDown);
            this.Controls.Add(this.AddedValueLabel);
            this.Controls.Add(this.ClientTextBox);
            this.Controls.Add(this.ClientLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditClientAdvancePaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit Client Advance Payment";
            this.Load += new System.EventHandler(this.AddEditClientAdvancePaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddedValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label AddedValueLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelFormButton;
        public System.Windows.Forms.TextBox ClientTextBox;
        public System.Windows.Forms.NumericUpDown AddedValueNumericUpDown;
    }
}