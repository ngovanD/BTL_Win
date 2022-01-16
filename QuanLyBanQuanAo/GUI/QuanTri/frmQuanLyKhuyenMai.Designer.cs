
namespace GUI.QuanTri
{
    partial class frmQuanLyKhuyenMai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvDanhSachKhuyenMai = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.txtSoLuongCon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHanSuDung = new System.Windows.Forms.DateTimePicker();
            this.MaKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDanhSachKhuyenMai
            // 
            this.dtgvDanhSachKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhuyenMai,
            this.Code,
            this.GiaTri,
            this.SoLuongCon,
            this.HanSuDung});
            this.dtgvDanhSachKhuyenMai.Location = new System.Drawing.Point(12, 277);
            this.dtgvDanhSachKhuyenMai.Name = "dtgvDanhSachKhuyenMai";
            this.dtgvDanhSachKhuyenMai.Size = new System.Drawing.Size(621, 194);
            this.dtgvDanhSachKhuyenMai.TabIndex = 16;
            this.dtgvDanhSachKhuyenMai.SelectionChanged += new System.EventHandler(this.dtgvDanhSachKhuyenMai_SelectionChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(338, 244);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(216, 244);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã khuyến mại:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(99, 244);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(244, 37);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.ReadOnly = true;
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(234, 20);
            this.txtMaKhuyenMai.TabIndex = 10;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(244, 76);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(169, 20);
            this.txtCode.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Code:";
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(455, 244);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 18;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(419, 74);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(59, 23);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá trị";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(244, 118);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(234, 20);
            this.txtGiaTri.TabIndex = 11;
            // 
            // txtSoLuongCon
            // 
            this.txtSoLuongCon.Location = new System.Drawing.Point(244, 160);
            this.txtSoLuongCon.Name = "txtSoLuongCon";
            this.txtSoLuongCon.Size = new System.Drawing.Size(234, 20);
            this.txtSoLuongCon.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số lượng còn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hạn sử dụng";
            // 
            // dtpHanSuDung
            // 
            this.dtpHanSuDung.CustomFormat = "dd/MM/yyyy";
            this.dtpHanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanSuDung.Location = new System.Drawing.Point(244, 202);
            this.dtpHanSuDung.Name = "dtpHanSuDung";
            this.dtpHanSuDung.Size = new System.Drawing.Size(99, 20);
            this.dtpHanSuDung.TabIndex = 22;
            // 
            // MaKhuyenMai
            // 
            this.MaKhuyenMai.DataPropertyName = "MaKhuyenMai";
            this.MaKhuyenMai.HeaderText = "Mã khuyến mại";
            this.MaKhuyenMai.Name = "MaKhuyenMai";
            this.MaKhuyenMai.Width = 125;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.Width = 150;
            // 
            // GiaTri
            // 
            this.GiaTri.DataPropertyName = "GiaTri";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,### đ";
            this.GiaTri.DefaultCellStyle = dataGridViewCellStyle1;
            this.GiaTri.HeaderText = "Giá trị";
            this.GiaTri.Name = "GiaTri";
            // 
            // SoLuongCon
            // 
            this.SoLuongCon.DataPropertyName = "SoLuongCon";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SoLuongCon.DefaultCellStyle = dataGridViewCellStyle2;
            this.SoLuongCon.HeaderText = "Số lượng còn";
            this.SoLuongCon.Name = "SoLuongCon";
            // 
            // HanSuDung
            // 
            this.HanSuDung.DataPropertyName = "HanSuDung";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.HanSuDung.DefaultCellStyle = dataGridViewCellStyle3;
            this.HanSuDung.HeaderText = "Hạn sử dụng";
            this.HanSuDung.Name = "HanSuDung";
            // 
            // frmQuanLyKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 483);
            this.Controls.Add(this.dtpHanSuDung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuongCon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgvDanhSachKhuyenMai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaKhuyenMai);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnTim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khuyến mại";
            this.Load += new System.EventHandler(this.frmQuanLyKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachKhuyenMai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDanhSachKhuyenMai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaKhuyenMai;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.TextBox txtSoLuongCon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHanSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSuDung;
    }
}