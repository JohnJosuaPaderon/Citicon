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
            this.btnDeliveryForm = new System.Windows.Forms.Button();
            this.btnPurchaseOrderManagementForm = new System.Windows.Forms.Button();
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
            this.btnDeliveryScheduler.Size = new System.Drawing.Size(346, 50);
            this.btnDeliveryScheduler.TabIndex = 2;
            this.btnDeliveryScheduler.Text = "Launch Delivery Scheduler Form";
            this.btnDeliveryScheduler.UseVisualStyleBackColor = false;
            this.btnDeliveryScheduler.Click += new System.EventHandler(this.btnDeliveryScheduler_Click);
            // 
            // btnDeliveryForm
            // 
            this.btnDeliveryForm.BackColor = System.Drawing.Color.Red;
            this.btnDeliveryForm.FlatAppearance.BorderSize = 0;
            this.btnDeliveryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveryForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliveryForm.ForeColor = System.Drawing.Color.White;
            this.btnDeliveryForm.Location = new System.Drawing.Point(12, 68);
            this.btnDeliveryForm.Name = "btnDeliveryForm";
            this.btnDeliveryForm.Size = new System.Drawing.Size(346, 50);
            this.btnDeliveryForm.TabIndex = 3;
            this.btnDeliveryForm.Text = "Launch Delivery Form";
            this.btnDeliveryForm.UseVisualStyleBackColor = false;
            this.btnDeliveryForm.Click += new System.EventHandler(this.btnDeliveryForm_Click);
            // 
            // btnPurchaseOrderManagementForm
            // 
            this.btnPurchaseOrderManagementForm.BackColor = System.Drawing.Color.Red;
            this.btnPurchaseOrderManagementForm.FlatAppearance.BorderSize = 0;
            this.btnPurchaseOrderManagementForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseOrderManagementForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOrderManagementForm.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseOrderManagementForm.Location = new System.Drawing.Point(12, 124);
            this.btnPurchaseOrderManagementForm.Name = "btnPurchaseOrderManagementForm";
            this.btnPurchaseOrderManagementForm.Size = new System.Drawing.Size(346, 50);
            this.btnPurchaseOrderManagementForm.TabIndex = 4;
            this.btnPurchaseOrderManagementForm.Text = "Launch Purchase Order Management Form";
            this.btnPurchaseOrderManagementForm.UseVisualStyleBackColor = false;
            this.btnPurchaseOrderManagementForm.Click += new System.EventHandler(this.btnPurchaseOrderManagementForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 481);
            this.Controls.Add(this.btnPurchaseOrderManagementForm);
            this.Controls.Add(this.btnDeliveryForm);
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
        private System.Windows.Forms.Button btnDeliveryForm;
        private System.Windows.Forms.Button btnPurchaseOrderManagementForm;
    }
}

