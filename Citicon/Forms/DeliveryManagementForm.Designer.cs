namespace Citicon.Forms
{
    partial class DeliveryManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryManagementForm));
            this.DeliveryManagement = new Citicon.Forms.Controls.DeliveryManagement();
            this.SuspendLayout();
            // 
            // DeliveryManagement
            // 
            this.DeliveryManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryManagement.BackColor = System.Drawing.Color.White;
            this.DeliveryManagement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryManagement.ForeColor = System.Drawing.Color.Red;
            this.DeliveryManagement.Location = new System.Drawing.Point(12, 13);
            this.DeliveryManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeliveryManagement.Name = "DeliveryManagement";
            this.DeliveryManagement.Size = new System.Drawing.Size(876, 504);
            this.DeliveryManagement.TabIndex = 0;
            this.DeliveryManagement.CloseDialogRequested += new System.EventHandler(this.DeliveryManagement_CloseDialogRequested);
            // 
            // DeliveryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 530);
            this.Controls.Add(this.DeliveryManagement);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeliveryManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Design Delivery";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DeliveryManagement DeliveryManagement;
    }
}