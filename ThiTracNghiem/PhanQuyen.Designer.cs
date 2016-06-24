namespace ThiTracNghiem
{
  partial class frmPhanQuyen
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
      this.mnBatDauThi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnQuanLyThi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnDeThi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnCauHoi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnTaoDeThi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnSuaXoaDeThi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnTaoCauHoi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnSuaXoaCauHoi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnXemDiemThi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
      this.mnTroGiup = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
      this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBatDauThi,
            this.mnQuanLyThi,
            this.mnXemDiemThi,
            this.mnDangXuat,
            this.mnTroGiup});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(639, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "mntMenu";
      // 
      // mnBatDauThi
      // 
      this.mnBatDauThi.Name = "mnBatDauThi";
      this.mnBatDauThi.Size = new System.Drawing.Size(76, 20);
      this.mnBatDauThi.Text = "Bắt đầu thi";
      // 
      // mnQuanLyThi
      // 
      this.mnQuanLyThi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDeThi,
            this.mnCauHoi});
      this.mnQuanLyThi.Name = "mnQuanLyThi";
      this.mnQuanLyThi.Size = new System.Drawing.Size(83, 20);
      this.mnQuanLyThi.Text = "Quản Lý Thi";
      // 
      // mnDeThi
      // 
      this.mnDeThi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTaoDeThi,
            this.mnSuaXoaDeThi});
      this.mnDeThi.Name = "mnDeThi";
      this.mnDeThi.Size = new System.Drawing.Size(152, 22);
      this.mnDeThi.Text = "Đề Thi";
      // 
      // mnCauHoi
      // 
      this.mnCauHoi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTaoCauHoi,
            this.mnSuaXoaCauHoi});
      this.mnCauHoi.Name = "mnCauHoi";
      this.mnCauHoi.Size = new System.Drawing.Size(152, 22);
      this.mnCauHoi.Text = "Câu Hỏi";
      // 
      // mnTaoDeThi
      // 
      this.mnTaoDeThi.Name = "mnTaoDeThi";
      this.mnTaoDeThi.Size = new System.Drawing.Size(155, 22);
      this.mnTaoDeThi.Text = "Tạo Đề Thi";
      // 
      // mnSuaXoaDeThi
      // 
      this.mnSuaXoaDeThi.Name = "mnSuaXoaDeThi";
      this.mnSuaXoaDeThi.Size = new System.Drawing.Size(155, 22);
      this.mnSuaXoaDeThi.Text = "Sửa/Xóa Đề Thi";
      // 
      // mnTaoCauHoi
      // 
      this.mnTaoCauHoi.Name = "mnTaoCauHoi";
      this.mnTaoCauHoi.Size = new System.Drawing.Size(152, 22);
      this.mnTaoCauHoi.Text = "Tạo Câu Hỏi";
      // 
      // mnSuaXoaCauHoi
      // 
      this.mnSuaXoaCauHoi.Name = "mnSuaXoaCauHoi";
      this.mnSuaXoaCauHoi.Size = new System.Drawing.Size(164, 22);
      this.mnSuaXoaCauHoi.Text = "Sửa/Xóa Câu Hỏi";
      // 
      // mnXemDiemThi
      // 
      this.mnXemDiemThi.Name = "mnXemDiemThi";
      this.mnXemDiemThi.Size = new System.Drawing.Size(94, 20);
      this.mnXemDiemThi.Text = "Xem Điểm Thi";
      // 
      // mnDangXuat
      // 
      this.mnDangXuat.Name = "mnDangXuat";
      this.mnDangXuat.Size = new System.Drawing.Size(74, 20);
      this.mnDangXuat.Text = "Đăng Xuất";
      // 
      // mnTroGiup
      // 
      this.mnTroGiup.Name = "mnTroGiup";
      this.mnTroGiup.Size = new System.Drawing.Size(65, 20);
      this.mnTroGiup.Text = "Trợ Giúp";
      // 
      // frmPhanQuyen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.ClientSize = new System.Drawing.Size(639, 293);
      this.Controls.Add(this.menuStrip1);
      this.Name = "frmPhanQuyen";
      this.Text = "Phần mềm Thi trắc nghiệm cho sinh viên";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnBatDauThi;
    private System.Windows.Forms.ToolStripMenuItem mnQuanLyThi;
    private System.Windows.Forms.ToolStripMenuItem mnDeThi;
    private System.Windows.Forms.ToolStripMenuItem mnCauHoi;
    private System.Windows.Forms.ToolStripMenuItem mnTaoDeThi;
    private System.Windows.Forms.ToolStripMenuItem mnSuaXoaDeThi;
    private System.Windows.Forms.ToolStripMenuItem mnTaoCauHoi;
    private System.Windows.Forms.ToolStripMenuItem mnSuaXoaCauHoi;
    private System.Windows.Forms.ToolStripMenuItem mnXemDiemThi;
    private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
    private System.Windows.Forms.ToolStripMenuItem mnTroGiup;
  }
}