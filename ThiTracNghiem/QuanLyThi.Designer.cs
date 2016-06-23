namespace ThiTracNghiem
{
  partial class QuanLyThi
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
      this.mnSinhVien = new System.Windows.Forms.ToolStripMenuItem();
      this.mnCauHoi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnThemCauHoi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnSuaCauHoi = new System.Windows.Forms.ToolStripMenuItem();
      this.mnXoaCauHoi = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSinhVien,
            this.mnCauHoi});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(631, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "Sinh Viên";
      // 
      // mnSinhVien
      // 
      this.mnSinhVien.Name = "mnSinhVien";
      this.mnSinhVien.Size = new System.Drawing.Size(68, 20);
      this.mnSinhVien.Text = "Sinh Viên";
      // 
      // mnCauHoi
      // 
      this.mnCauHoi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThemCauHoi,
            this.mnSuaCauHoi,
            this.mnXoaCauHoi});
      this.mnCauHoi.Name = "mnCauHoi";
      this.mnCauHoi.Size = new System.Drawing.Size(62, 20);
      this.mnCauHoi.Text = "Câu Hỏi";
      // 
      // mnThemCauHoi
      // 
      this.mnThemCauHoi.Name = "mnThemCauHoi";
      this.mnThemCauHoi.Size = new System.Drawing.Size(152, 22);
      this.mnThemCauHoi.Text = "Thêm Câu Hỏi";
      // 
      // mnSuaCauHoi
      // 
      this.mnSuaCauHoi.Name = "mnSuaCauHoi";
      this.mnSuaCauHoi.Size = new System.Drawing.Size(152, 22);
      this.mnSuaCauHoi.Text = "Sửa Câu Hỏi";
      // 
      // mnXoaCauHoi
      // 
      this.mnXoaCauHoi.Name = "mnXoaCauHoi";
      this.mnXoaCauHoi.Size = new System.Drawing.Size(152, 22);
      this.mnXoaCauHoi.Text = "Xóa Câu Hỏi";
      // 
      // QuanLyThi
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(631, 362);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "QuanLyThi";
      this.Text = "Quản Lý Thi";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnSinhVien;
    private System.Windows.Forms.ToolStripMenuItem mnCauHoi;
    private System.Windows.Forms.ToolStripMenuItem mnThemCauHoi;
    private System.Windows.Forms.ToolStripMenuItem mnSuaCauHoi;
    private System.Windows.Forms.ToolStripMenuItem mnXoaCauHoi;
  }
}