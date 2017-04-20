namespace Citicon.Forms.Controls
{
    partial class TransitMixerManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TransitMixerDataGridView = new System.Windows.Forms.DataGridView();
            this.TransitMixer_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.PlateNumberLabel = new System.Windows.Forms.Label();
            this.PlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.VolumeCapacityTextBox = new System.Windows.Forms.TextBox();
            this.VolumeCapacityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransitMixerDataGridView)).BeginInit();
            this.DetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransitMixerDataGridView
            // 
            this.TransitMixerDataGridView.AllowUserToAddRows = false;
            this.TransitMixerDataGridView.AllowUserToDeleteRows = false;
            this.TransitMixerDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TransitMixerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TransitMixerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransitMixerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TransitMixerDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TransitMixerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransitMixerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.TransitMixerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransitMixerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TransitMixerDataGridView.ColumnHeadersHeight = 60;
            this.TransitMixerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TransitMixerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransitMixer_Column});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransitMixerDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.TransitMixerDataGridView.EnableHeadersVisualStyles = false;
            this.TransitMixerDataGridView.GridColor = System.Drawing.Color.Red;
            this.TransitMixerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.TransitMixerDataGridView.MultiSelect = false;
            this.TransitMixerDataGridView.Name = "TransitMixerDataGridView";
            this.TransitMixerDataGridView.ReadOnly = true;
            this.TransitMixerDataGridView.RowHeadersVisible = false;
            this.TransitMixerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.TransitMixerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.TransitMixerDataGridView.RowTemplate.Height = 40;
            this.TransitMixerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransitMixerDataGridView.Size = new System.Drawing.Size(555, 517);
            this.TransitMixerDataGridView.TabIndex = 116;
            this.TransitMixerDataGridView.SelectionChanged += new System.EventHandler(this.TransitMixerDataGridView_SelectionChanged);
            // 
            // TransitMixer_Column
            // 
            this.TransitMixer_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransitMixer_Column.HeaderText = "TRANSIT MIXERS";
            this.TransitMixer_Column.Name = "TransitMixer_Column";
            this.TransitMixer_Column.ReadOnly = true;
            // 
            // DetailsGroupBox
            // 
            this.DetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsGroupBox.Controls.Add(this.VolumeCapacityTextBox);
            this.DetailsGroupBox.Controls.Add(this.VolumeCapacityLabel);
            this.DetailsGroupBox.Controls.Add(this.PlateNumberTextBox);
            this.DetailsGroupBox.Controls.Add(this.PlateNumberLabel);
            this.DetailsGroupBox.Location = new System.Drawing.Point(564, 3);
            this.DetailsGroupBox.Name = "DetailsGroupBox";
            this.DetailsGroupBox.Size = new System.Drawing.Size(369, 126);
            this.DetailsGroupBox.TabIndex = 117;
            this.DetailsGroupBox.TabStop = false;
            this.DetailsGroupBox.Text = "DETAILS";
            // 
            // PlateNumberLabel
            // 
            this.PlateNumberLabel.AutoSize = true;
            this.PlateNumberLabel.Location = new System.Drawing.Point(6, 21);
            this.PlateNumberLabel.Name = "PlateNumberLabel";
            this.PlateNumberLabel.Size = new System.Drawing.Size(61, 17);
            this.PlateNumberLabel.TabIndex = 0;
            this.PlateNumberLabel.Text = "Plate No.";
            // 
            // PlateNumberTextBox
            // 
            this.PlateNumberTextBox.BackColor = System.Drawing.Color.White;
            this.PlateNumberTextBox.Location = new System.Drawing.Point(9, 41);
            this.PlateNumberTextBox.Name = "PlateNumberTextBox";
            this.PlateNumberTextBox.ReadOnly = true;
            this.PlateNumberTextBox.Size = new System.Drawing.Size(354, 25);
            this.PlateNumberTextBox.TabIndex = 1;
            // 
            // VolumeCapacityTextBox
            // 
            this.VolumeCapacityTextBox.BackColor = System.Drawing.Color.White;
            this.VolumeCapacityTextBox.Location = new System.Drawing.Point(9, 89);
            this.VolumeCapacityTextBox.Name = "VolumeCapacityTextBox";
            this.VolumeCapacityTextBox.ReadOnly = true;
            this.VolumeCapacityTextBox.Size = new System.Drawing.Size(354, 25);
            this.VolumeCapacityTextBox.TabIndex = 3;
            // 
            // VolumeCapacityLabel
            // 
            this.VolumeCapacityLabel.AutoSize = true;
            this.VolumeCapacityLabel.Location = new System.Drawing.Point(6, 69);
            this.VolumeCapacityLabel.Name = "VolumeCapacityLabel";
            this.VolumeCapacityLabel.Size = new System.Drawing.Size(104, 17);
            this.VolumeCapacityLabel.TabIndex = 2;
            this.VolumeCapacityLabel.Text = "Volume Capacity";
            // 
            // TransitMixerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DetailsGroupBox);
            this.Controls.Add(this.TransitMixerDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TransitMixerManagement";
            this.Size = new System.Drawing.Size(936, 523);
            this.Load += new System.EventHandler(this.TransitMixerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransitMixerDataGridView)).EndInit();
            this.DetailsGroupBox.ResumeLayout(false);
            this.DetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TransitMixerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransitMixer_Column;
        private System.Windows.Forms.GroupBox DetailsGroupBox;
        private System.Windows.Forms.Label PlateNumberLabel;
        private System.Windows.Forms.TextBox PlateNumberTextBox;
        private System.Windows.Forms.TextBox VolumeCapacityTextBox;
        private System.Windows.Forms.Label VolumeCapacityLabel;
    }
}
