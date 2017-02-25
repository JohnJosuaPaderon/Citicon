namespace Citicon.Tests.HumanResourceIntegrationTest
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
            this.btnEmployeeManagementForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployeeManagementForm
            // 
            this.btnEmployeeManagementForm.BackColor = System.Drawing.Color.Red;
            this.btnEmployeeManagementForm.FlatAppearance.BorderSize = 0;
            this.btnEmployeeManagementForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManagementForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManagementForm.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeManagementForm.Location = new System.Drawing.Point(12, 12);
            this.btnEmployeeManagementForm.Name = "btnEmployeeManagementForm";
            this.btnEmployeeManagementForm.Size = new System.Drawing.Size(200, 50);
            this.btnEmployeeManagementForm.TabIndex = 0;
            this.btnEmployeeManagementForm.Text = "Employee Management Form";
            this.btnEmployeeManagementForm.UseVisualStyleBackColor = false;
            this.btnEmployeeManagementForm.Click += new System.EventHandler(this.btnEmployeeManagementForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 301);
            this.Controls.Add(this.btnEmployeeManagementForm);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tests Launcher for Human Resource Integration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeManagementForm;
    }
}

