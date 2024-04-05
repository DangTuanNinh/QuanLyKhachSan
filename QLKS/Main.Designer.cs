namespace QLKS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLP = new System.Windows.Forms.Button();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.lblQLKS = new System.Windows.Forms.Label();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangXuat,
            this.Thoat});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // DangXuat
            // 
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(170, 30);
            this.DangXuat.Text = "Đăng xuất";
            this.DangXuat.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // Thoat
            // 
            this.Thoat.Image = ((System.Drawing.Image)(resources.GetObject("Thoat.Image")));
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(170, 30);
            this.Thoat.Text = "Thoát";
            this.Thoat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýPhòngToolStripMenuItem,
            this.quảnLýDịchVụToolStripMenuItem,
            this.lậpHóaĐơnToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            this.danhMụcToolStripMenuItem.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýNhânViênToolStripMenuItem.Image")));
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý Nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            this.quảnLýPhòngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýPhòngToolStripMenuItem.Image")));
            this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            this.quảnLýPhòngToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.quảnLýPhòngToolStripMenuItem.Text = "Quản lý Phòng";
            // 
            // quảnLýDịchVụToolStripMenuItem
            // 
            this.quảnLýDịchVụToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýDịchVụToolStripMenuItem.Image")));
            this.quảnLýDịchVụToolStripMenuItem.Name = "quảnLýDịchVụToolStripMenuItem";
            this.quảnLýDịchVụToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.quảnLýDịchVụToolStripMenuItem.Text = "Quản lý thuê phòng";
            // 
            // lậpHóaĐơnToolStripMenuItem
            // 
            this.lậpHóaĐơnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lậpHóaĐơnToolStripMenuItem.Image")));
            this.lậpHóaĐơnToolStripMenuItem.Name = "lậpHóaĐơnToolStripMenuItem";
            this.lậpHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.lậpHóaĐơnToolStripMenuItem.Text = "Lập hóa đơn";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLNV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNV.Image")));
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLNV.Location = new System.Drawing.Point(185, 172);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(166, 132);
            this.btnQLNV.TabIndex = 2;
            this.btnQLNV.TabStop = false;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQLP
            // 
            this.btnQLP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLP.Image = ((System.Drawing.Image)(resources.GetObject("btnQLP.Image")));
            this.btnQLP.Location = new System.Drawing.Point(506, 172);
            this.btnQLP.Name = "btnQLP";
            this.btnQLP.Size = new System.Drawing.Size(166, 132);
            this.btnQLP.TabIndex = 4;
            this.btnQLP.TabStop = false;
            this.btnQLP.Text = "Quản lý phòng";
            this.btnQLP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLP.UseVisualStyleBackColor = true;
            this.btnQLP.Click += new System.EventHandler(this.btnQLP_Click);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLapHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnLapHoaDon.Image")));
            this.btnLapHoaDon.Location = new System.Drawing.Point(506, 378);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(166, 132);
            this.btnLapHoaDon.TabIndex = 5;
            this.btnLapHoaDon.TabStop = false;
            this.btnLapHoaDon.Text = "Lập hóa đơn";
            this.btnLapHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLapHoaDon.UseVisualStyleBackColor = true;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // lblQLKS
            // 
            this.lblQLKS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQLKS.AutoSize = true;
            this.lblQLKS.BackColor = System.Drawing.Color.Transparent;
            this.lblQLKS.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQLKS.ForeColor = System.Drawing.Color.LightCyan;
            this.lblQLKS.Location = new System.Drawing.Point(73, 66);
            this.lblQLKS.Name = "lblQLKS";
            this.lblQLKS.Size = new System.Drawing.Size(737, 52);
            this.lblQLKS.TabIndex = 8;
            this.lblQLKS.Text = "PHẦN MỀM QUẢN LÝ KHÁCH SẠN";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDatPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.Image")));
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDatPhong.Location = new System.Drawing.Point(185, 378);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(166, 132);
            this.btnDatPhong.TabIndex = 6;
            this.btnDatPhong.TabStop = false;
            this.btnDatPhong.Text = "Quản lý thuê phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 651);
            this.Controls.Add(this.lblQLKS);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.btnQLP);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangXuat;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnToolStripMenuItem;
        public System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLP;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Label lblQLKS;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.ToolStripMenuItem Thoat;
    }
}