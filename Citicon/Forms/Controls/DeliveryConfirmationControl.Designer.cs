namespace Citicon.Forms.Controls
{
    partial class DeliveryConfirmationControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.DeliveryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_PlantLeaveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DeliveryDetailsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGridView)).BeginInit();
            this.DesignDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeliveryDataGridView
            // 
            this.DeliveryDataGridView.AllowUserToAddRows = false;
            this.DeliveryDataGridView.AllowUserToDeleteRows = false;
            this.DeliveryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeliveryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DeliveryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DeliveryDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DeliveryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeliveryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DeliveryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DeliveryDataGridView.ColumnHeadersHeight = 60;
            this.DeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DeliveryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeliveryColumn,
            this.Delivery_PlantLeaveColumn,
            this.Delivery_ExtraColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeliveryDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.DeliveryDataGridView.EnableHeadersVisualStyles = false;
            this.DeliveryDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeliveryDataGridView.Location = new System.Drawing.Point(3, 3);
            this.DeliveryDataGridView.MultiSelect = false;
            this.DeliveryDataGridView.Name = "DeliveryDataGridView";
            this.DeliveryDataGridView.ReadOnly = true;
            this.DeliveryDataGridView.RowHeadersVisible = false;
            this.DeliveryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.DeliveryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DeliveryDataGridView.RowTemplate.Height = 40;
            this.DeliveryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeliveryDataGridView.Size = new System.Drawing.Size(913, 874);
            this.DeliveryDataGridView.TabIndex = 126;
            // 
            // DeliveryColumn
            // 
            this.DeliveryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeliveryColumn.HeaderText = "DELIVERIES";
            this.DeliveryColumn.MinimumWidth = 150;
            this.DeliveryColumn.Name = "DeliveryColumn";
            this.DeliveryColumn.ReadOnly = true;
            this.DeliveryColumn.Width = 150;
            // 
            // Delivery_PlantLeaveColumn
            // 
            this.Delivery_PlantLeaveColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "MMM d, yyyy";
            this.Delivery_PlantLeaveColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delivery_PlantLeaveColumn.HeaderText = "PLANT LEAVE";
            this.Delivery_PlantLeaveColumn.MinimumWidth = 125;
            this.Delivery_PlantLeaveColumn.Name = "Delivery_PlantLeaveColumn";
            this.Delivery_PlantLeaveColumn.ReadOnly = true;
            this.Delivery_PlantLeaveColumn.Width = 125;
            // 
            // Delivery_ExtraColumn
            // 
            this.Delivery_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delivery_ExtraColumn.HeaderText = "";
            this.Delivery_ExtraColumn.Name = "Delivery_ExtraColumn";
            this.Delivery_ExtraColumn.ReadOnly = true;
            // 
            // DesignDetailsGroupBox
            // 
            this.DesignDetailsGroupBox.Controls.Add(this.textBox5);
            this.DesignDetailsGroupBox.Controls.Add(this.label5);
            this.DesignDetailsGroupBox.Controls.Add(this.textBox4);
            this.DesignDetailsGroupBox.Controls.Add(this.label4);
            this.DesignDetailsGroupBox.Controls.Add(this.textBox3);
            this.DesignDetailsGroupBox.Controls.Add(this.label3);
            this.DesignDetailsGroupBox.Controls.Add(this.textBox2);
            this.DesignDetailsGroupBox.Controls.Add(this.label2);
            this.DesignDetailsGroupBox.Controls.Add(this.textBox1);
            this.DesignDetailsGroupBox.Controls.Add(this.label1);
            this.DesignDetailsGroupBox.Location = new System.Drawing.Point(922, 3);
            this.DesignDetailsGroupBox.Name = "DesignDetailsGroupBox";
            this.DesignDetailsGroupBox.Size = new System.Drawing.Size(403, 270);
            this.DesignDetailsGroupBox.TabIndex = 128;
            this.DesignDetailsGroupBox.TabStop = false;
            this.DesignDetailsGroupBox.Text = "DESIGN DETAILS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mix Type";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(9, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(388, 25);
            this.textBox1.TabIndex = 129;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(9, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(388, 25);
            this.textBox2.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 130;
            this.label2.Text = "PSI";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(9, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(388, 25);
            this.textBox3.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 132;
            this.label3.Text = "Initial Volume";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(9, 185);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(388, 25);
            this.textBox4.TabIndex = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 134;
            this.label4.Text = "Aggregate";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(9, 233);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(388, 25);
            this.textBox5.TabIndex = 137;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 136;
            this.label5.Text = "Design Strength";
            // 
            // DeliveryDetailsGroupBox
            // 
            this.DeliveryDetailsGroupBox.Location = new System.Drawing.Point(922, 279);
            this.DeliveryDetailsGroupBox.Name = "DeliveryDetailsGroupBox";
            this.DeliveryDetailsGroupBox.Size = new System.Drawing.Size(403, 259);
            this.DeliveryDetailsGroupBox.TabIndex = 130;
            this.DeliveryDetailsGroupBox.TabStop = false;
            this.DeliveryDetailsGroupBox.Text = "DELIVERY DETAILS";
            // 
            // DeliveryConfirmationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DeliveryDetailsGroupBox);
            this.Controls.Add(this.DesignDetailsGroupBox);
            this.Controls.Add(this.DeliveryDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "DeliveryConfirmationControl";
            this.Size = new System.Drawing.Size(1328, 881);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGridView)).EndInit();
            this.DesignDetailsGroupBox.ResumeLayout(false);
            this.DesignDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DeliveryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_PlantLeaveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_ExtraColumn;
        private System.Windows.Forms.GroupBox DesignDetailsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox DeliveryDetailsGroupBox;
    }
}
