namespace Citicon.Payables.Reports
{
    partial class ChequeReportFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Filter = new System.Windows.Forms.GroupBox();
            this.cmbxSupplier = new System.Windows.Forms.ComboBox();
            this.ckbxSupplier = new System.Windows.Forms.CheckBox();
            this.pnlRangeDate = new System.Windows.Forms.Panel();
            this.dtpRangeDate_End = new System.Windows.Forms.DateTimePicker();
            this.lblRangeDateTo = new System.Windows.Forms.Label();
            this.dtpRangeDate_Start = new System.Windows.Forms.DateTimePicker();
            this.ckbxRangeDate = new System.Windows.Forms.CheckBox();
            this.Filter.SuspendLayout();
            this.pnlRangeDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filter
            // 
            this.Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Filter.Controls.Add(this.cmbxSupplier);
            this.Filter.Controls.Add(this.ckbxSupplier);
            this.Filter.Controls.Add(this.pnlRangeDate);
            this.Filter.Controls.Add(this.ckbxRangeDate);
            this.Filter.Location = new System.Drawing.Point(3, 3);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(754, 203);
            this.Filter.TabIndex = 0;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // cmbxSupplier
            // 
            this.cmbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSupplier.Enabled = false;
            this.cmbxSupplier.FormattingEnabled = true;
            this.cmbxSupplier.Location = new System.Drawing.Point(121, 63);
            this.cmbxSupplier.Name = "cmbxSupplier";
            this.cmbxSupplier.Size = new System.Drawing.Size(357, 29);
            this.cmbxSupplier.TabIndex = 3;
            this.cmbxSupplier.SelectedIndexChanged += new System.EventHandler(this.CmbxSupplier_SelectedIndexChanged);
            // 
            // ckbxSupplier
            // 
            this.ckbxSupplier.AutoSize = true;
            this.ckbxSupplier.Location = new System.Drawing.Point(6, 65);
            this.ckbxSupplier.Name = "ckbxSupplier";
            this.ckbxSupplier.Size = new System.Drawing.Size(87, 25);
            this.ckbxSupplier.TabIndex = 2;
            this.ckbxSupplier.Text = "Supplier";
            this.ckbxSupplier.UseVisualStyleBackColor = true;
            this.ckbxSupplier.CheckedChanged += new System.EventHandler(this.CkbxSupplier_CheckedChanged);
            // 
            // pnlRangeDate
            // 
            this.pnlRangeDate.Controls.Add(this.dtpRangeDate_End);
            this.pnlRangeDate.Controls.Add(this.lblRangeDateTo);
            this.pnlRangeDate.Controls.Add(this.dtpRangeDate_Start);
            this.pnlRangeDate.Enabled = false;
            this.pnlRangeDate.Location = new System.Drawing.Point(121, 28);
            this.pnlRangeDate.Name = "pnlRangeDate";
            this.pnlRangeDate.Size = new System.Drawing.Size(357, 29);
            this.pnlRangeDate.TabIndex = 1;
            // 
            // dtpRangeDate_End
            // 
            this.dtpRangeDate_End.CustomFormat = "MMM dd, yyyy";
            this.dtpRangeDate_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRangeDate_End.Location = new System.Drawing.Point(197, 0);
            this.dtpRangeDate_End.Name = "dtpRangeDate_End";
            this.dtpRangeDate_End.Size = new System.Drawing.Size(160, 29);
            this.dtpRangeDate_End.TabIndex = 2;
            this.dtpRangeDate_End.ValueChanged += new System.EventHandler(this.DtpRangeDate_End_ValueChanged);
            // 
            // lblRangeDateTo
            // 
            this.lblRangeDateTo.AutoSize = true;
            this.lblRangeDateTo.Location = new System.Drawing.Point(166, 4);
            this.lblRangeDateTo.Name = "lblRangeDateTo";
            this.lblRangeDateTo.Size = new System.Drawing.Size(25, 21);
            this.lblRangeDateTo.TabIndex = 0;
            this.lblRangeDateTo.Text = "To";
            // 
            // dtpRangeDate_Start
            // 
            this.dtpRangeDate_Start.CustomFormat = "MMM dd, yyyy";
            this.dtpRangeDate_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRangeDate_Start.Location = new System.Drawing.Point(0, 0);
            this.dtpRangeDate_Start.Name = "dtpRangeDate_Start";
            this.dtpRangeDate_Start.Size = new System.Drawing.Size(160, 29);
            this.dtpRangeDate_Start.TabIndex = 0;
            this.dtpRangeDate_Start.ValueChanged += new System.EventHandler(this.DtpRangeDate_Start_ValueChanged);
            // 
            // ckbxRangeDate
            // 
            this.ckbxRangeDate.AutoSize = true;
            this.ckbxRangeDate.Location = new System.Drawing.Point(6, 31);
            this.ckbxRangeDate.Name = "ckbxRangeDate";
            this.ckbxRangeDate.Size = new System.Drawing.Size(109, 25);
            this.ckbxRangeDate.TabIndex = 0;
            this.ckbxRangeDate.Text = "Range Date";
            this.ckbxRangeDate.UseVisualStyleBackColor = true;
            this.ckbxRangeDate.CheckedChanged += new System.EventHandler(this.CkbxRangeDate_CheckedChanged);
            // 
            // ChequeReportFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Filter);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChequeReportFilter";
            this.Size = new System.Drawing.Size(760, 209);
            this.Load += new System.EventHandler(this.ChequeReportFilter_Load);
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.pnlRangeDate.ResumeLayout(false);
            this.pnlRangeDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.CheckBox ckbxRangeDate;
        private System.Windows.Forms.Panel pnlRangeDate;
        private System.Windows.Forms.DateTimePicker dtpRangeDate_Start;
        private System.Windows.Forms.DateTimePicker dtpRangeDate_End;
        private System.Windows.Forms.Label lblRangeDateTo;
        private System.Windows.Forms.CheckBox ckbxSupplier;
        private System.Windows.Forms.ComboBox cmbxSupplier;
    }
}
