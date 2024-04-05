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
    public partial class frmQLTP : Form
    {
        public frmQLTP()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        public void getData()
        {
            string query = " select * from DatPhong";
            DataSet ds = kn.LayDuLieu(query);
            dgvQLTP.DataSource = ds.Tables[0];
        }

        public void clearText()
        {
            txtMaDP.Enabled = true;
            btnDatPhong.Enabled = true;
            btnSua.Enabled = false;
            btnTraPhong.Enabled = false;

            txtMaDP.Text = "";
            txtTenKH.Text = "";
            txtCCCD.Text = "";
            cmbMaPhong.Text = "";
            txtGiaPhong.Text = "";
            dtpNgayDatPhong.Value = DateTime.Today;
            dtpNgayTraPhong.Value = DateTime.Today;
            txtTrangThai.Text = "";
        }

        public void getSoPhong()
        {
            string query = "select * from Phong";
            DataSet ds = kn.LayDuLieu(query);
            cmbMaPhong.DataSource = ds.Tables[0];
            cmbMaPhong.DisplayMember = "MaPhong";
            cmbMaPhong.ValueMember = "MaPhong";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from DatPhong where TenKH like N'%{0}%'",
                txtTenKH.Text
                );
            DataSet ds = kn.LayDuLieu(query);
            dgvQLTP.DataSource = ds.Tables[0];
            
        }

        private void frmDatPhong_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            getData();
            getSoPhong();
        }

        private void dgvQLTP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaDP.Enabled = false;
                btnDatPhong.Enabled = false;
                btnSua.Enabled = true;
                btnTraPhong.Enabled = true;

                txtMaDP.Text = dgvQLTP.Rows[r].Cells["MaDP"].Value.ToString();
                txtTenKH.Text = dgvQLTP.Rows[r].Cells["TenKH"].Value.ToString();
                txtCCCD.Text = dgvQLTP.Rows[r].Cells["CCCD"].Value.ToString();
                cmbMaPhong.Text = dgvQLTP.Rows[r].Cells["MaPhong"].Value.ToString(); ;
                txtGiaPhong.Text = dgvQLTP.Rows[r].Cells["GiaPhong"].Value.ToString();
                dtpNgayDatPhong.Text = dgvQLTP.Rows[r].Cells["NgayDatPhong"].Value.ToString();
                dtpNgayTraPhong.Text = dgvQLTP.Rows[r].Cells["NgayTraPhong"].Value.ToString();
                txtTrangThai.Text = dgvQLTP.Rows[r].Cells["TrangThai"].Value.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "update DatPhong set TenKH = N'{1}',CCCD = N'{2}',MaPhong = N'{3}',GiaPhong = N'{4}' , NgayDatPhong = '{5:yyyy-MM-dd}',NgayTraPhong = '{6:yyyy-MM-dd}', TrangThai = N'{7}' where MaDP = '{0}'",
                txtMaDP.Text,
                txtTenKH.Text,
                txtCCCD.Text,
                cmbMaPhong.Text,
                txtGiaPhong.Text,
                dtpNgayDatPhong.Value,
                dtpNgayTraPhong.Value,
                txtTrangThai.Text
                );
            bool kt = kn.ThucThi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công!");
                btnLamMoi.PerformClick();
                btnSua.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void cmbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaPhong = cmbMaPhong.SelectedValue.ToString(); // Lấy giá trị đã chọn trong cmbMaPhong

            // Tạo truy vấn SQL để lấy giá phòng tương ứng
            string sql = "SELECT GiaPhong FROM Phong WHERE MaPhong = '" + selectedMaPhong + "'";

            DataSet ds = kn.LayDuLieu(sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txtGiaPhong.Text = ds.Tables[0].Rows[0]["GiaPhong"].ToString();
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into DatPhong values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5:yyyy-MM-dd}', '{6:yyyy-MM-dd}','{7}')",
                txtMaDP.Text,
                txtTenKH.Text,
                txtCCCD.Text,
                cmbMaPhong.Text,
                txtGiaPhong.Text,
                dtpNgayDatPhong.Value,
                dtpNgayTraPhong.Value,
                txtTrangThai.Text
                            );

            bool kt = kn.ThucThi(query);
            if (kt == true)
            {
                MessageBox.Show("Thêm thành công!");
                btnLamMoi.PerformClick();
                btnTraPhong.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void dgvQLTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDP.Text))
            {
                MessageBox.Show("Vui lòng chọn một dòng từ DataGridView trước khi thực hiện trả phòng.");
                return;
            }

            // Lấy MaDP của dòng đã chọn
            string maDatPhong = txtMaDP.Text;

            // Thực hiện câu lệnh INSERT để chuyển dữ liệu từ bảng "DatPhong" sang bảng "HoaDon"
            string insertQuery = string.Format(
                "INSERT INTO HoaDon (MaDP, TenKH, MaPhong, GiaPhong, NgayDatPhong, NgayTraPhong) " +
                "SELECT MaDP, TenKH, MaPhong, GiaPhong, NgayDatPhong, NgayTraPhong FROM DatPhong" +
                " WHERE MaDP = '{0}'", maDatPhong
            );

            bool insertSuccess = kn.ThucThi(insertQuery);

            if (insertSuccess)
            {
                // Cập nhật trạng thái trong bảng DatPhong thành "Đã trả"
                string updateQuery = string.Format(
                    "UPDATE DatPhong SET TrangThai = N'Đã trả' WHERE MaDP = '{0}'", maDatPhong
                );

                bool updateSuccess = kn.ThucThi(updateQuery);

                if (updateSuccess)
                {
                    MessageBox.Show("Trả phòng thành công!");
                    btnLamMoi.PerformClick(); // Làm mới DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Gửi dữ liệu sang bảng HoaDon thất bại!");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDP.Text))
            {
                MessageBox.Show("Vui lòng chọn một dòng từ DataGridView trước khi thực hiện xóa.");
                return;
            }

            // Lấy MaDP của dòng đã chọn
            string maDatPhong = txtMaDP.Text;

            // Thực hiện xóa dữ liệu từ bảng "HoaDon"
            string deleteHoaDonQuery = string.Format("DELETE FROM HoaDon WHERE MaDP = '{0}'", maDatPhong);
            kn.ThucThi(deleteHoaDonQuery); // Xóa dữ liệu từ bảng HoaDon mà không quan tâm đến kết quả

            // Thực hiện xóa dữ liệu từ bảng "DatPhong"
            string deleteDatPhongQuery = string.Format("DELETE FROM DatPhong WHERE MaDP = '{0}'", maDatPhong);
            bool deleteDatPhongSuccess = kn.ThucThi(deleteDatPhongQuery);

            if (deleteDatPhongSuccess)
            {
                MessageBox.Show("Xóa thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa từ bảng DatPhong thất bại!");
            }
        }
    }
}
