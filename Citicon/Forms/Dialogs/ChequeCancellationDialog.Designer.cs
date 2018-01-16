namespace Citicon.Forms.Dialogs
{
    partial class ChequeCancellationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequeCancellationDialog));
            this.BankLabel = new System.Windows.Forms.Label();
            this.BankComboBox = new System.Windows.Forms.ComboBox();
            this.BankAccountComboBox = new System.Windows.Forms.ComboBox();
            this.BankAccountLabel = new System.Windows.Forms.Label();
            this.ChequeNumberLabel = new System.Windows.Forms.Label();
            this.ChequeNumberTextBox = new System.Windows.Forms.TextBox();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.RemarksLabel = new System.Windows.Forms.Label();
            this.CancelChequeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BankLabel
            // 
            this.BankLabel.AutoSize = true;
            this.BankLabel.Location = new System.Drawing.Point(12, 13);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(35, 17);
            this.BankLabel.TabIndex = 0;
            this.BankLabel.Text = "Bank";
            // 
            // BankComboBox
            // 
            this.BankComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BankComboBox.FormattingEnabled = true;
            this.BankComboBox.Location = new System.Drawing.Point(12, 33);
            this.BankComboBox.Name = "BankComboBox";
            this.BankComboBox.Size = new System.Drawing.Size(307, 25);
            this.BankComboBox.TabIndex = 1;
            this.BankComboBox.SelectedIndexChanged += new System.EventHandler(this.BankComboBox_SelectedIndexChanged);
            // 
            // BankAccountComboBox
            // 
            this.BankAccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BankAccountComboBox.FormattingEnabled = true;
            this.BankAccountComboBox.Location = new System.Drawing.Point(12, 81);
            this.BankAccountComboBox.Name = "BankAccountComboBox";
            this.BankAccountComboBox.Size = new System.Drawing.Size(307, 25);
            this.BankAccountComboBox.TabIndex = 3;
            // 
            // BankAccountLabel
            // 
            this.BankAccountLabel.AutoSize = true;
            this.BankAccountLabel.Location = new System.Drawing.Point(12, 61);
            this.BankAccountLabel.Name = "BankAccountLabel";
            this.BankAccountLabel.Size = new System.Drawing.Size(85, 17);
            this.BankAccountLabel.TabIndex = 2;
            this.BankAccountLabel.Text = "Bank Account";
            // 
            // ChequeNumberLabel
            // 
            this.ChequeNumberLabel.AutoSize = true;
            this.ChequeNumberLabel.Location = new System.Drawing.Point(12, 109);
            this.ChequeNumberLabel.Name = "ChequeNumberLabel";
            this.ChequeNumberLabel.Size = new System.Drawing.Size(77, 17);
            this.ChequeNumberLabel.TabIndex = 4;
            this.ChequeNumberLabel.Text = "Cheque No.";
            // 
            // ChequeNumberTextBox
            // 
            this.ChequeNumberTextBox.Location = new System.Drawing.Point(12, 129);
            this.ChequeNumberTextBox.Name = "ChequeNumberTextBox";
            this.ChequeNumberTextBox.Size = new System.Drawing.Size(307, 25);
            this.ChequeNumberTextBox.TabIndex = 5;
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Location = new System.Drawing.Point(12, 177);
            this.RemarksTextBox.Multiline = true;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(307, 75);
            this.RemarksTextBox.TabIndex = 7;
            // 
            // RemarksLabel
            // 
            this.RemarksLabel.AutoSize = true;
            this.RemarksLabel.Location = new System.Drawing.Point(12, 157);
            this.RemarksLabel.Name = "RemarksLabel";
            this.RemarksLabel.Size = new System.Drawing.Size(58, 17);
            this.RemarksLabel.TabIndex = 6;
            this.RemarksLabel.Text = "Remarks";
            // 
            // CancelChequeButton
            // 
            this.CancelChequeButton.BackColor = System.Drawing.Color.Red;
            this.CancelChequeButton.FlatAppearance.BorderSize = 0;
            this.CancelChequeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelChequeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelChequeButton.ForeColor = System.Drawing.Color.White;
            this.CancelChequeButton.Location = new System.Drawing.Point(93, 265);
            this.CancelChequeButton.Name = "CancelChequeButton";
            this.CancelChequeButton.Size = new System.Drawing.Size(125, 35);
            this.CancelChequeButton.TabIndex = 8;
            this.CancelChequeButton.Text = "Cancel Cheque";
            this.CancelChequeButton.UseVisualStyleBackColor = false;
            this.CancelChequeButton.Click += new System.EventHandler(this.CancelChequeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(224, 265);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 35);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ChequeCancellationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 312);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CancelChequeButton);
            this.Controls.Add(this.RemarksTextBox);
            this.Controls.Add(this.RemarksLabel);
            this.Controls.Add(this.ChequeNumberTextBox);
            this.Controls.Add(this.ChequeNumberLabel);
            this.Controls.Add(this.BankAccountComboBox);
            this.Controls.Add(this.BankAccountLabel);
            this.Controls.Add(this.BankComboBox);
            this.Controls.Add(this.BankLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChequeCancellationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Cheques";
            this.Load += new System.EventHandler(this.ChequeCancellationDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.Label BankAccountLabel;
        private System.Windows.Forms.Label ChequeNumberLabel;
        private System.Windows.Forms.Button CancelChequeButton;
        private System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.ComboBox BankComboBox;
        public System.Windows.Forms.ComboBox BankAccountComboBox;
        public System.Windows.Forms.TextBox ChequeNumberTextBox;
        public System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.Label RemarksLabel;
    }
}