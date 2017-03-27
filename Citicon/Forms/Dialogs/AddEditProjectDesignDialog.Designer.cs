namespace Citicon.Forms.Dialogs
{
    partial class AddEditProjectDesignDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditProjectDesignDialog));
            this.ProjectDesignDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.CementFactorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PSINumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PricePerCubicMeterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StrengthComboBox = new System.Windows.Forms.ComboBox();
            this.AggregateComboBox = new System.Windows.Forms.ComboBox();
            this.MixTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CementFactorLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.AggregateLabel = new System.Windows.Forms.Label();
            this.PSILabel = new System.Windows.Forms.Label();
            this.MixTypeLabel = new System.Windows.Forms.Label();
            this.PricePerCubicMeterLabel = new System.Windows.Forms.Label();
            this.CancelQuotationButton = new System.Windows.Forms.Button();
            this.SaveQuotationButton = new System.Windows.Forms.Button();
            this.ProjectDesignDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CementFactorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PSINumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricePerCubicMeterNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectDesignDetailsGroupBox
            // 
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.CementFactorNumericUpDown);
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.PSINumericUpDown);
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.PricePerCubicMeterNumericUpDown);
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.StrengthComboBox);
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.AggregateComboBox);
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.MixTypeComboBox);
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.CementFactorLabel);
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.StrengthLabel);
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.AggregateLabel);
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.PSILabel);
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.MixTypeLabel);
            this.ProjectDesignDetailsGroupBox.Controls.Add(this.PricePerCubicMeterLabel);
            this.ProjectDesignDetailsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ProjectDesignDetailsGroupBox.Name = "ProjectDesignDetailsGroupBox";
            this.ProjectDesignDetailsGroupBox.Size = new System.Drawing.Size(360, 319);
            this.ProjectDesignDetailsGroupBox.TabIndex = 0;
            this.ProjectDesignDetailsGroupBox.TabStop = false;
            this.ProjectDesignDetailsGroupBox.Text = "Design Details";
            // 
            // CementFactorNumericUpDown
            // 
            this.CementFactorNumericUpDown.DecimalPlaces = 3;
            this.CementFactorNumericUpDown.Location = new System.Drawing.Point(9, 281);
            this.CementFactorNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CementFactorNumericUpDown.Name = "CementFactorNumericUpDown";
            this.CementFactorNumericUpDown.Size = new System.Drawing.Size(342, 25);
            this.CementFactorNumericUpDown.TabIndex = 5;
            this.CementFactorNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CementFactorNumericUpDown.ThousandsSeparator = true;
            this.CementFactorNumericUpDown.ValueChanged += new System.EventHandler(this.CementFactorNumericUpDown_ValueChanged);
            // 
            // PSINumericUpDown
            // 
            this.PSINumericUpDown.DecimalPlaces = 3;
            this.PSINumericUpDown.Location = new System.Drawing.Point(9, 137);
            this.PSINumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PSINumericUpDown.Name = "PSINumericUpDown";
            this.PSINumericUpDown.Size = new System.Drawing.Size(342, 25);
            this.PSINumericUpDown.TabIndex = 2;
            this.PSINumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PSINumericUpDown.ThousandsSeparator = true;
            this.PSINumericUpDown.ValueChanged += new System.EventHandler(this.PSINumericUpDown_ValueChanged);
            // 
            // PricePerCubicMeterNumericUpDown
            // 
            this.PricePerCubicMeterNumericUpDown.DecimalPlaces = 2;
            this.PricePerCubicMeterNumericUpDown.Location = new System.Drawing.Point(9, 41);
            this.PricePerCubicMeterNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PricePerCubicMeterNumericUpDown.Name = "PricePerCubicMeterNumericUpDown";
            this.PricePerCubicMeterNumericUpDown.Size = new System.Drawing.Size(342, 25);
            this.PricePerCubicMeterNumericUpDown.TabIndex = 0;
            this.PricePerCubicMeterNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PricePerCubicMeterNumericUpDown.ThousandsSeparator = true;
            this.PricePerCubicMeterNumericUpDown.ValueChanged += new System.EventHandler(this.PricePerCubicMeterNumericUpDown_ValueChanged);
            // 
            // StrengthComboBox
            // 
            this.StrengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StrengthComboBox.FormattingEnabled = true;
            this.StrengthComboBox.Location = new System.Drawing.Point(9, 233);
            this.StrengthComboBox.Name = "StrengthComboBox";
            this.StrengthComboBox.Size = new System.Drawing.Size(342, 25);
            this.StrengthComboBox.TabIndex = 4;
            this.StrengthComboBox.SelectedIndexChanged += new System.EventHandler(this.StrengthComboBox_SelectedIndexChanged);
            // 
            // AggregateComboBox
            // 
            this.AggregateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AggregateComboBox.FormattingEnabled = true;
            this.AggregateComboBox.Location = new System.Drawing.Point(9, 185);
            this.AggregateComboBox.Name = "AggregateComboBox";
            this.AggregateComboBox.Size = new System.Drawing.Size(342, 25);
            this.AggregateComboBox.TabIndex = 3;
            this.AggregateComboBox.SelectedIndexChanged += new System.EventHandler(this.AggregateComboBox_SelectedIndexChanged);
            // 
            // MixTypeComboBox
            // 
            this.MixTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MixTypeComboBox.FormattingEnabled = true;
            this.MixTypeComboBox.Location = new System.Drawing.Point(9, 89);
            this.MixTypeComboBox.Name = "MixTypeComboBox";
            this.MixTypeComboBox.Size = new System.Drawing.Size(342, 25);
            this.MixTypeComboBox.TabIndex = 1;
            this.MixTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.MixTypeComboBox_SelectedIndexChanged);
            // 
            // CementFactorLabel
            // 
            this.CementFactorLabel.AutoSize = true;
            this.CementFactorLabel.Location = new System.Drawing.Point(6, 261);
            this.CementFactorLabel.Name = "CementFactorLabel";
            this.CementFactorLabel.Size = new System.Drawing.Size(92, 17);
            this.CementFactorLabel.TabIndex = 10;
            this.CementFactorLabel.Text = "Cement Factor";
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(6, 213);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(57, 17);
            this.StrengthLabel.TabIndex = 8;
            this.StrengthLabel.Text = "Strength";
            // 
            // AggregateLabel
            // 
            this.AggregateLabel.AutoSize = true;
            this.AggregateLabel.Location = new System.Drawing.Point(6, 165);
            this.AggregateLabel.Name = "AggregateLabel";
            this.AggregateLabel.Size = new System.Drawing.Size(70, 17);
            this.AggregateLabel.TabIndex = 6;
            this.AggregateLabel.Text = "Aggregate";
            // 
            // PSILabel
            // 
            this.PSILabel.AutoSize = true;
            this.PSILabel.Location = new System.Drawing.Point(6, 117);
            this.PSILabel.Name = "PSILabel";
            this.PSILabel.Size = new System.Drawing.Size(25, 17);
            this.PSILabel.TabIndex = 4;
            this.PSILabel.Text = "PSI";
            // 
            // MixTypeLabel
            // 
            this.MixTypeLabel.AutoSize = true;
            this.MixTypeLabel.Location = new System.Drawing.Point(6, 69);
            this.MixTypeLabel.Name = "MixTypeLabel";
            this.MixTypeLabel.Size = new System.Drawing.Size(60, 17);
            this.MixTypeLabel.TabIndex = 2;
            this.MixTypeLabel.Text = "Mix Type";
            // 
            // PricePerCubicMeterLabel
            // 
            this.PricePerCubicMeterLabel.AutoSize = true;
            this.PricePerCubicMeterLabel.Location = new System.Drawing.Point(6, 21);
            this.PricePerCubicMeterLabel.Name = "PricePerCubicMeterLabel";
            this.PricePerCubicMeterLabel.Size = new System.Drawing.Size(74, 17);
            this.PricePerCubicMeterLabel.TabIndex = 0;
            this.PricePerCubicMeterLabel.Text = "Price/Cu.M.";
            // 
            // CancelQuotationButton
            // 
            this.CancelQuotationButton.BackColor = System.Drawing.Color.Red;
            this.CancelQuotationButton.FlatAppearance.BorderSize = 0;
            this.CancelQuotationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelQuotationButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelQuotationButton.ForeColor = System.Drawing.Color.White;
            this.CancelQuotationButton.Location = new System.Drawing.Point(272, 337);
            this.CancelQuotationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelQuotationButton.Name = "CancelQuotationButton";
            this.CancelQuotationButton.Size = new System.Drawing.Size(100, 35);
            this.CancelQuotationButton.TabIndex = 2;
            this.CancelQuotationButton.Text = "CANCEL";
            this.CancelQuotationButton.UseVisualStyleBackColor = false;
            this.CancelQuotationButton.Click += new System.EventHandler(this.CancelQuotationButton_Click);
            // 
            // SaveQuotationButton
            // 
            this.SaveQuotationButton.BackColor = System.Drawing.Color.Red;
            this.SaveQuotationButton.FlatAppearance.BorderSize = 0;
            this.SaveQuotationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveQuotationButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveQuotationButton.ForeColor = System.Drawing.Color.White;
            this.SaveQuotationButton.Location = new System.Drawing.Point(164, 337);
            this.SaveQuotationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveQuotationButton.Name = "SaveQuotationButton";
            this.SaveQuotationButton.Size = new System.Drawing.Size(100, 35);
            this.SaveQuotationButton.TabIndex = 1;
            this.SaveQuotationButton.Text = "SAVE";
            this.SaveQuotationButton.UseVisualStyleBackColor = false;
            this.SaveQuotationButton.Click += new System.EventHandler(this.SaveQuotationButton_Click);
            // 
            // AddEditProjectDesignDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 384);
            this.Controls.Add(this.CancelQuotationButton);
            this.Controls.Add(this.SaveQuotationButton);
            this.Controls.Add(this.ProjectDesignDetailsGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditProjectDesignDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit Project Design";
            this.Load += new System.EventHandler(this.AddEditProjectDesignDialog_Load);
            this.ProjectDesignDetailsGroupBox.ResumeLayout(false);
            this.ProjectDesignDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CementFactorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PSINumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricePerCubicMeterNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProjectDesignDetailsGroupBox;
        private System.Windows.Forms.Label CementFactorLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label AggregateLabel;
        private System.Windows.Forms.Label PSILabel;
        private System.Windows.Forms.Label MixTypeLabel;
        private System.Windows.Forms.Label PricePerCubicMeterLabel;
        private System.Windows.Forms.Button CancelQuotationButton;
        private System.Windows.Forms.Button SaveQuotationButton;
        private System.Windows.Forms.ComboBox MixTypeComboBox;
        private System.Windows.Forms.ComboBox StrengthComboBox;
        private System.Windows.Forms.ComboBox AggregateComboBox;
        private System.Windows.Forms.NumericUpDown PricePerCubicMeterNumericUpDown;
        private System.Windows.Forms.NumericUpDown CementFactorNumericUpDown;
        private System.Windows.Forms.NumericUpDown PSINumericUpDown;
    }
}