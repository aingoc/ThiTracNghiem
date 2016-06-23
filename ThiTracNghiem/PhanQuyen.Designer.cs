namespace ThiTracNghiem
{
  partial class PhanQuyen
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
      this.button1 = new System.Windows.Forms.Button();
      this.btnQuanLyThi = new System.Windows.Forms.Button();
      this.btnXemDiemThi = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
      this.mnTroGiup = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(0, 27);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(220, 47);
      this.button1.TabIndex = 0;
      this.button1.Text = "BẮT ĐẦU THI";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // btnQuanLyThi
      // 
      this.btnQuanLyThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQuanLyThi.Location = new System.Drawing.Point(219, 27);
      this.btnQuanLyThi.Name = "btnQuanLyThi";
      this.btnQuanLyThi.Size = new System.Drawing.Size(215, 47);
      this.btnQuanLyThi.TabIndex = 1;
      this.btnQuanLyThi.Text = "QUẢN LÝ THI";
      this.btnQuanLyThi.UseVisualStyleBackColor = true;
      // 
      // btnXemDiemThi
      // 
      this.btnXemDiemThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnXemDiemThi.Location = new System.Drawing.Point(431, 27);
      this.btnXemDiemThi.Name = "btnXemDiemThi";
      this.btnXemDiemThi.Size = new System.Drawing.Size(208, 47);
      this.btnXemDiemThi.TabIndex = 2;
      this.btnXemDiemThi.Text = "XEM ĐIỂM THI";
      this.btnXemDiemThi.UseVisualStyleBackColor = true;
      // 
      // menuStrip1
      // 
      this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDangXuat,
            this.mnTroGiup});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(639, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "mntMenu";
      // 
      // mnDangXuat
      // 
      this.mnDangXuat.Name = "mnDangXuat";
      this.mnDangXuat.Size = new System.Drawing.Size(72, 20);
      this.mnDangXuat.Text = "Đăng xuất";
      // 
      // mnTroGiup
      // 
      this.mnTroGiup.Name = "mnTroGiup";
      this.mnTroGiup.Size = new System.Drawing.Size(65, 20);
      this.mnTroGiup.Text = "Trợ Giúp";
      // 
      // PhanQuyen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.ClientSize = new System.Drawing.Size(639, 293);
      this.Controls.Add(this.btnXemDiemThi);
      this.Controls.Add(this.btnQuanLyThi);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.menuStrip1);
      this.Name = "PhanQuyen";
      this.Text = "Quản Lý";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnQuanLyThi;
    private System.Windows.Forms.Button btnXemDiemThi;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
    private System.Windows.Forms.ToolStripMenuItem mnTroGiup;
  }
}