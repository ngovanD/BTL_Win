
namespace GUI.QuanTri
{
    partial class frmXemThongTinHoaDonBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMaNhanVien = new System.Windows.Forms.ComboBox();
            this.txtKetThuc = new System.Windows.Forms.TextBox();
            this.txtBatDau = new System.Windows.Forms.TextBox();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblTieuDeTK2 = new System.Windows.Forms.Label();
            this.lblTieuDeTK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLoaiTK = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 502);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxMaNhanVien);
            this.panel1.Controls.Add(this.txtKetThuc);
            this.panel1.Controls.Add(this.txtBatDau);
            this.panel1.Controls.Add(this.dtpKetThuc);
            this.panel1.Controls.Add(this.dtpBatDau);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.lblTieuDeTK2);
            this.panel1.Controls.Add(this.lblTieuDeTK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxLoaiTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 46);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(800, 94);
            this.panel1.TabIndex = 1;
            // 
            // cbxMaNhanVien
            // 
            this.cbxMaNhanVien.FormattingEnabled = true;
            this.cbxMaNhanVien.Location = new System.Drawing.Point(420, 37);
            this.cbxMaNhanVien.Name = "cbxMaNhanVien";
            this.cbxMaNhanVien.Size = new System.Drawing.Size(146, 21);
            this.cbxMaNhanVien.TabIndex = 5;
            this.cbxMaNhanVien.Visible = false;
            this.cbxMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbxMaNhanVien_SelectedIndexChanged);
            // 
            // txtKetThuc
            // 
            this.txtKetThuc.Location = new System.Drawing.Point(650, 39);
            this.txtKetThuc.Name = "txtKetThuc";
            this.txtKetThuc.Size = new System.Drawing.Size(79, 20);
            this.txtKetThuc.TabIndex = 4;
            this.txtKetThuc.Visible = false;
            this.txtKetThuc.TextChanged += new System.EventHandler(this.tongTien_TextChanged);
            this.txtKetThuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tongTien_KeyPress);
            // 
            // txtBatDau
            // 
            this.txtBatDau.Location = new System.Drawing.Point(420, 39);
            this.txtBatDau.Name = "txtBatDau";
            this.txtBatDau.Size = new System.Drawing.Size(79, 20);
            this.txtBatDau.TabIndex = 4;
            this.txtBatDau.Visible = false;
            this.txtBatDau.TextChanged += new System.EventHandler(this.tongTien_TextChanged);
            this.txtBatDau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tongTien_KeyPress);
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKetThuc.Location = new System.Drawing.Point(650, 39);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(79, 20);
            this.dtpKetThuc.TabIndex = 3;
            this.dtpKetThuc.Visible = false;
            this.dtpKetThuc.ValueChanged += new System.EventHandler(this.thoiGian_ValueChanged);
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBatDau.Location = new System.Drawing.Point(420, 39);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(79, 20);
            this.dtpBatDau.TabIndex = 3;
            this.dtpBatDau.Visible = false;
            this.dtpBatDau.ValueChanged += new System.EventHandler(this.thoiGian_ValueChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(420, 38);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(309, 20);
            this.txtMaHD.TabIndex = 2;
            this.txtMaHD.Visible = false;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // lblTieuDeTK2
            // 
            this.lblTieuDeTK2.Location = new System.Drawing.Point(529, 3);
            this.lblTieuDeTK2.Name = "lblTieuDeTK2";
            this.lblTieuDeTK2.Size = new System.Drawing.Size(96, 88);
            this.lblTieuDeTK2.TabIndex = 1;
            this.lblTieuDeTK2.Text = "Chưa có";
            this.lblTieuDeTK2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTieuDeTK2.Visible = false;
            // 
            // lblTieuDeTK
            // 
            this.lblTieuDeTK.Location = new System.Drawing.Point(314, 3);
            this.lblTieuDeTK.Name = "lblTieuDeTK";
            this.lblTieuDeTK.Size = new System.Drawing.Size(100, 88);
            this.lblTieuDeTK.TabIndex = 1;
            this.lblTieuDeTK.Text = "Chưa có";
            this.lblTieuDeTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDeTK.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 88);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tìm kiếm theo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxLoaiTK
            // 
            this.cbxLoaiTK.FormattingEnabled = true;
            this.cbxLoaiTK.Items.AddRange(new object[] {
            "Hiện tất cả HD",
            "Mã hóa đơn",
            "Mã nhân viên",
            "Ngày xuất",
            "Tổng số tiền"});
            this.cbxLoaiTK.Location = new System.Drawing.Point(138, 38);
            this.cbxLoaiTK.Name = "cbxLoaiTK";
            this.cbxLoaiTK.Size = new System.Drawing.Size(121, 21);
            this.cbxLoaiTK.TabIndex = 0;
            this.cbxLoaiTK.Text = "Hiện tất cả HD";
            this.cbxLoaiTK.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiTK_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.lblTongTien);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblTongHoaDon);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(6, 452);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(800, 44);
            this.panel3.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(641, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 32);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(420, 6);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(3);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(205, 29);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Chưa có";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số tiền:";
            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongHoaDon.Location = new System.Drawing.Point(144, 6);
            this.lblTongHoaDon.Margin = new System.Windows.Forms.Padding(3);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(157, 32);
            this.lblTongHoaDon.TabIndex = 0;
            this.lblTongHoaDon.Text = "Chưa có";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "XEM THÔNG TIN HÓA ĐƠN BÁN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn bán";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.ThoiGian,
            this.MaNV,
            this.HoTenNV,
            this.KhuyenMai,
            this.TongTien});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 16);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.Size = new System.Drawing.Size(794, 281);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.DoubleClick += new System.EventHandler(this.dgvHoaDon_DoubleClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 120;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            dataGridViewCellStyle4.Format = "G";
            dataGridViewCellStyle4.NullValue = "dd/MM/yyyy HH:mm:ss";
            this.ThoiGian.DefaultCellStyle = dataGridViewCellStyle4;
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            this.ThoiGian.Width = 200;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Họ tên NV";
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.ReadOnly = true;
            this.HoTenNV.Width = 120;
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.DataPropertyName = "KhuyenMai";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0 đ";
            this.KhuyenMai.DefaultCellStyle = dataGridViewCellStyle5;
            this.KhuyenMai.HeaderText = "Khuyến mại";
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,### đ";
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 110;
            // 
            // frmXemThongTinHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmXemThongTinHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem thông tin hóa đơn bán";
            this.Load += new System.EventHandler(this.frmXemThongTinHoaDonBan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxLoaiTK;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblTieuDeTK;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label lblTieuDeTK2;
        private System.Windows.Forms.TextBox txtKetThuc;
        private System.Windows.Forms.TextBox txtBatDau;
        private System.Windows.Forms.ComboBox cbxMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}