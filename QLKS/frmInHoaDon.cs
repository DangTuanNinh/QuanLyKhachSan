using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        public string MaHoaDon{ get; set; }
        public string MaNhanVien { get; set; }
        public string MaDatPhong { get; set; }
        public string TenKhachHang { get; set; }
        public string MaPhong { get; set; }
        public string GiaPhong { get; set; }
        public string NgayDatPhong { get; set; }
        public string NgayTraPhong { get; set; }
        public string ThanhTien { get; set; }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = MaHoaDon;
            txtMaNV.Text = MaNhanVien;
            txtMaDP.Text = MaDatPhong;
            txtTenKH.Text = TenKhachHang;
            txtMaPhong.Text = MaPhong;
            txtGiaPhong.Text = GiaPhong;
            txtNgayDatPhong.Text = NgayDatPhong;
            txtNgayTraPhong.Text = NgayTraPhong;
            txtThanhToan.Text = ThanhTien;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayDatPhong_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayTraPhong_Click(object sender, EventArgs e)
        {

        }

    }
}
