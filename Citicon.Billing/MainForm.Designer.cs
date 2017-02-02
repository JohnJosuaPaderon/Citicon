namespace Citicon.Billing
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
            this.btnClients = new System.Windows.Forms.Button();
            this.tblContent = new System.Windows.Forms.TableLayoutPanel();
            this.Header = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.lblUserDisplay = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.HeaderText = new System.Windows.Forms.Label();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnDesigns = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.Location = new System.Drawing.Point(12, 106);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(200, 85);
            this.btnClients.TabIndex = 5;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // tblContent
            // 
            this.tblContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblContent.ColumnCount = 2;
            this.tblContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblContent.Location = new System.Drawing.Point(12, 197);
            this.tblContent.Name = "tblContent";
            this.tblContent.RowCount = 1;
            this.tblContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblContent.Size = new System.Drawing.Size(1786, 601);
            this.tblContent.TabIndex = 6;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.UserPanel);
            this.Header.Controls.Add(this.HeaderText);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1810, 100);
            this.Header.TabIndex = 7;
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.lblUserDisplay);
            this.UserPanel.Controls.Add(this.btnLogOut);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserPanel.Location = new System.Drawing.Point(1410, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(400, 100);
            this.UserPanel.TabIndex = 2;
            // 
            // lblUserDisplay
            // 
            this.lblUserDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserDisplay.Location = new System.Drawing.Point(6, 9);
            this.lblUserDisplay.Name = "lblUserDisplay";
            this.lblUserDisplay.Size = new System.Drawing.Size(382, 45);
            this.lblUserDisplay.TabIndex = 4;
            this.lblUserDisplay.Text = "User\'s Name";
            this.lblUserDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserDisplay.Click += new System.EventHandler(this.lblUserDisplay_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(263, 57);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(125, 40);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log-out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // HeaderText
            // 
            this.HeaderText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderText.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(0, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(1810, 100);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Billing";
            this.HeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeaderText.Click += new System.EventHandler(this.HeaderText_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProjects.FlatAppearance.BorderSize = 0;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.ForeColor = System.Drawing.Color.White;
            this.btnProjects.Location = new System.Drawing.Point(218, 106);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(200, 85);
            this.btnProjects.TabIndex = 8;
            this.btnProjects.Text = "Projects";
            this.btnProjects.UseVisualStyleBackColor = false;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnDesigns
            // 
            this.btnDesigns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDesigns.FlatAppearance.BorderSize = 0;
            this.btnDesigns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesigns.ForeColor = System.Drawing.Color.White;
            this.btnDesigns.Location = new System.Drawing.Point(424, 106);
            this.btnDesigns.Name = "btnDesigns";
            this.btnDesigns.Size = new System.Drawing.Size(200, 85);
            this.btnDesigns.TabIndex = 9;
            this.btnDesigns.Text = "Designs";
            this.btnDesigns.UseVisualStyleBackColor = false;
            this.btnDesigns.Click += new System.EventHandler(this.btnDesigns_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1810, 810);
            this.Controls.Add(this.btnDesigns);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.tblContent);
            this.Controls.Add(this.btnClients);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Header.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.TableLayoutPanel tblContent;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Label lblUserDisplay;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnDesigns;
    }
}