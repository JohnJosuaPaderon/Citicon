namespace Citicon.Forms
{
    partial class WeeklyCutOffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeeklyCutOffForm));
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToCheckBox = new System.Windows.Forms.CheckBox();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CancelFormButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(13, 13);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(38, 17);
            this.FromLabel.TabIndex = 0;
            this.FromLabel.Text = "From";
            // 
            // ToCheckBox
            // 
            this.ToCheckBox.AutoSize = true;
            this.ToCheckBox.Location = new System.Drawing.Point(16, 70);
            this.ToCheckBox.Name = "ToCheckBox";
            this.ToCheckBox.Size = new System.Drawing.Size(41, 21);
            this.ToCheckBox.TabIndex = 1;
            this.ToCheckBox.Text = "To";
            this.ToCheckBox.UseVisualStyleBackColor = true;
            this.ToCheckBox.CheckedChanged += new System.EventHandler(this.ToLabel_CheckedChanged);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDateTimePicker.Location = new System.Drawing.Point(16, 33);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(295, 25);
            this.FromDateTimePicker.TabIndex = 2;
            this.FromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.ToDateTimePicker.Enabled = false;
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDateTimePicker.Location = new System.Drawing.Point(16, 97);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(295, 25);
            this.ToDateTimePicker.TabIndex = 3;
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelFormButton.BackColor = System.Drawing.Color.White;
            this.CancelFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelFormButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelFormButton.ForeColor = System.Drawing.Color.Red;
            this.CancelFormButton.Location = new System.Drawing.Point(211, 130);
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(100, 40);
            this.CancelFormButton.TabIndex = 16;
            this.CancelFormButton.Text = "Cancel";
            this.CancelFormButton.UseVisualStyleBackColor = false;
            this.CancelFormButton.Click += new System.EventHandler(this.CancelFormButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.Red;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(105, 130);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(100, 40);
            this.DoneButton.TabIndex = 15;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // WeeklyCutOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 182);
            this.Controls.Add(this.CancelFormButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.ToCheckBox);
            this.Controls.Add(this.FromLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WeeklyCutOffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weekly Cut-Off";
            this.Load += new System.EventHandler(this.WeeklyCutOffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Button CancelFormButton;
        private System.Windows.Forms.Button DoneButton;
        public System.Windows.Forms.CheckBox ToCheckBox;
        public System.Windows.Forms.DateTimePicker FromDateTimePicker;
        public System.Windows.Forms.DateTimePicker ToDateTimePicker;
    }
}