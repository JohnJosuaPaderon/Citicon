namespace Citicon.Tests.ReceivablesIntegrationTest
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
            this.btnDeliveryScheduler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeliveryScheduler
            // 
            this.btnDeliveryScheduler.BackColor = System.Drawing.Color.Red;
            this.btnDeliveryScheduler.FlatAppearance.BorderSize = 0;
            this.btnDeliveryScheduler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveryScheduler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliveryScheduler.ForeColor = System.Drawing.Color.White;
            this.btnDeliveryScheduler.Location = new System.Drawing.Point(12, 12);
            this.btnDeliveryScheduler.Name = "btnDeliveryScheduler";
            this.btnDeliveryScheduler.Size = new System.Drawing.Size(250, 50);
            this.btnDeliveryScheduler.TabIndex = 2;
            this.btnDeliveryScheduler.Text = "Launch Delivery Scheduler Form";
            this.btnDeliveryScheduler.UseVisualStyleBackColor = false;
            this.btnDeliveryScheduler.Click += new System.EventHandler(this.btnDeliveryScheduler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 481);
            this.Controls.Add(this.btnDeliveryScheduler);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receivables Tests";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeliveryScheduler;
    }
}

