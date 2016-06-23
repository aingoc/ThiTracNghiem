namespace ThiTracNghiem
{
  partial class DangNhap
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
      this.lbTenDangNhap = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtTenDangNhap = new System.Windows.Forms.TextBox();
      this.txtMatKhau = new System.Windows.Forms.TextBox();
      this.btnDangNhap = new System.Windows.Forms.Button();
      this.lbDangKy = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // lbTenDangNhap
      // 
      this.lbTenDangNhap.AutoSize = true;
      this.lbTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbTenDangNhap.Location = new System.Drawing.Point(30, 48);
      this.lbTenDangNhap.Name = "lbTenDangNhap";
      this.lbTenDangNhap.Size = new System.Drawing.Size(106, 19);
      this.lbTenDangNhap.TabIndex = 0;
      this.lbTenDangNhap.Text = "Tên Đăng Nhập";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(30, 98);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 19);
      this.label1.TabIndex = 1;
      this.label1.Text = "Mật Khẩu";
      // 
      // txtTenDangNhap
      // 
      this.txtTenDangNhap.Location = new System.Drawing.Point(170, 48);
      this.txtTenDangNhap.Name = "txtTenDangNhap";
      this.txtTenDangNhap.Size = new System.Drawing.Size(162, 20);
      this.txtTenDangNhap.TabIndex = 2;
      // 
      // txtMatKhau
      // 
      this.txtMatKhau.Location = new System.Drawing.Point(170, 99);
      this.txtMatKhau.Name = "txtMatKhau";
      this.txtMatKhau.Size = new System.Drawing.Size(162, 20);
      this.txtMatKhau.TabIndex = 3;
      // 
      // btnDangNhap
      // 
      this.btnDangNhap.BackColor = System.Drawing.Color.DodgerBlue;
      this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnDangNhap.Location = new System.Drawing.Point(194, 149);
      this.btnDangNhap.Name = "btnDangNhap";
      this.btnDangNhap.Size = new System.Drawing.Size(99, 36);
      this.btnDangNhap.TabIndex = 4;
      this.btnDangNhap.Text = "Đăng Nhập";
      this.btnDangNhap.UseVisualStyleBackColor = false;
      // 
      // lbDangKy
      // 
      this.lbDangKy.ActiveLinkColor = System.Drawing.Color.Blue;
      this.lbDangKy.AutoSize = true;
      this.lbDangKy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbDangKy.Location = new System.Drawing.Point(214, 188);
      this.lbDangKy.Name = "lbDangKy";
      this.lbDangKy.Size = new System.Drawing.Size(55, 15);
      this.lbDangKy.TabIndex = 5;
      this.lbDangKy.TabStop = true;
      this.lbDangKy.Text = "Đăng Ký";
      // 
      // DangNhap
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.ClientSize = new System.Drawing.Size(478, 265);
      this.Controls.Add(this.lbDangKy);
      this.Controls.Add(this.btnDangNhap);
      this.Controls.Add(this.txtMatKhau);
      this.Controls.Add(this.txtTenDangNhap);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lbTenDangNhap);
      this.Name = "DangNhap";
      this.Text = "Đăng Nhập - Phần mềm thi trắc nghiệm";
      this.Load += new System.EventHandler(this.DangNhap_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbTenDangNhap;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtTenDangNhap;
    private System.Windows.Forms.TextBox txtMatKhau;
    private System.Windows.Forms.Button btnDangNhap;
    private System.Windows.Forms.LinkLabel lbDangKy;
  }
}

