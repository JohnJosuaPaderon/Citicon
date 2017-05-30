﻿namespace Citicon.BillingApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PurchaseOrderButton = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.SalesInvoiceButton = new System.Windows.Forms.Button();
            this.BillingButton = new System.Windows.Forms.Button();
            this.UserSettingsButton = new System.Windows.Forms.Button();
            this.TallySheetButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.TallySheetButton);
            this.panel1.Controls.Add(this.UserSettingsButton);
            this.panel1.Controls.Add(this.PurchaseOrderButton);
            this.panel1.Controls.Add(this.PaymentButton);
            this.panel1.Controls.Add(this.SalesInvoiceButton);
            this.panel1.Controls.Add(this.BillingButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(1472, 60);
            this.panel1.TabIndex = 1;
            // 
            // PurchaseOrderButton
            // 
            this.PurchaseOrderButton.BackColor = System.Drawing.Color.Red;
            this.PurchaseOrderButton.FlatAppearance.BorderSize = 0;
            this.PurchaseOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseOrderButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseOrderButton.ForeColor = System.Drawing.Color.White;
            this.PurchaseOrderButton.Location = new System.Drawing.Point(364, 5);
            this.PurchaseOrderButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PurchaseOrderButton.Name = "PurchaseOrderButton";
            this.PurchaseOrderButton.Size = new System.Drawing.Size(150, 50);
            this.PurchaseOrderButton.TabIndex = 3;
            this.PurchaseOrderButton.Text = "PURCHASE ORDER";
            this.PurchaseOrderButton.UseVisualStyleBackColor = false;
            this.PurchaseOrderButton.Click += new System.EventHandler(this.PurchaseOrderButton_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.BackColor = System.Drawing.Color.Red;
            this.PaymentButton.FlatAppearance.BorderSize = 0;
            this.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton.ForeColor = System.Drawing.Color.White;
            this.PaymentButton.Location = new System.Drawing.Point(254, 5);
            this.PaymentButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(100, 50);
            this.PaymentButton.TabIndex = 2;
            this.PaymentButton.Text = "PAYMENT";
            this.PaymentButton.UseVisualStyleBackColor = false;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // SalesInvoiceButton
            // 
            this.SalesInvoiceButton.BackColor = System.Drawing.Color.Red;
            this.SalesInvoiceButton.FlatAppearance.BorderSize = 0;
            this.SalesInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesInvoiceButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesInvoiceButton.ForeColor = System.Drawing.Color.White;
            this.SalesInvoiceButton.Location = new System.Drawing.Point(119, 5);
            this.SalesInvoiceButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SalesInvoiceButton.Name = "SalesInvoiceButton";
            this.SalesInvoiceButton.Size = new System.Drawing.Size(125, 50);
            this.SalesInvoiceButton.TabIndex = 1;
            this.SalesInvoiceButton.Text = "SALES INVOICE";
            this.SalesInvoiceButton.UseVisualStyleBackColor = false;
            this.SalesInvoiceButton.Click += new System.EventHandler(this.SalesInvoiceButton_Click);
            // 
            // BillingButton
            // 
            this.BillingButton.BackColor = System.Drawing.Color.Red;
            this.BillingButton.FlatAppearance.BorderSize = 0;
            this.BillingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillingButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingButton.ForeColor = System.Drawing.Color.White;
            this.BillingButton.Location = new System.Drawing.Point(9, 5);
            this.BillingButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BillingButton.Name = "BillingButton";
            this.BillingButton.Size = new System.Drawing.Size(100, 50);
            this.BillingButton.TabIndex = 0;
            this.BillingButton.Text = "BILLING";
            this.BillingButton.UseVisualStyleBackColor = false;
            this.BillingButton.Click += new System.EventHandler(this.BillingButton_Click);
            // 
            // UserSettingsButton
            // 
            this.UserSettingsButton.BackColor = System.Drawing.Color.Red;
            this.UserSettingsButton.FlatAppearance.BorderSize = 0;
            this.UserSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSettingsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSettingsButton.ForeColor = System.Drawing.Color.White;
            this.UserSettingsButton.Location = new System.Drawing.Point(659, 5);
            this.UserSettingsButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserSettingsButton.Name = "UserSettingsButton";
            this.UserSettingsButton.Size = new System.Drawing.Size(125, 50);
            this.UserSettingsButton.TabIndex = 4;
            this.UserSettingsButton.Text = "USER SETTINGS";
            this.UserSettingsButton.UseVisualStyleBackColor = false;
            this.UserSettingsButton.Click += new System.EventHandler(this.UserSettingsButton_Click);
            // 
            // TallySheetButton
            // 
            this.TallySheetButton.BackColor = System.Drawing.Color.Red;
            this.TallySheetButton.FlatAppearance.BorderSize = 0;
            this.TallySheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TallySheetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TallySheetButton.ForeColor = System.Drawing.Color.White;
            this.TallySheetButton.Location = new System.Drawing.Point(524, 5);
            this.TallySheetButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TallySheetButton.Name = "TallySheetButton";
            this.TallySheetButton.Size = new System.Drawing.Size(125, 50);
            this.TallySheetButton.TabIndex = 5;
            this.TallySheetButton.Text = "TALLY SHEET";
            this.TallySheetButton.UseVisualStyleBackColor = false;
            this.TallySheetButton.Click += new System.EventHandler(this.TallySheetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 729);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PurchaseOrderButton;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button SalesInvoiceButton;
        private System.Windows.Forms.Button BillingButton;
        private System.Windows.Forms.Button UserSettingsButton;
        private System.Windows.Forms.Button TallySheetButton;
    }
}

