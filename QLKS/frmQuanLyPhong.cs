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
    public partial class frmQLP : Form
    {
        public frmQLP()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        public void clearText()
        {
            txtMaPhong.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaPhong.Text = "";
            txtSoPhong.Text = "";
            txtTinhTrangPhong.Text = "";
            txtGiaPhong.Text = "";
        }

        public void getData()
        {
            string query = " select * from Phong";
            DataSet ds = kn.LayDuLieu(query);
            dgvQLP.DataSource = ds.Tables[0];
        }

        private void frmQLP_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void frmQLP_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                            "insert into Phong values(N'{0}',N'{1}',N'{2}',N'{3}')",
                            txtMaPhong.Text,
                            txtSoPhong.Text,
                            txtTinhTrangPhong.Text,
                            txtGiaPhong.Text
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
                "update Phong set SoPhong = N'{1}',TinhTrangPhong = N'{2}',GiaPhong = N'{3}' where MaPhong = N'{0}'",
                txtMaPhong.Text,
                txtSoPhong.Text,
                txtTinhTrangPhong.Text,
                txtGiaPhong.Text
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete from Phong where MaPhong = '{0}'",
                txtMaPhong.Text,
                txtSoPhong.Text,
                txtTinhTrangPhong.Text,
                txtGiaPhong.Text
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from Phong where SoPhong like N'%{0}%'",
                txtSoPhong.Text
                );
            DataSet ds = kn.LayDuLieu(query);
            dgvQLP.DataSource = ds.Tables[0];
        }

        private void dgvQLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaPhong.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                txtMaPhong.Text = dgvQLP.Rows[r].Cells["MaPhong"].Value.ToString();
                txtSoPhong.Text = dgvQLP.Rows[r].Cells["SoPhong"].Value.ToString();
                txtTinhTrangPhong.Text = dgvQLP.Rows[r].Cells["TinhTrangPhong"].Value.ToString();
                txtGiaPhong.Text = dgvQLP.Rows[r].Cells["GiaPhong"].Value.ToString();
            }
        }

        private void dgvQLP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}