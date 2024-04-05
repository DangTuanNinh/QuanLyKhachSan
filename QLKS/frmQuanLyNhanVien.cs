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
    public partial class frmQLNV : Form
    {
        
        public frmQLNV()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        public void clearText()
        {
            txtMaNV.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaNV.Text = "";
            txtTenNV.Text = "";
            mskNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtSoDienThoai.Text = "";
        }

        public void getData()
        {
            string query = " select * from NhanVien";
            DataSet ds = kn.LayDuLieu(query);
            dgvQLNV.DataSource = ds.Tables[0];
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                            "insert into NhanVien values(N'{0}',N'{1}','{2}',N'{3}',N'{4}')",
                            txtMaNV.Text,
                            txtTenNV.Text,
                            mskNgaySinh.Text,
                            txtGioiTinh.Text,
                            txtSoDienThoai.Text
                            );

            bool kt = kn.ThucThi(query);
            if (kt == true)
            {
                MessageBox.Show("Thêm thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "update NhanVien set TenNV = N'{1}',NgaySinh = '{2}',GioiTinh = N'{3}' , SĐT = N'{4}' where MaNV = N'{0}'",
                txtMaNV.Text,
                txtTenNV.Text,
                mskNgaySinh.Text,
                txtGioiTinh.Text,
                txtSoDienThoai.Text
                );
            bool kt = kn.ThucThi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaNV.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                txtMaNV.Text = dgvQLNV.Rows[r].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgvQLNV.Rows[r].Cells["TenNV"].Value.ToString();
                object ngaySinhValue = dgvQLNV.Rows[r].Cells["NgaySinh"].Value;

                // Gán giá trị vào MaskedTextBox
                mskNgaySinh.Text = (ngaySinhValue != DBNull.Value)? DateTime.Parse(ngaySinhValue.ToString()).ToString("dd/MM/yyyy"): "";
                txtGioiTinh.Text = dgvQLNV.Rows[r].Cells["GioiTinh"].Value.ToString();
                txtSoDienThoai.Text = dgvQLNV.Rows[r].Cells["SĐT"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from NhanVien where TenNV like N'%{0}%'",
                txtTenNV.Text
                );
            DataSet ds = kn.LayDuLieu(query);
            dgvQLNV.DataSource = ds.Tables[0];
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete from NhanVien where MaNV = '{0}'",
                txtMaNV.Text,
                txtTenNV.Text,
                mskNgaySinh.Text,
                txtGioiTinh.Text,
                txtSoDienThoai.Text
                );
            bool kt = kn.ThucThi(query);
            if (kt == true)
            {
                MessageBox.Show("Xóa thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void mskNgaySinh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
