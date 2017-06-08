namespace Citicon.Forms
{
    partial class DeliveryConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryConfirmationForm));
            this.DeliveryConfirmation = new Citicon.Forms.Controls.DeliveryConfirmationControl();
            this.SuspendLayout();
            // 
            // DeliveryConfirmation
            // 
            this.DeliveryConfirmation.BackColor = System.Drawing.Color.White;
            this.DeliveryConfirmation.CurrentDelivery = null;
            this.DeliveryConfirmation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeliveryConfirmation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryConfirmation.ForeColor = System.Drawing.Color.Red;
            this.DeliveryConfirmation.Location = new System.Drawing.Point(0, 0);
            this.DeliveryConfirmation.Name = "DeliveryConfirmation";
            this.DeliveryConfirmation.Size = new System.Drawing.Size(1241, 823);
            this.DeliveryConfirmation.TabIndex = 0;
            // 
            // DeliveryConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 823);
            this.Controls.Add(this.DeliveryConfirmation);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeliveryConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Confirmation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DeliveryConfirmationControl DeliveryConfirmation;
    }
}