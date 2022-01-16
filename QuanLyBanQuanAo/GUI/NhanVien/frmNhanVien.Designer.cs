
namespace GUI
{
    partial class frmNhanVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XemThongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaoHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửTạoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XemThongTinToolStripMenuItem,
            this.DangXuatToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // XemThongTinToolStripMenuItem
            // 
            this.XemThongTinToolStripMenuItem.Name = "XemThongTinToolStripMenuItem";
            this.XemThongTinToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.XemThongTinToolStripMenuItem.Text = "Xem thông tin";
            this.XemThongTinToolStripMenuItem.Click += new System.EventHandler(this.XemThongTinToolStripMenuItem_Click);
            // 
            // DangXuatToolStripMenuItem
            // 
            this.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            this.DangXuatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.DangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.DangXuatToolStripMenuItem.Click += new System.EventHandler(this.DangXuatToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaoHoaDonToolStripMenuItem,
            this.lịchSửTạoToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.chứcNăngToolStripMenuItem.Text = "Hóa đơn";
            // 
            // TaoHoaDonToolStripMenuItem
            // 
            this.TaoHoaDonToolStripMenuItem.Name = "TaoHoaDonToolStripMenuItem";
            this.TaoHoaDonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TaoHoaDonToolStripMenuItem.Text = "Tạo hóa đơn";
            this.TaoHoaDonToolStripMenuItem.Click += new System.EventHandler(this.TaoHoaDonToolStripMenuItem_Click);
            // 
            // lịchSửTạoToolStripMenuItem
            // 
            this.lịchSửTạoToolStripMenuItem.Name = "lịchSửTạoToolStripMenuItem";
            this.lịchSửTạoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lịchSửTạoToolStripMenuItem.Text = "Lịch sử tạo";
            this.lịchSửTạoToolStripMenuItem.Click += new System.EventHandler(this.lịchSửTạoToolStripMenuItem_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XemThongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaoHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửTạoToolStripMenuItem;
    }
}