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
            this.AddEditEmployeeControl = new Citicon.Forms.Controls.AddEditEmployeeControl();
            this.SuspendLayout();
            // 
            // AddEditEmployeeControl
            // 
            this.AddEditEmployeeControl.BackColor = System.Drawing.Color.White;
            this.AddEditEmployeeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEditEmployeeControl.Employee = null;
            this.AddEditEmployeeControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEditEmployeeControl.ForeColor = System.Drawing.Color.Red;
            this.AddEditEmployeeControl.Location = new System.Drawing.Point(0, 0);
            this.AddEditEmployeeControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddEditEmployeeControl.Mode = Citicon.Forms.Dialogs.DataDialogMode.None;
            this.AddEditEmployeeControl.Name = "AddEditEmployeeControl";
            this.AddEditEmployeeControl.Size = new System.Drawing.Size(778, 641);
            this.AddEditEmployeeControl.TabIndex = 0;
            this.AddEditEmployeeControl.FormCancelRequested += new System.EventHandler(this.AddEditEmployeeControl_FormCancelRequested);
            // 
            // AddEditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 641);
            this.Controls.Add(this.AddEditEmployeeControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Employee";
            this.Load += new System.EventHandler(this.AddEditEmployeeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.AddEditEmployeeControl AddEditEmployeeControl;
    }
}