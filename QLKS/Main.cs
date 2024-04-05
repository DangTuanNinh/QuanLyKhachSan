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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void ShowButtons()
        {
            lblQLKS.Visible = true;
            btnQLNV.Visible = true;
            btnQLP.Visible = true;
            btnDatPhong.Visible = true;
            btnLapHoaDon.Visible = true;
        }

        public void HideButtons()
        {
            lblQLKS.Visible = false;
            btnQLNV.Visible = false;
            btnQLP.Visible = false;
            btnDatPhong.Visible = false;
            btnLapHoaDon.Visible = false;
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTimKiem frm = new btnTimKiem();
            frm.MdiParent = this;
            frm.Show();
            HideButtons();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            frmQLNV frm = new frmQLNV();
            frm.MdiParent = this;
            frm.Show();
            HideButtons();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            frmQLTP frm = new frmQLTP();
            frm.MdiParent = this;
            frm.Show();
            HideButtons();
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            frmQLP frm = new frmQLP();
            frm.MdiParent = this;
            frm.Show();
            HideButtons();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            frmLapHoaDon frm = new frmLapHoaDon();
            frm.MdiParent = this;
            frm.Show();
            HideButtons();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhapForm = new DangNhap();
            dangNhapForm.Show();

            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

    }
}
