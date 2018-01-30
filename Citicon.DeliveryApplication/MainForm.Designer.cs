namespace Citicon.DeliveryApplication
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
            this.UserSettingsButton = new System.Windows.Forms.Button();
            this.EngineerButton = new System.Windows.Forms.Button();
            this.TallySheetButton = new System.Windows.Forms.Button();
            this.DeliveryButton = new System.Windows.Forms.Button();
            this.DeliveryCancellationButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.DeliveryCancellationButton);
            this.panel1.Controls.Add(this.UserSettingsButton);
            this.panel1.Controls.Add(this.EngineerButton);
            this.panel1.Controls.Add(this.TallySheetButton);
            this.panel1.Controls.Add(this.DeliveryButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(985, 60);
            this.panel1.TabIndex = 0;
            // 
            // UserSettingsButton
            // 
            this.UserSettingsButton.BackColor = System.Drawing.Color.Red;
            this.UserSettingsButton.FlatAppearance.BorderSize = 0;
            this.UserSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSettingsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSettingsButton.ForeColor = System.Drawing.Color.White;
            this.UserSettingsButton.Location = new System.Drawing.Point(549, 5);
            this.UserSettingsButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserSettingsButton.Name = "UserSettingsButton";
            this.UserSettingsButton.Size = new System.Drawing.Size(125, 50);
            this.UserSettingsButton.TabIndex = 5;
            this.UserSettingsButton.Text = "USER SETTINGS";
            this.UserSettingsButton.UseVisualStyleBackColor = false;
            this.UserSettingsButton.Click += new System.EventHandler(this.UserSettingsButton_Click);
            // 
            // EngineerButton
            // 
            this.EngineerButton.BackColor = System.Drawing.Color.Red;
            this.EngineerButton.FlatAppearance.BorderSize = 0;
            this.EngineerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EngineerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineerButton.ForeColor = System.Drawing.Color.White;
            this.EngineerButton.Location = new System.Drawing.Point(279, 5);
            this.EngineerButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EngineerButton.Name = "EngineerButton";
            this.EngineerButton.Size = new System.Drawing.Size(125, 50);
            this.EngineerButton.TabIndex = 2;
            this.EngineerButton.Text = "CREATE DESIGN";
            this.EngineerButton.UseVisualStyleBackColor = false;
            this.EngineerButton.Click += new System.EventHandler(this.EngineerButton_Click);
            // 
            // TallySheetButton
            // 
            this.TallySheetButton.BackColor = System.Drawing.Color.Red;
            this.TallySheetButton.FlatAppearance.BorderSize = 0;
            this.TallySheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TallySheetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TallySheetButton.ForeColor = System.Drawing.Color.White;
            this.TallySheetButton.Location = new System.Drawing.Point(144, 5);
            this.TallySheetButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TallySheetButton.Name = "TallySheetButton";
            this.TallySheetButton.Size = new System.Drawing.Size(125, 50);
            this.TallySheetButton.TabIndex = 1;
            this.TallySheetButton.Text = "TALLY SHEET";
            this.TallySheetButton.UseVisualStyleBackColor = false;
            this.TallySheetButton.Click += new System.EventHandler(this.TallySheetButton_Click);
            // 
            // DeliveryButton
            // 
            this.DeliveryButton.BackColor = System.Drawing.Color.Red;
            this.DeliveryButton.FlatAppearance.BorderSize = 0;
            this.DeliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryButton.ForeColor = System.Drawing.Color.White;
            this.DeliveryButton.Location = new System.Drawing.Point(9, 5);
            this.DeliveryButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DeliveryButton.Name = "DeliveryButton";
            this.DeliveryButton.Size = new System.Drawing.Size(125, 50);
            this.DeliveryButton.TabIndex = 0;
            this.DeliveryButton.Text = "DELIVERY";
            this.DeliveryButton.UseVisualStyleBackColor = false;
            this.DeliveryButton.Click += new System.EventHandler(this.DeliveryButton_Click);
            // 
            // DeliveryCancellationButton
            // 
            this.DeliveryCancellationButton.BackColor = System.Drawing.Color.Red;
            this.DeliveryCancellationButton.FlatAppearance.BorderSize = 0;
            this.DeliveryCancellationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryCancellationButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryCancellationButton.ForeColor = System.Drawing.Color.White;
            this.DeliveryCancellationButton.Location = new System.Drawing.Point(414, 5);
            this.DeliveryCancellationButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DeliveryCancellationButton.Name = "DeliveryCancellationButton";
            this.DeliveryCancellationButton.Size = new System.Drawing.Size(125, 50);
            this.DeliveryCancellationButton.TabIndex = 6;
            this.DeliveryCancellationButton.Text = "DELIVERY CANCELLATION";
            this.DeliveryCancellationButton.UseVisualStyleBackColor = false;
            this.DeliveryCancellationButton.Click += new System.EventHandler(this.DeliveryCancellationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 659);
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeliveryButton;
        private System.Windows.Forms.Button TallySheetButton;
        private System.Windows.Forms.Button EngineerButton;
        private System.Windows.Forms.Button UserSettingsButton;
        private System.Windows.Forms.Button DeliveryCancellationButton;
    }
}