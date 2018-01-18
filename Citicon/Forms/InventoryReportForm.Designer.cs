namespace Citicon.Forms
{
    partial class InventoryReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryReportForm));
            this.NavigationContainerPanel = new System.Windows.Forms.Panel();
            this.IncomingStocksButton = new System.Windows.Forms.Button();
            this.OutgoingStocksButton = new System.Windows.Forms.Button();
            this.NavigationContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationContainerPanel
            // 
            this.NavigationContainerPanel.Controls.Add(this.IncomingStocksButton);
            this.NavigationContainerPanel.Controls.Add(this.OutgoingStocksButton);
            this.NavigationContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationContainerPanel.Name = "NavigationContainerPanel";
            this.NavigationContainerPanel.Size = new System.Drawing.Size(553, 79);
            this.NavigationContainerPanel.TabIndex = 1;
            // 
            // IncomingStocksButton
            // 
            this.IncomingStocksButton.BackColor = System.Drawing.Color.Red;
            this.IncomingStocksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomingStocksButton.ForeColor = System.Drawing.Color.White;
            this.IncomingStocksButton.Location = new System.Drawing.Point(11, 11);
            this.IncomingStocksButton.Margin = new System.Windows.Forms.Padding(2);
            this.IncomingStocksButton.Name = "IncomingStocksButton";
            this.IncomingStocksButton.Size = new System.Drawing.Size(128, 57);
            this.IncomingStocksButton.TabIndex = 15;
            this.IncomingStocksButton.Text = "INCOMING STOCKS";
            this.IncomingStocksButton.UseVisualStyleBackColor = false;
            this.IncomingStocksButton.Click += new System.EventHandler(this.IncomingStocksButton_Click);
            // 
            // OutgoingStocksButton
            // 
            this.OutgoingStocksButton.BackColor = System.Drawing.Color.Red;
            this.OutgoingStocksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutgoingStocksButton.ForeColor = System.Drawing.Color.White;
            this.OutgoingStocksButton.Location = new System.Drawing.Point(141, 11);
            this.OutgoingStocksButton.Margin = new System.Windows.Forms.Padding(2);
            this.OutgoingStocksButton.Name = "OutgoingStocksButton";
            this.OutgoingStocksButton.Size = new System.Drawing.Size(128, 57);
            this.OutgoingStocksButton.TabIndex = 14;
            this.OutgoingStocksButton.Text = "OUTGOING STOCKS";
            this.OutgoingStocksButton.UseVisualStyleBackColor = false;
            this.OutgoingStocksButton.Click += new System.EventHandler(this.OutgoingStocksButton_Click);
            // 
            // InventoryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 341);
            this.Controls.Add(this.NavigationContainerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InventoryReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.NavigationContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationContainerPanel;
        private System.Windows.Forms.Button IncomingStocksButton;
        private System.Windows.Forms.Button OutgoingStocksButton;
    }
}