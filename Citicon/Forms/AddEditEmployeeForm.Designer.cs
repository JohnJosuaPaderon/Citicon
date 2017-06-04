namespace Citicon.Forms
{
    partial class AddEditEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditEmployeeForm));
            this.addEditEmployeeControl1 = new Citicon.Forms.Controls.AddEditEmployeeControl();
            this.SuspendLayout();
            // 
            // addEditEmployeeControl1
            // 
            this.addEditEmployeeControl1.BackColor = System.Drawing.Color.White;
            this.addEditEmployeeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEditEmployeeControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditEmployeeControl1.ForeColor = System.Drawing.Color.Red;
            this.addEditEmployeeControl1.Location = new System.Drawing.Point(0, 0);
            this.addEditEmployeeControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addEditEmployeeControl1.Name = "addEditEmployeeControl1";
            this.addEditEmployeeControl1.Size = new System.Drawing.Size(660, 450);
            this.addEditEmployeeControl1.TabIndex = 0;
            // 
            // AddEditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.addEditEmployeeControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Employee";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.AddEditEmployeeControl addEditEmployeeControl1;
    }
}