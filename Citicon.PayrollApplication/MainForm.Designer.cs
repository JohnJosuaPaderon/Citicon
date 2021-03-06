﻿namespace Citicon.PayrollApplication
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
            this.HolidayButton = new System.Windows.Forms.Button();
            this.DriverPayrollButton = new System.Windows.Forms.Button();
            this.SemiMonthlyPayrollButton = new System.Windows.Forms.Button();
            this.TransitMixerButton = new System.Windows.Forms.Button();
            this.RouteButton = new System.Windows.Forms.Button();
            this.DriverTripReportButton = new System.Windows.Forms.Button();
            this.UserSettingsButton = new System.Windows.Forms.Button();
            this.ViewTimeLogsButton = new System.Windows.Forms.Button();
            this.WeeklyPayrollButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.WeeklyPayrollButton);
            this.panel1.Controls.Add(this.HolidayButton);
            this.panel1.Controls.Add(this.DriverPayrollButton);
            this.panel1.Controls.Add(this.SemiMonthlyPayrollButton);
            this.panel1.Controls.Add(this.TransitMixerButton);
            this.panel1.Controls.Add(this.RouteButton);
            this.panel1.Controls.Add(this.DriverTripReportButton);
            this.panel1.Controls.Add(this.UserSettingsButton);
            this.panel1.Controls.Add(this.ViewTimeLogsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(1473, 60);
            this.panel1.TabIndex = 1;
            // 
            // HolidayButton
            // 
            this.HolidayButton.BackColor = System.Drawing.Color.Red;
            this.HolidayButton.FlatAppearance.BorderSize = 0;
            this.HolidayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HolidayButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolidayButton.ForeColor = System.Drawing.Color.White;
            this.HolidayButton.Location = new System.Drawing.Point(950, 5);
            this.HolidayButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.HolidayButton.Name = "HolidayButton";
            this.HolidayButton.Size = new System.Drawing.Size(125, 50);
            this.HolidayButton.TabIndex = 11;
            this.HolidayButton.Text = "HOLIDAYS";
            this.HolidayButton.UseVisualStyleBackColor = false;
            this.HolidayButton.Click += new System.EventHandler(this.HolidayButton_Click);
            // 
            // DriverPayrollButton
            // 
            this.DriverPayrollButton.BackColor = System.Drawing.Color.Red;
            this.DriverPayrollButton.FlatAppearance.BorderSize = 0;
            this.DriverPayrollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverPayrollButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverPayrollButton.ForeColor = System.Drawing.Color.White;
            this.DriverPayrollButton.Location = new System.Drawing.Point(140, 5);
            this.DriverPayrollButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverPayrollButton.Name = "DriverPayrollButton";
            this.DriverPayrollButton.Size = new System.Drawing.Size(125, 50);
            this.DriverPayrollButton.TabIndex = 10;
            this.DriverPayrollButton.Text = "DRIVER PAYROLL";
            this.DriverPayrollButton.UseVisualStyleBackColor = false;
            this.DriverPayrollButton.Click += new System.EventHandler(this.DriverPayrollButton_Click);
            // 
            // SemiMonthlyPayrollButton
            // 
            this.SemiMonthlyPayrollButton.BackColor = System.Drawing.Color.Red;
            this.SemiMonthlyPayrollButton.FlatAppearance.BorderSize = 0;
            this.SemiMonthlyPayrollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SemiMonthlyPayrollButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemiMonthlyPayrollButton.ForeColor = System.Drawing.Color.White;
            this.SemiMonthlyPayrollButton.Location = new System.Drawing.Point(5, 5);
            this.SemiMonthlyPayrollButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SemiMonthlyPayrollButton.Name = "SemiMonthlyPayrollButton";
            this.SemiMonthlyPayrollButton.Size = new System.Drawing.Size(125, 50);
            this.SemiMonthlyPayrollButton.TabIndex = 9;
            this.SemiMonthlyPayrollButton.Text = "SEMI-MONTHLY PAYROLL";
            this.SemiMonthlyPayrollButton.UseVisualStyleBackColor = false;
            this.SemiMonthlyPayrollButton.Click += new System.EventHandler(this.SemiMonthlyPayrollButton_Click);
            // 
            // TransitMixerButton
            // 
            this.TransitMixerButton.BackColor = System.Drawing.Color.Red;
            this.TransitMixerButton.FlatAppearance.BorderSize = 0;
            this.TransitMixerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransitMixerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransitMixerButton.ForeColor = System.Drawing.Color.White;
            this.TransitMixerButton.Location = new System.Drawing.Point(815, 5);
            this.TransitMixerButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TransitMixerButton.Name = "TransitMixerButton";
            this.TransitMixerButton.Size = new System.Drawing.Size(125, 50);
            this.TransitMixerButton.TabIndex = 8;
            this.TransitMixerButton.Text = "TRANSIT MIXERS";
            this.TransitMixerButton.UseVisualStyleBackColor = false;
            this.TransitMixerButton.Click += new System.EventHandler(this.TransitMixerButton_Click);
            // 
            // RouteButton
            // 
            this.RouteButton.BackColor = System.Drawing.Color.Red;
            this.RouteButton.FlatAppearance.BorderSize = 0;
            this.RouteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RouteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteButton.ForeColor = System.Drawing.Color.White;
            this.RouteButton.Location = new System.Drawing.Point(680, 5);
            this.RouteButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RouteButton.Name = "RouteButton";
            this.RouteButton.Size = new System.Drawing.Size(125, 50);
            this.RouteButton.TabIndex = 7;
            this.RouteButton.Text = "ROUTES";
            this.RouteButton.UseVisualStyleBackColor = false;
            this.RouteButton.Click += new System.EventHandler(this.RouteButton_Click);
            // 
            // DriverTripReportButton
            // 
            this.DriverTripReportButton.BackColor = System.Drawing.Color.Red;
            this.DriverTripReportButton.FlatAppearance.BorderSize = 0;
            this.DriverTripReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverTripReportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverTripReportButton.ForeColor = System.Drawing.Color.White;
            this.DriverTripReportButton.Location = new System.Drawing.Point(545, 5);
            this.DriverTripReportButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverTripReportButton.Name = "DriverTripReportButton";
            this.DriverTripReportButton.Size = new System.Drawing.Size(125, 50);
            this.DriverTripReportButton.TabIndex = 6;
            this.DriverTripReportButton.Text = "DRIVER TRIP REPORT";
            this.DriverTripReportButton.UseVisualStyleBackColor = false;
            this.DriverTripReportButton.Click += new System.EventHandler(this.DriverTripReportButton_Click);
            // 
            // UserSettingsButton
            // 
            this.UserSettingsButton.BackColor = System.Drawing.Color.Red;
            this.UserSettingsButton.FlatAppearance.BorderSize = 0;
            this.UserSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSettingsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSettingsButton.ForeColor = System.Drawing.Color.White;
            this.UserSettingsButton.Location = new System.Drawing.Point(1085, 5);
            this.UserSettingsButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserSettingsButton.Name = "UserSettingsButton";
            this.UserSettingsButton.Size = new System.Drawing.Size(125, 50);
            this.UserSettingsButton.TabIndex = 5;
            this.UserSettingsButton.Text = "USER SETTINGS";
            this.UserSettingsButton.UseVisualStyleBackColor = false;
            this.UserSettingsButton.Click += new System.EventHandler(this.UserSettingsButton_Click);
            // 
            // ViewTimeLogsButton
            // 
            this.ViewTimeLogsButton.BackColor = System.Drawing.Color.Red;
            this.ViewTimeLogsButton.FlatAppearance.BorderSize = 0;
            this.ViewTimeLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTimeLogsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTimeLogsButton.ForeColor = System.Drawing.Color.White;
            this.ViewTimeLogsButton.Location = new System.Drawing.Point(410, 5);
            this.ViewTimeLogsButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ViewTimeLogsButton.Name = "ViewTimeLogsButton";
            this.ViewTimeLogsButton.Size = new System.Drawing.Size(125, 50);
            this.ViewTimeLogsButton.TabIndex = 0;
            this.ViewTimeLogsButton.Text = "VIEW TIME LOGS";
            this.ViewTimeLogsButton.UseVisualStyleBackColor = false;
            this.ViewTimeLogsButton.Click += new System.EventHandler(this.ViewTimeLogsButton_Click);
            // 
            // WeeklyPayrollButton
            // 
            this.WeeklyPayrollButton.BackColor = System.Drawing.Color.Red;
            this.WeeklyPayrollButton.FlatAppearance.BorderSize = 0;
            this.WeeklyPayrollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeeklyPayrollButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklyPayrollButton.ForeColor = System.Drawing.Color.White;
            this.WeeklyPayrollButton.Location = new System.Drawing.Point(275, 5);
            this.WeeklyPayrollButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.WeeklyPayrollButton.Name = "WeeklyPayrollButton";
            this.WeeklyPayrollButton.Size = new System.Drawing.Size(125, 50);
            this.WeeklyPayrollButton.TabIndex = 12;
            this.WeeklyPayrollButton.Text = "WEEKLY PAYROLL";
            this.WeeklyPayrollButton.UseVisualStyleBackColor = false;
            this.WeeklyPayrollButton.Click += new System.EventHandler(this.WeeklyPayrollButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1473, 807);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Payroll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UserSettingsButton;
        private System.Windows.Forms.Button ViewTimeLogsButton;
        private System.Windows.Forms.Button DriverTripReportButton;
        private System.Windows.Forms.Button RouteButton;
        private System.Windows.Forms.Button TransitMixerButton;
        private System.Windows.Forms.Button SemiMonthlyPayrollButton;
        private System.Windows.Forms.Button DriverPayrollButton;
        private System.Windows.Forms.Button HolidayButton;
        private System.Windows.Forms.Button WeeklyPayrollButton;
    }
}

