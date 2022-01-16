
namespace GUI.QuanTri
{
    partial class frmThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHoaDonThang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHoaDonNam = new System.Windows.Forms.ComboBox();
            this.dtgvDanhSachHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvDanhSachHoaDonBan = new System.Windows.Forms.DataGridView();
            this.MaHoaDonBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTongTienNhap = new System.Windows.Forms.Label();
            this.lblTongTienBan = new System.Windows.Forms.Label();
            this.dtgvDanhSachLuong = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLuongNam = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbLuongThang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTongLuong = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgvSanPhamBanChay = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDonNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamBanChay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hóa đơn tháng: ";
            // 
            // cmbHoaDonThang
            // 
            this.cmbHoaDonThang.FormattingEnabled = true;
            this.cmbHoaDonThang.Location = new System.Drawing.Point(116, 59);
            this.cmbHoaDonThang.Name = "cmbHoaDonThang";
            this.cmbHoaDonThang.Size = new System.Drawing.Size(45, 21);
            this.cmbHoaDonThang.TabIndex = 5;
            this.cmbHoaDonThang.SelectedIndexChanged += new System.EventHandler(this.cmbHoaDonThang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "năm:";
            // 
            // cmbHoaDonNam
            // 
            this.cmbHoaDonNam.FormattingEnabled = true;
            this.cmbHoaDonNam.Location = new System.Drawing.Point(203, 59);
            this.cmbHoaDonNam.Name = "cmbHoaDonNam";
            this.cmbHoaDonNam.Size = new System.Drawing.Size(63, 21);
            this.cmbHoaDonNam.TabIndex = 7;
            this.cmbHoaDonNam.SelectedIndexChanged += new System.EventHandler(this.cmbHoaDonNam_SelectedIndexChanged);
            // 
            // dtgvDanhSachHoaDonNhap
            // 
            this.dtgvDanhSachHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.NgayTao,
            this.TongTien});
            this.dtgvDanhSachHoaDonNhap.Location = new System.Drawing.Point(28, 219);
            this.dtgvDanhSachHoaDonNhap.Name = "dtgvDanhSachHoaDonNhap";
            this.dtgvDanhSachHoaDonNhap.ReadOnly = true;
            this.dtgvDanhSachHoaDonNhap.Size = new System.Drawing.Size(509, 150);
            this.dtgvDanhSachHoaDonNhap.TabIndex = 8;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "Mã hóa đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "ThoiGian";
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hóa đơn nhập:";
            // 
            // dtgvDanhSachHoaDonBan
            // 
            this.dtgvDanhSachHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHoaDonBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDonBan,
            this.NgayBan,
            this.TongTienBan,
            this.NhanVienBan});
            this.dtgvDanhSachHoaDonBan.Location = new System.Drawing.Point(28, 432);
            this.dtgvDanhSachHoaDonBan.Name = "dtgvDanhSachHoaDonBan";
            this.dtgvDanhSachHoaDonBan.ReadOnly = true;
            this.dtgvDanhSachHoaDonBan.Size = new System.Drawing.Size(509, 150);
            this.dtgvDanhSachHoaDonBan.TabIndex = 8;
            // 
            // MaHoaDonBan
            // 
            this.MaHoaDonBan.DataPropertyName = "MaHoaDon";
            this.MaHoaDonBan.HeaderText = "Mã hóa đơn";
            this.MaHoaDonBan.Name = "MaHoaDonBan";
            this.MaHoaDonBan.ReadOnly = true;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "ThoiGian";
            this.NgayBan.HeaderText = "Ngày tạo";
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.ReadOnly = true;
            // 
            // TongTienBan
            // 
            this.TongTienBan.DataPropertyName = "TongTien";
            this.TongTienBan.HeaderText = "Tổng tiền";
            this.TongTienBan.Name = "TongTienBan";
            this.TongTienBan.ReadOnly = true;
            // 
            // NhanVienBan
            // 
            this.NhanVienBan.DataPropertyName = "TenNhanVien";
            this.NhanVienBan.HeaderText = "Nhân viên bán";
            this.NhanVienBan.Name = "NhanVienBan";
            this.NhanVienBan.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hóa đơn bán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng tiền nhập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tổng tiền bán:";
            // 
            // lblTongTienNhap
            // 
            this.lblTongTienNhap.Location = new System.Drawing.Point(400, 196);
            this.lblTongTienNhap.Name = "lblTongTienNhap";
            this.lblTongTienNhap.Size = new System.Drawing.Size(137, 13);
            this.lblTongTienNhap.TabIndex = 0;
            this.lblTongTienNhap.Text = "010000";
            // 
            // lblTongTienBan
            // 
            this.lblTongTienBan.Location = new System.Drawing.Point(400, 407);
            this.lblTongTienBan.Name = "lblTongTienBan";
            this.lblTongTienBan.Size = new System.Drawing.Size(137, 13);
            this.lblTongTienBan.TabIndex = 12;
            this.lblTongTienBan.Text = "010000";
            // 
            // dtgvDanhSachLuong
            // 
            this.dtgvDanhSachLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.HoTen,
            this.SoNgayCong,
            this.Luong});
            this.dtgvDanhSachLuong.Location = new System.Drawing.Point(579, 100);
            this.dtgvDanhSachLuong.Name = "dtgvDanhSachLuong";
            this.dtgvDanhSachLuong.ReadOnly = true;
            this.dtgvDanhSachLuong.Size = new System.Drawing.Size(448, 125);
            this.dtgvDanhSachLuong.TabIndex = 15;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // SoNgayCong
            // 
            this.SoNgayCong.DataPropertyName = "SoNgayCong";
            this.SoNgayCong.HeaderText = "Số ngày công";
            this.SoNgayCong.Name = "SoNgayCong";
            this.SoNgayCong.ReadOnly = true;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lương nhân viên tháng: ";
            // 
            // cmbLuongNam
            // 
            this.cmbLuongNam.FormattingEnabled = true;
            this.cmbLuongNam.Location = new System.Drawing.Point(789, 60);
            this.cmbLuongNam.Name = "cmbLuongNam";
            this.cmbLuongNam.Size = new System.Drawing.Size(63, 21);
            this.cmbLuongNam.TabIndex = 18;
            this.cmbLuongNam.SelectedIndexChanged += new System.EventHandler(this.cmbLuongNam_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(753, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "năm:";
            // 
            // cmbLuongThang
            // 
            this.cmbLuongThang.FormattingEnabled = true;
            this.cmbLuongThang.Location = new System.Drawing.Point(702, 60);
            this.cmbLuongThang.Name = "cmbLuongThang";
            this.cmbLuongThang.Size = new System.Drawing.Size(45, 21);
            this.cmbLuongThang.TabIndex = 16;
            this.cmbLuongThang.SelectedIndexChanged += new System.EventHandler(this.cmbLuongThang_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(577, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tổng lương: ";
            // 
            // lblTongLuong
            // 
            this.lblTongLuong.AutoSize = true;
            this.lblTongLuong.Location = new System.Drawing.Point(650, 252);
            this.lblTongLuong.Name = "lblTongLuong";
            this.lblTongLuong.Size = new System.Drawing.Size(37, 13);
            this.lblTongLuong.TabIndex = 20;
            this.lblTongLuong.Text = "10000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sản phẩm bán chạy nhất:";
            // 
            // dtgvSanPhamBanChay
            // 
            this.dtgvSanPhamBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPhamBanChay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.SoLuong});
            this.dtgvSanPhamBanChay.Enabled = false;
            this.dtgvSanPhamBanChay.Location = new System.Drawing.Point(28, 130);
            this.dtgvSanPhamBanChay.Name = "dtgvSanPhamBanChay";
            this.dtgvSanPhamBanChay.Size = new System.Drawing.Size(509, 52);
            this.dtgvSanPhamBanChay.TabIndex = 22;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.Name = "MaSanPham";
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng bán";
            this.SoLuong.Name = "SoLuong";
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(952, 346);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 23;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 598);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.dtgvSanPhamBanChay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTongLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbLuongNam);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbLuongThang);
            this.Controls.Add(this.dtgvDanhSachLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTongTienBan);
            this.Controls.Add(this.lblTongTienNhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgvDanhSachHoaDonBan);
            this.Controls.Add(this.dtgvDanhSachHoaDonNhap);
            this.Controls.Add(this.cmbHoaDonNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbHoaDonThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDonNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamBanChay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHoaDonThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHoaDonNam;
        private System.Windows.Forms.DataGridView dtgvDanhSachHoaDonNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvDanhSachHoaDonBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTongTienNhap;
        private System.Windows.Forms.Label lblTongTienBan;
        private System.Windows.Forms.DataGridView dtgvDanhSachLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLuongNam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbLuongThang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTongLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgvSanPhamBanChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDonBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.Button btnTroLai;
    }
}