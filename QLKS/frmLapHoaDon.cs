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
    public partial class frmLapHoaDon : Form
    {
        public frmLapHoaDon()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        public void getData()
        {
            string query = " select * from HoaDon";
            DataSet ds = kn.LayDuLieu(query);
            dgvLapHD.DataSource = ds.Tables[0];
        }

        public void getMaNV()
        {
            string query = "select * from NhanVien";
            DataSet ds = kn.LayDuLieu(query);
            cmbMaNV.DataSource = ds.Tables[0];
            cmbMaNV.DisplayMember = "MaNV";
            cmbMaNV.ValueMember = "MaNV";
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            getData();
            getMaNV();
        }
        public void ThanhTien()
        {
            string query = "UPDATE HoaDon SET ThanhTien = GiaPhong * DATEDIFF(DAY, NgayDatPhong, NgayTraPhong)";
            kn.ThucThi(query);

            string MaHD = txtMaHD.Text;
            // Lấy giá trị mới của Thành Tiền từ cơ sở dữ liệu
            string queryLayThanhTien = "SELECT ThanhTien FROM HoaDon WHERE MaHD = '"+MaHD+"'";
            DataSet dt = kn.LayDuLieu(queryLayThanhTien);
            txtThanhTien.Text = dt.Tables[0].Rows[0]["ThanhTien"].ToString();
        }

        private void dgvLapHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaHD.Text = dgvLapHD.Rows[r].Cells["MaHD"].Value.ToString();
                cmbMaNV.Text = dgvLapHD.Rows[r].Cells["MaNV"].Value.ToString();
                txtMaDP.Text = dgvLapHD.Rows[r].Cells["MaDP"].Value.ToString();
                txtTenKH.Text = dgvLapHD.Rows[r].Cells["TenKH"].Value.ToString(); ;
                txtMaPhong.Text = dgvLapHD.Rows[r].Cells["MaPhong"].Value.ToString();
                txtGiaPhong.Text = dgvLapHD.Rows[r].Cells["GiaPhong"].Value.ToString();
                dtpNgayDatPhong.Text = dgvLapHD.Rows[r].Cells["NgayDatPhong"].Value.ToString();
                dtpNgayTraPhong.Text = dgvLapHD.Rows[r].Cells["NgayTraPhong"].Value.ToString();
                txtThanhTien.Text = dgvLapHD.Rows[r].Cells["ThanhTien"].Value.ToString();

                ThanhTien();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy tháng từ NgayTraPhong
            int thang = dtpNgayTraPhong.Value.Month;

            // Lấy mã nhân viên từ ComboBox
            string maNV = cmbMaNV.SelectedValue.ToString();
            // Lưu mã nhân viên vào cơ sở dữ liệu
            LuuMaNhanVienVaoCSDL(maNV);

            string maHD = txtMaHD.Text;
            maNV = cmbMaNV.SelectedValue.ToString();
            string maDatPhong = txtMaDP.Text;
            string tenKhachHang = txtTenKH.Text;
            string maPhong = txtMaPhong.Text;
            string giaPhong = txtGiaPhong.Text;
            string ngayDatPhong = dtpNgayDatPhong.Value.ToString("dd/MM/yyyy");
            string ngayTraPhong = dtpNgayTraPhong.Value.ToString("dd/MM/yyyy");
            string thanhTien = txtThanhTien.Text;

            // Kiểm tra xem ThanhTien đã được tính toán chưa
            if (string.IsNullOrEmpty(thanhTien))
            {
                // Nếu chưa tính toán, thực hiện tính và lưu vào CSDL
                ThanhTien();

                // Lấy lại giá trị ThanhTien sau khi tính toán
                thanhTien = txtThanhTien.Text;
            }

            // Tiếp tục với các hành động khác (hiển thị hoặc lưu thông tin)
            CapNhatThongKe(thang, thanhTien);

            frmInHoaDon formInHoaDon = new frmInHoaDon
            {
                MaHoaDon = maHD,
                MaNhanVien = maNV,
                MaDatPhong = maDatPhong,
                TenKhachHang = tenKhachHang,
                MaPhong = maPhong,
                GiaPhong = giaPhong,
                NgayDatPhong = ngayDatPhong,
                NgayTraPhong = ngayTraPhong,
                ThanhTien = thanhTien
            };
            formInHoaDon.Show();
        }

        private void LuuMaNhanVienVaoCSDL(string maNV)
        {
                string query = string.Format("UPDATE HoaDon SET MaNV = N'{1}' where MaHD = '{0}' ",
                txtMaHD.Text,
                cmbMaNV.Text
                );
                kn.ThucThi(query);
                getData();

        }

        private void CapNhatThongKe(int thang, string thanhTien)
        {
            // Chuyển đổi thanhTien sang kiểu float
            float doanhThu = float.Parse(thanhTien);

            // Lấy thông tin doanh thu từ bảng ThongKe
            string queryThongKe = String.Format("SELECT * FROM ThongKe WHERE Thang = {0}", thang);

            DataTable dtThongKe = kn.LayDuLieu(queryThongKe).Tables[0];

            // Nếu có dữ liệu cho tháng đó, cập nhật DoanhThu
            if (dtThongKe.Rows.Count > 0)
            {
                string queryUpdateThongKe = String.Format("UPDATE ThongKe SET DoanhThu = DoanhThu + {0} WHERE Thang = {1}", doanhThu, thang);
                kn.ThucThi(queryUpdateThongKe);
                Console.WriteLine("Updated Thang {0} with DoanhThu {1}", thang, doanhThu);
            }
            else
            {
                // Nếu không có dữ liệu cho tháng đó, thêm mới vào bảng ThongKe
                string queryInsertThongKe = String.Format("INSERT INTO ThongKe (Thang, DoanhThu) VALUES ({0}, {1})", thang, doanhThu);
                kn.ThucThi(queryInsertThongKe);
                Console.WriteLine("Inserted Thang {0} with DoanhThu {1}", thang, doanhThu);
            }
        }

        private void frmLapHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Form con đang đóng bởi người dùng (ấn nút "X"), thực hiện xử lý ở đây
                // Ví dụ: hiển thị lại các nút button trên form cha
                frmMain mainForm = this.MdiParent as frmMain;
                if (mainForm != null)
                {
                    mainForm.ShowButtons(); // Tự định nghĩa phương thức ShowButtons trên MainForm để hiển thị các nút
                }
            }
        }
    }
}
