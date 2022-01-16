using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using Microsoft.Reporting.WinForms;

namespace GUI.NhanVien
{
    public partial class frmInHoaDonBan : Form
    {
        public string maHD;
        public int khachDua;
        public bool status;
        private String tenDangNhap;
        public frmInHoaDonBan(string _maHD, int _khachDua, bool _status, String tenDangNhap)
        {
            InitializeComponent();
            maHD = _maHD;
            khachDua = _khachDua;
            status = _status;
            this.tenDangNhap = tenDangNhap;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            /*Hide();
            new frmTaoHoaDonBan(tenDangNhap).ShowDialog();*/
            Close();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            rpvXemHoaDon.RefreshReport();

            HoaDon hd = HoaDonBLL.Instance.LayHoaDonTheoMa(maHD);
            List<ChiTietHoaDonDTO> cthd = HoaDonBLL.Instance.LayChiTietHoaDon(maHD, status);

            //this.rpvXemHoaDon.LocalReport.ReportPath = "D:/MONHOC/WINDOWS/BTL/BTL_Windows-dang/QuanLyBanQuanAo/GUI/NhanVien/rptInHoaDonBan.rdlc";

            ReportDataSource reportDataSource = new ReportDataSource("DataSetHoaDon", cthd);
            List<ReportParameter> param = new List<ReportParameter>()
            {
                new ReportParameter("maHD",hd.MaHoaDon),
                new ReportParameter("thoiGian",hd.ThoiGian.ToString()),
                new ReportParameter("maNV","NV002"),
                new ReportParameter("tongTien",string.Format("{0:#,### ₫}", hd.TongTien)),
                new ReportParameter("khachDua",string.Format("{0:#,### ₫}", khachDua)),
                new ReportParameter("tienThua",string.Format("{0:#,### ₫}", khachDua - hd.TongTien)),
            };

            if(hd.GiamGia != 0)
            {
                param.Add(new ReportParameter("khuyenMai", string.Format("{0:#,### ₫}", hd.GiamGia)));
            }
            else
            {
                param.Add(new ReportParameter("khuyenMai", "0 ₫"));
            }

            if (status)
            {
                param.Add(new ReportParameter("status", "true"));
            }

            rpvXemHoaDon.LocalReport.DataSources.Clear();
            rpvXemHoaDon.LocalReport.SetParameters(param);
            rpvXemHoaDon.LocalReport.DataSources.Add(reportDataSource);
            rpvXemHoaDon.RefreshReport();
        }
    }
}
