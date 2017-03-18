namespace Citicon.HumanResourceIntegration.Forms
{
    partial class EmployeeManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementForm));
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lbxSearchSuggest = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(60, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(347, 23);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.TextChanged += new System.EventHandler(this.TbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(42, 15);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // lbxSearchSuggest
            // 
            this.lbxSearchSuggest.FormattingEnabled = true;
            this.lbxSearchSuggest.ItemHeight = 15;
            this.lbxSearchSuggest.Location = new System.Drawing.Point(60, 41);
            this.lbxSearchSuggest.Name = "lbxSearchSuggest";
            this.lbxSearchSuggest.Size = new System.Drawing.Size(347, 4);
            this.lbxSearchSuggest.TabIndex = 2;
            this.lbxSearchSuggest.Visible = false;
            this.lbxSearchSuggest.DoubleClick += new System.EventHandler(this.LbxSearchSuggest_DoubleClick);
            // 
            // EmployeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 301);
            this.Controls.Add(this.lbxSearchSuggest);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListBox lbxSearchSuggest;
    }
}