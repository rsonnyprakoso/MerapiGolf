﻿namespace MerapiGolfLogistik
{
    partial class PilihBarangDikembalikan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilihBarangDikembalikan));
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.queryTb = new System.Windows.Forms.TextBox();
            this.barangList = new System.Windows.Forms.DataGridView();
            this.id_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.namaBarangTb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jumlahTb = new System.Windows.Forms.TextBox();
            this.satuanLabel = new System.Windows.Forms.Label();
            this.tambahBarangBtn = new System.Windows.Forms.Button();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banyakbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaaktivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengambilanPerBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barangList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pengambilanPerBarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(395, 10);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(66, 22);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Cari (F2)";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cari Barang";
            // 
            // queryTb
            // 
            this.queryTb.Location = new System.Drawing.Point(77, 10);
            this.queryTb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.queryTb.Name = "queryTb";
            this.queryTb.Size = new System.Drawing.Size(314, 20);
            this.queryTb.TabIndex = 3;
            // 
            // barangList
            // 
            this.barangList.AutoGenerateColumns = false;
            this.barangList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barangList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_barang,
            this.namabarangDataGridViewTextBoxColumn,
            this.banyakbarangDataGridViewTextBoxColumn,
            this.stok,
            this.namaaktivaDataGridViewTextBoxColumn});
            this.barangList.DataSource = this.pengambilanPerBarangBindingSource;
            this.barangList.Location = new System.Drawing.Point(10, 41);
            this.barangList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.barangList.Name = "barangList";
            this.barangList.RowTemplate.Height = 28;
            this.barangList.Size = new System.Drawing.Size(449, 251);
            this.barangList.TabIndex = 6;
            this.barangList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barangList_CellDoubleClick);
            // 
            // id_barang
            // 
            this.id_barang.DataPropertyName = "id_barang";
            this.id_barang.HeaderText = "id_barang";
            this.id_barang.Name = "id_barang";
            this.id_barang.Visible = false;
            this.id_barang.Width = 5;
            // 
            // stok
            // 
            this.stok.DataPropertyName = "satuan";
            this.stok.HeaderText = "Satuan";
            this.stok.Name = "stok";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.namaBarangTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.jumlahTb);
            this.groupBox1.Controls.Add(this.satuanLabel);
            this.groupBox1.Location = new System.Drawing.Point(10, 294);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(451, 52);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barang Terpilih";
            this.groupBox1.Visible = false;
            // 
            // namaBarangTb
            // 
            this.namaBarangTb.AutoSize = true;
            this.namaBarangTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaBarangTb.Location = new System.Drawing.Point(4, 21);
            this.namaBarangTb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namaBarangTb.Name = "namaBarangTb";
            this.namaBarangTb.Size = new System.Drawing.Size(127, 13);
            this.namaBarangTb.TabIndex = 5;
            this.namaBarangTb.Text = "[Pilih Barang Dahulu]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Banyak Dikembalikan:";
            // 
            // jumlahTb
            // 
            this.jumlahTb.Location = new System.Drawing.Point(310, 17);
            this.jumlahTb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.jumlahTb.Name = "jumlahTb";
            this.jumlahTb.Size = new System.Drawing.Size(71, 20);
            this.jumlahTb.TabIndex = 6;
            this.jumlahTb.TextChanged += new System.EventHandler(this.jumlahTb_TextChanged);
            this.jumlahTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jumlahTb_KeyPress);
            // 
            // satuanLabel
            // 
            this.satuanLabel.AutoSize = true;
            this.satuanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satuanLabel.Location = new System.Drawing.Point(385, 20);
            this.satuanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.satuanLabel.Name = "satuanLabel";
            this.satuanLabel.Size = new System.Drawing.Size(55, 13);
            this.satuanLabel.TabIndex = 7;
            this.satuanLabel.Text = "[Satuan]";
            // 
            // tambahBarangBtn
            // 
            this.tambahBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahBarangBtn.Image")));
            this.tambahBarangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tambahBarangBtn.Location = new System.Drawing.Point(336, 348);
            this.tambahBarangBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tambahBarangBtn.Name = "tambahBarangBtn";
            this.tambahBarangBtn.Size = new System.Drawing.Size(125, 26);
            this.tambahBarangBtn.TabIndex = 15;
            this.tambahBarangBtn.Text = "Tambah Barang (F5)";
            this.tambahBarangBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tambahBarangBtn.UseVisualStyleBackColor = true;
            this.tambahBarangBtn.Visible = false;
            this.tambahBarangBtn.Click += new System.EventHandler(this.tambahBarangBtn_Click);
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            // 
            // banyakbarangDataGridViewTextBoxColumn
            // 
            this.banyakbarangDataGridViewTextBoxColumn.DataPropertyName = "banyak_barang";
            this.banyakbarangDataGridViewTextBoxColumn.HeaderText = "Jumlah Diambil";
            this.banyakbarangDataGridViewTextBoxColumn.Name = "banyakbarangDataGridViewTextBoxColumn";
            // 
            // namaaktivaDataGridViewTextBoxColumn
            // 
            this.namaaktivaDataGridViewTextBoxColumn.DataPropertyName = "nama_aktiva";
            this.namaaktivaDataGridViewTextBoxColumn.HeaderText = "Digunakan Untuk";
            this.namaaktivaDataGridViewTextBoxColumn.Name = "namaaktivaDataGridViewTextBoxColumn";
            // 
            // pengambilanPerBarangBindingSource
            // 
            this.pengambilanPerBarangBindingSource.DataSource = typeof(MerapiGolfLogistik.PengambilanPerBarang);
            // 
            // PilihBarangDikembalikan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 384);
            this.Controls.Add(this.tambahBarangBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barangList);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryTb);
            this.Name = "PilihBarangDikembalikan";
            this.Text = "Pilih Barang - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PilihBarangDikembalikan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barangList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pengambilanPerBarangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox queryTb;
        private System.Windows.Forms.DataGridView barangList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label namaBarangTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox jumlahTb;
        private System.Windows.Forms.Label satuanLabel;
        private System.Windows.Forms.Button tambahBarangBtn;
        private System.Windows.Forms.BindingSource pengambilanPerBarangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaaktivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn banyakbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
    }
}