namespace ThiTracNghiem
{
  partial class frmDangKy
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.txtHoTen = new System.Windows.Forms.TextBox();
      this.txtMSSV = new System.Windows.Forms.TextBox();
      this.txtNgaySinh = new System.Windows.Forms.TextBox();
      this.txtLop = new System.Windows.Forms.TextBox();
      this.txtTruong = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.txtTenDangNhap = new System.Windows.Forms.TextBox();
      this.txtMatKhau = new System.Windows.Forms.TextBox();
      this.btnDangKy = new System.Windows.Forms.Button();
      this.btnQuayLai = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(79, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(227, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "Đăng Ký Thi Trắc Nghiệm";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(31, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 19);
      this.label2.TabIndex = 1;
      this.label2.Text = "Họ Tên:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(32, 84);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 19);
      this.label3.TabIndex = 2;
      this.label3.Text = "MSSV";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(32, 124);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(72, 19);
      this.label4.TabIndex = 3;
      this.label4.Text = "Ngày Sinh";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(32, 165);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 19);
      this.label5.TabIndex = 4;
      this.label5.Text = "Trường";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(32, 209);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(34, 19);
      this.label6.TabIndex = 5;
      this.label6.Text = "Lớp";
      this.label6.Click += new System.EventHandler(this.label6_Click);
      // 
      // txtHoTen
      // 
      this.txtHoTen.Location = new System.Drawing.Point(163, 44);
      this.txtHoTen.Name = "txtHoTen";
      this.txtHoTen.Size = new System.Drawing.Size(170, 20);
      this.txtHoTen.TabIndex = 6;
      // 
      // txtMSSV
      // 
      this.txtMSSV.Location = new System.Drawing.Point(163, 85);
      this.txtMSSV.Name = "txtMSSV";
      this.txtMSSV.Size = new System.Drawing.Size(170, 20);
      this.txtMSSV.TabIndex = 7;
      // 
      // txtNgaySinh
      // 
      this.txtNgaySinh.Location = new System.Drawing.Point(163, 125);
      this.txtNgaySinh.Name = "txtNgaySinh";
      this.txtNgaySinh.Size = new System.Drawing.Size(170, 20);
      this.txtNgaySinh.TabIndex = 8;
      // 
      // txtLop
      // 
      this.txtLop.Location = new System.Drawing.Point(163, 208);
      this.txtLop.Name = "txtLop";
      this.txtLop.Size = new System.Drawing.Size(170, 20);
      this.txtLop.TabIndex = 9;
      // 
      // txtTruong
      // 
      this.txtTruong.Location = new System.Drawing.Point(163, 166);
      this.txtTruong.Name = "txtTruong";
      this.txtTruong.Size = new System.Drawing.Size(170, 20);
      this.txtTruong.TabIndex = 10;
      this.txtTruong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(31, 254);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(106, 19);
      this.label7.TabIndex = 11;
      this.label7.Text = "Tên Đăng Nhập";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(31, 300);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(71, 19);
      this.label8.TabIndex = 12;
      this.label8.Text = "Mật Khẩu";
      // 
      // txtTenDangNhap
      // 
      this.txtTenDangNhap.Location = new System.Drawing.Point(163, 255);
      this.txtTenDangNhap.Name = "txtTenDangNhap";
      this.txtTenDangNhap.Size = new System.Drawing.Size(170, 20);
      this.txtTenDangNhap.TabIndex = 13;
      // 
      // txtMatKhau
      // 
      this.txtMatKhau.Location = new System.Drawing.Point(163, 301);
      this.txtMatKhau.Name = "txtMatKhau";
      this.txtMatKhau.Size = new System.Drawing.Size(170, 20);
      this.txtMatKhau.TabIndex = 14;
      // 
      // btnDangKy
      // 
      this.btnDangKy.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDangKy.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnDangKy.Location = new System.Drawing.Point(115, 349);
      this.btnDangKy.Name = "btnDangKy";
      this.btnDangKy.Size = new System.Drawing.Size(87, 35);
      this.btnDangKy.TabIndex = 15;
      this.btnDangKy.Text = "Đăng Ký";
      this.btnDangKy.UseVisualStyleBackColor = false;
      // 
      // btnQuayLai
      // 
      this.btnQuayLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQuayLai.Location = new System.Drawing.Point(221, 349);
      this.btnQuayLai.Name = "btnQuayLai";
      this.btnQuayLai.Size = new System.Drawing.Size(85, 35);
      this.btnQuayLai.TabIndex = 16;
      this.btnQuayLai.Text = "Quay Lại";
      this.btnQuayLai.UseVisualStyleBackColor = false;
      // 
      // frmDangKy
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.ClientSize = new System.Drawing.Size(430, 406);
      this.Controls.Add(this.btnQuayLai);
      this.Controls.Add(this.btnDangKy);
      this.Controls.Add(this.txtMatKhau);
      this.Controls.Add(this.txtTenDangNhap);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtTruong);
      this.Controls.Add(this.txtLop);
      this.Controls.Add(this.txtNgaySinh);
      this.Controls.Add(this.txtMSSV);
      this.Controls.Add(this.txtHoTen);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmDangKy";
      this.Text = "Đăng Ký";
      this.Load += new System.EventHandler(this.DangKy_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.TextBox txtMSSV;
    private System.Windows.Forms.TextBox txtNgaySinh;
    private System.Windows.Forms.TextBox txtLop;
    private System.Windows.Forms.TextBox txtTruong;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtTenDangNhap;
    private System.Windows.Forms.TextBox txtMatKhau;
    private System.Windows.Forms.Button btnDangKy;
    private System.Windows.Forms.Button btnQuayLai;
  }
}