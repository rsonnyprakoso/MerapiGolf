﻿namespace MerapiGolfLogistik
{
    partial class InputBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBarang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tooltipStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.kategoriTb = new System.Windows.Forms.TextBox();
            this.pilihKategoriBtn = new System.Windows.Forms.Button();
            this.namaBarangTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.satuanTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tanggalInputTb = new System.Windows.Forms.DateTimePicker();
            this.itemsView = new System.Windows.Forms.DataGridView();
            this.itemViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.cariBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.subsiTb = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.subsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastcreateditemdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilih Kategori";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.tooltipStatus,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(721, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Sistem Siap.";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tooltipStatus
            // 
            this.tooltipStatus.Name = "tooltipStatus";
            this.tooltipStatus.Size = new System.Drawing.Size(39, 17);
            this.tooltipStatus.Text = "Ready";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(67, 16);
            this.progressBar.Visible = false;
            // 
            // kategoriTb
            // 
            this.kategoriTb.Enabled = false;
            this.kategoriTb.Location = new System.Drawing.Point(140, 10);
            this.kategoriTb.Margin = new System.Windows.Forms.Padding(2);
            this.kategoriTb.Name = "kategoriTb";
            this.kategoriTb.Size = new System.Drawing.Size(426, 20);
            this.kategoriTb.TabIndex = 2;
            // 
            // pilihKategoriBtn
            // 
            this.pilihKategoriBtn.Image = ((System.Drawing.Image)(resources.GetObject("pilihKategoriBtn.Image")));
            this.pilihKategoriBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pilihKategoriBtn.Location = new System.Drawing.Point(590, 10);
            this.pilihKategoriBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pilihKategoriBtn.Name = "pilihKategoriBtn";
            this.pilihKategoriBtn.Size = new System.Drawing.Size(120, 24);
            this.pilihKategoriBtn.TabIndex = 9;
            this.pilihKategoriBtn.Text = "Pilih Kategori (F1)";
            this.pilihKategoriBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pilihKategoriBtn.UseVisualStyleBackColor = true;
            this.pilihKategoriBtn.Click += new System.EventHandler(this.pilihKategoriBtn_Click);
            // 
            // namaBarangTb
            // 
            this.namaBarangTb.Location = new System.Drawing.Point(140, 69);
            this.namaBarangTb.Margin = new System.Windows.Forms.Padding(2);
            this.namaBarangTb.Name = "namaBarangTb";
            this.namaBarangTb.Size = new System.Drawing.Size(426, 20);
            this.namaBarangTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama Barang*";
            // 
            // satuanTb
            // 
            this.satuanTb.Location = new System.Drawing.Point(140, 98);
            this.satuanTb.Margin = new System.Windows.Forms.Padding(2);
            this.satuanTb.Name = "satuanTb";
            this.satuanTb.Size = new System.Drawing.Size(426, 20);
            this.satuanTb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Satuan (cth: pcs/liter)*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tanggal Pengisian";
            // 
            // tanggalInputTb
            // 
            this.tanggalInputTb.Location = new System.Drawing.Point(140, 40);
            this.tanggalInputTb.Margin = new System.Windows.Forms.Padding(2);
            this.tanggalInputTb.Name = "tanggalInputTb";
            this.tanggalInputTb.Size = new System.Drawing.Size(426, 20);
            this.tanggalInputTb.TabIndex = 3;
            // 
            // itemsView
            // 
            this.itemsView.AllowUserToAddRows = false;
            this.itemsView.AllowUserToDeleteRows = false;
            this.itemsView.AutoGenerateColumns = false;
            this.itemsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.itemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.DeleteColumn,
            this.subsi,
            this.namabarangDataGridViewTextBoxColumn,
            this.satuanDataGridViewTextBoxColumn,
            this.itemcountDataGridViewTextBoxColumn,
            this.lastcreateditemdateDataGridViewTextBoxColumn,
            this.idkategoriDataGridViewTextBoxColumn});
            this.itemsView.DataSource = this.itemViewBindingSource;
            this.itemsView.Location = new System.Drawing.Point(11, 183);
            this.itemsView.Margin = new System.Windows.Forms.Padding(2);
            this.itemsView.Name = "itemsView";
            this.itemsView.RowTemplate.Height = 28;
            this.itemsView.Size = new System.Drawing.Size(699, 304);
            this.itemsView.TabIndex = 12;
            this.itemsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsView_CellContentClick);
            // 
            // itemViewBindingSource
            // 
            this.itemViewBindingSource.DataSource = typeof(MerapiGolfLogistik.Models.ItemView);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cari Barang:";
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(140, 155);
            this.searchTb.Margin = new System.Windows.Forms.Padding(2);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(426, 20);
            this.searchTb.TabIndex = 10;
            this.searchTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTb_KeyDown);
            // 
            // cariBtn
            // 
            this.cariBtn.Image = ((System.Drawing.Image)(resources.GetObject("cariBtn.Image")));
            this.cariBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cariBtn.Location = new System.Drawing.Point(590, 155);
            this.cariBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cariBtn.Name = "cariBtn";
            this.cariBtn.Size = new System.Drawing.Size(120, 24);
            this.cariBtn.TabIndex = 11;
            this.cariBtn.Text = "Cari (F2)";
            this.cariBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cariBtn.UseVisualStyleBackColor = true;
            this.cariBtn.Click += new System.EventHandler(this.cariBtn_Click);
            // 
            // simpanBtn
            // 
            this.simpanBtn.Image = ((System.Drawing.Image)(resources.GetObject("simpanBtn.Image")));
            this.simpanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.simpanBtn.Location = new System.Drawing.Point(227, 127);
            this.simpanBtn.Margin = new System.Windows.Forms.Padding(2);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(73, 19);
            this.simpanBtn.TabIndex = 7;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(305, 127);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(73, 19);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Batal";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kode Barang* :";
            // 
            // subsiTb
            // 
            this.subsiTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subsiTb.Location = new System.Drawing.Point(590, 93);
            this.subsiTb.Margin = new System.Windows.Forms.Padding(2);
            this.subsiTb.Name = "subsiTb";
            this.subsiTb.Size = new System.Drawing.Size(120, 26);
            this.subsiTb.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Kode";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // DeleteColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "X";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 50;
            // 
            // subsi
            // 
            this.subsi.DataPropertyName = "subsi";
            this.subsi.HeaderText = "Kode Barang";
            this.subsi.Name = "subsi";
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // satuanDataGridViewTextBoxColumn
            // 
            this.satuanDataGridViewTextBoxColumn.DataPropertyName = "satuan";
            this.satuanDataGridViewTextBoxColumn.HeaderText = "Satuan";
            this.satuanDataGridViewTextBoxColumn.Name = "satuanDataGridViewTextBoxColumn";
            this.satuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemcountDataGridViewTextBoxColumn
            // 
            this.itemcountDataGridViewTextBoxColumn.DataPropertyName = "itemcount";
            this.itemcountDataGridViewTextBoxColumn.HeaderText = "Jumlah Stok";
            this.itemcountDataGridViewTextBoxColumn.Name = "itemcountDataGridViewTextBoxColumn";
            this.itemcountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastcreateditemdateDataGridViewTextBoxColumn
            // 
            this.lastcreateditemdateDataGridViewTextBoxColumn.DataPropertyName = "lastcreateditemdate";
            this.lastcreateditemdateDataGridViewTextBoxColumn.HeaderText = "Tanggal Terakhir Ditambah";
            this.lastcreateditemdateDataGridViewTextBoxColumn.Name = "lastcreateditemdateDataGridViewTextBoxColumn";
            this.lastcreateditemdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idkategoriDataGridViewTextBoxColumn
            // 
            this.idkategoriDataGridViewTextBoxColumn.DataPropertyName = "categoryname";
            this.idkategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.idkategoriDataGridViewTextBoxColumn.Name = "idkategoriDataGridViewTextBoxColumn";
            this.idkategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InputBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 518);
            this.Controls.Add(this.subsiTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.cariBtn);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemsView);
            this.Controls.Add(this.tanggalInputTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.satuanTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.namaBarangTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pilihKategoriBtn);
            this.Controls.Add(this.kategoriTb);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InputBarang";
            this.ShowInTaskbar = false;
            this.Text = "Input Jenis Barang - Merapi Golf Inventory";
            this.Load += new System.EventHandler(this.Gudang_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBarang_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TextBox kategoriTb;
        private System.Windows.Forms.Button pilihKategoriBtn;
        private System.Windows.Forms.TextBox namaBarangTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox satuanTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tanggalInputTb;
        private System.Windows.Forms.DataGridView itemsView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button cariBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.BindingSource itemViewBindingSource;
        private System.Windows.Forms.ToolStripStatusLabel tooltipStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subsiTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn subsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastcreateditemdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}