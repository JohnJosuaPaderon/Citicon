namespace Citicon.Tests.PayrollIntegrationTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSemiMonthlyPayrollForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSemiMonthlyPayrollForm
            // 
            this.btnSemiMonthlyPayrollForm.BackColor = System.Drawing.Color.Red;
            this.btnSemiMonthlyPayrollForm.FlatAppearance.BorderSize = 0;
            this.btnSemiMonthlyPayrollForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemiMonthlyPayrollForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemiMonthlyPayrollForm.ForeColor = System.Drawing.Color.White;
            this.btnSemiMonthlyPayrollForm.Location = new System.Drawing.Point(12, 12);
            this.btnSemiMonthlyPayrollForm.Name = "btnSemiMonthlyPayrollForm";
            this.btnSemiMonthlyPayrollForm.Size = new System.Drawing.Size(200, 50);
            this.btnSemiMonthlyPayrollForm.TabIndex = 1;
            this.btnSemiMonthlyPayrollForm.Text = "Semi-Monthly Payroll Form";
            this.btnSemiMonthlyPayrollForm.UseVisualStyleBackColor = false;
            this.btnSemiMonthlyPayrollForm.Click += new System.EventHandler(this.btnSemiMonthlyPayrollForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 301);
            this.Controls.Add(this.btnSemiMonthlyPayrollForm);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tests Laucher for Payroll Integration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSemiMonthlyPayrollForm;
    }
}

