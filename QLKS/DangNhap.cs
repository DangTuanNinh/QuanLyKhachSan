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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        // khởi tạo form Đăng nhập
        KetNoi kn = new KetNoi();

        private void button1_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from NguoiDung where TaiKhoan = '{0}' and MatKhau ='{1}'",
                txtTaiKhoan.Text,
                txtMatKhau.Text
            );
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                if (txtTaiKhoan.Text.Trim().ToLower() != "admin")
                {
                    // Disable the btnQLNV button in the main form
                    frmMain frm = new frmMain();
                    frm.btnQLNV.Enabled = false;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    // For other users, enable the btnQLNV button
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
