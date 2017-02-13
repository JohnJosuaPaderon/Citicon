namespace Citicon.Payables
{
    partial class ChequeNumberRangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequeNumberRangeForm));
            this.lblBank = new System.Windows.Forms.Label();
            this.cmbxBank = new System.Windows.Forms.ComboBox();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.cmbxBankAccount = new System.Windows.Forms.ComboBox();
            this.nudRangeStart = new System.Windows.Forms.NumericUpDown();
            this.lblRangeStart = new System.Windows.Forms.Label();
            this.lblRangeEnd = new System.Windows.Forms.Label();
            this.nudRangeEnd = new System.Windows.Forms.NumericUpDown();
            this.btnSaveRange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(12, 15);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(44, 21);
            this.lblBank.TabIndex = 0;
            this.lblBank.Text = "Bank";
            // 
            // cmbxBank
            // 
            this.cmbxBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBank.FormattingEnabled = true;
            this.cmbxBank.Location = new System.Drawing.Point(122, 12);
            this.cmbxBank.Name = "cmbxBank";
            this.cmbxBank.Size = new System.Drawing.Size(341, 29);
            this.cmbxBank.TabIndex = 1;
            this.cmbxBank.SelectedIndexChanged += new System.EventHandler(this.cmbxBank_SelectedIndexChanged);
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Location = new System.Drawing.Point(12, 50);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(104, 21);
            this.lblBankAccount.TabIndex = 2;
            this.lblBankAccount.Text = "Bank Account";
            // 
            // cmbxBankAccount
            // 
            this.cmbxBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBankAccount.FormattingEnabled = true;
            this.cmbxBankAccount.Location = new System.Drawing.Point(122, 47);
            this.cmbxBankAccount.Name = "cmbxBankAccount";
            this.cmbxBankAccount.Size = new System.Drawing.Size(341, 29);
            this.cmbxBankAccount.TabIndex = 3;
            // 
            // nudRangeStart
            // 
            this.nudRangeStart.Location = new System.Drawing.Point(16, 119);
            this.nudRangeStart.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudRangeStart.Name = "nudRangeStart";
            this.nudRangeStart.Size = new System.Drawing.Size(221, 29);
            this.nudRangeStart.TabIndex = 4;
            // 
            // lblRangeStart
            // 
            this.lblRangeStart.AutoSize = true;
            this.lblRangeStart.Location = new System.Drawing.Point(12, 95);
            this.lblRangeStart.Name = "lblRangeStart";
            this.lblRangeStart.Size = new System.Drawing.Size(42, 21);
            this.lblRangeStart.TabIndex = 5;
            this.lblRangeStart.Text = "Start";
            // 
            // lblRangeEnd
            // 
            this.lblRangeEnd.AutoSize = true;
            this.lblRangeEnd.Location = new System.Drawing.Point(238, 95);
            this.lblRangeEnd.Name = "lblRangeEnd";
            this.lblRangeEnd.Size = new System.Drawing.Size(36, 21);
            this.lblRangeEnd.TabIndex = 7;
            this.lblRangeEnd.Text = "End";
            // 
            // nudRangeEnd
            // 
            this.nudRangeEnd.Location = new System.Drawing.Point(242, 119);
            this.nudRangeEnd.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudRangeEnd.Name = "nudRangeEnd";
            this.nudRangeEnd.Size = new System.Drawing.Size(221, 29);
            this.nudRangeEnd.TabIndex = 6;
            // 
            // btnSaveRange
            // 
            this.btnSaveRange.BackColor = System.Drawing.Color.Red;
            this.btnSaveRange.FlatAppearance.BorderSize = 0;
            this.btnSaveRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRange.ForeColor = System.Drawing.Color.White;
            this.btnSaveRange.Location = new System.Drawing.Point(232, 154);
            this.btnSaveRange.Name = "btnSaveRange";
            this.btnSaveRange.Size = new System.Drawing.Size(125, 50);
            this.btnSaveRange.TabIndex = 8;
            this.btnSaveRange.Text = "Save Range";
            this.btnSaveRange.UseVisualStyleBackColor = false;
            this.btnSaveRange.Click += new System.EventHandler(this.btnSaveRange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(363, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChequeNumberRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 220);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveRange);
            this.Controls.Add(this.lblRangeEnd);
            this.Controls.Add(this.nudRangeEnd);
            this.Controls.Add(this.lblRangeStart);
            this.Controls.Add(this.nudRangeStart);
            this.Controls.Add(this.cmbxBankAccount);
            this.Controls.Add(this.lblBankAccount);
            this.Controls.Add(this.cmbxBank);
            this.Controls.Add(this.lblBank);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ChequeNumberRangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheque No. Range Manager";
            this.Load += new System.EventHandler(this.ChequeNumberRangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.ComboBox cmbxBank;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.ComboBox cmbxBankAccount;
        private System.Windows.Forms.NumericUpDown nudRangeStart;
        private System.Windows.Forms.Label lblRangeStart;
        private System.Windows.Forms.Label lblRangeEnd;
        private System.Windows.Forms.NumericUpDown nudRangeEnd;
        private System.Windows.Forms.Button btnSaveRange;
        private System.Windows.Forms.Button btnCancel;
    }
}