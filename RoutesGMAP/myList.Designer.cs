namespace RoutesGMAP
{
    partial class myList
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.refreshButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.delLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.MyListDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtExport = new Bunifu.Framework.UI.BunifuImageButton();
            this.WordExport = new Bunifu.Framework.UI.BunifuImageButton();
            this.ExcelExport = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelExport)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageActive = null;
            this.refreshButton.Location = new System.Drawing.Point(605, 69);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(45, 36);
            this.refreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshButton.TabIndex = 32;
            this.refreshButton.TabStop = false;
            this.refreshButton.Zoom = 10;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // delLabel
            // 
            this.delLabel.AutoSize = true;
            this.delLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delLabel.ForeColor = System.Drawing.Color.Red;
            this.delLabel.Location = new System.Drawing.Point(53, 17);
            this.delLabel.Name = "delLabel";
            this.delLabel.Size = new System.Drawing.Size(67, 20);
            this.delLabel.TabIndex = 31;
            this.delLabel.Text = "Удален";
            this.delLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(2, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Двойное нажатие по товару, чтобы удалить его из списка";
            // 
            // MyListDataGrid
            // 
            this.MyListDataGrid.AllowUserToAddRows = false;
            this.MyListDataGrid.AllowUserToDeleteRows = false;
            this.MyListDataGrid.AllowUserToResizeColumns = false;
            this.MyListDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.MyListDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MyListDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MyListDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyListDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.MyListDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyListDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MyListDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyListDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MyListDataGrid.ColumnHeadersHeight = 35;
            this.MyListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MyListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MyListDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.MyListDataGrid.DoubleBuffered = true;
            this.MyListDataGrid.EnableHeadersVisualStyles = false;
            this.MyListDataGrid.GridColor = System.Drawing.Color.Gray;
            this.MyListDataGrid.HeaderBgColor = System.Drawing.Color.Gray;
            this.MyListDataGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.MyListDataGrid.Location = new System.Drawing.Point(57, 69);
            this.MyListDataGrid.MultiSelect = false;
            this.MyListDataGrid.Name = "MyListDataGrid";
            this.MyListDataGrid.ReadOnly = true;
            this.MyListDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyListDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MyListDataGrid.RowHeadersVisible = false;
            this.MyListDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.MyListDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.MyListDataGrid.RowTemplate.ReadOnly = true;
            this.MyListDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MyListDataGrid.Size = new System.Drawing.Size(542, 340);
            this.MyListDataGrid.TabIndex = 29;
            this.MyListDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyListDataGrid_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 101.5228F;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 99.61929F;
            this.Column2.HeaderText = "Товар";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 99.61929F;
            this.Column3.HeaderText = "Объем";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 99.61929F;
            this.Column4.HeaderText = "Магазин";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 99.61929F;
            this.Column5.HeaderText = "Цена";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // TxtExport
            // 
            this.TxtExport.BackColor = System.Drawing.Color.Transparent;
            this.TxtExport.Image = ((System.Drawing.Image)(resources.GetObject("TxtExport.Image")));
            this.TxtExport.ImageActive = null;
            this.TxtExport.Location = new System.Drawing.Point(479, 474);
            this.TxtExport.Name = "TxtExport";
            this.TxtExport.Size = new System.Drawing.Size(62, 63);
            this.TxtExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TxtExport.TabIndex = 28;
            this.TxtExport.TabStop = false;
            this.TxtExport.Zoom = 10;
            this.TxtExport.Click += new System.EventHandler(this.TxtExport_Click);
            // 
            // WordExport
            // 
            this.WordExport.BackColor = System.Drawing.Color.Transparent;
            this.WordExport.Image = ((System.Drawing.Image)(resources.GetObject("WordExport.Image")));
            this.WordExport.ImageActive = null;
            this.WordExport.Location = new System.Drawing.Point(542, 474);
            this.WordExport.Name = "WordExport";
            this.WordExport.Size = new System.Drawing.Size(62, 63);
            this.WordExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WordExport.TabIndex = 27;
            this.WordExport.TabStop = false;
            this.WordExport.Zoom = 10;
            this.WordExport.Click += new System.EventHandler(this.WordExport_Click);
            // 
            // ExcelExport
            // 
            this.ExcelExport.BackColor = System.Drawing.Color.Transparent;
            this.ExcelExport.Image = ((System.Drawing.Image)(resources.GetObject("ExcelExport.Image")));
            this.ExcelExport.ImageActive = null;
            this.ExcelExport.Location = new System.Drawing.Point(606, 474);
            this.ExcelExport.Name = "ExcelExport";
            this.ExcelExport.Size = new System.Drawing.Size(62, 63);
            this.ExcelExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExcelExport.TabIndex = 26;
            this.ExcelExport.TabStop = false;
            this.ExcelExport.Zoom = 10;
            this.ExcelExport.Click += new System.EventHandler(this.ExcelExport_Click);
            // 
            // myList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.delLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyListDataGrid);
            this.Controls.Add(this.TxtExport);
            this.Controls.Add(this.WordExport);
            this.Controls.Add(this.ExcelExport);
            this.Name = "myList";
            this.Size = new System.Drawing.Size(670, 541);
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton refreshButton;
        private Bunifu.Framework.UI.BunifuCustomLabel delLabel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid MyListDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Bunifu.Framework.UI.BunifuImageButton TxtExport;
        private Bunifu.Framework.UI.BunifuImageButton WordExport;
        private Bunifu.Framework.UI.BunifuImageButton ExcelExport;
    }
}
