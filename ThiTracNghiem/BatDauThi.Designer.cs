﻿namespace ThiTracNghiem
{
  partial class frmBatDauThi
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lbGiay = new System.Windows.Forms.Label();
      this.lb = new System.Windows.Forms.Label();
      this.lbPhut = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbMaSoSinhVien = new System.Windows.Forms.Label();
      this.lbTenSinhVien = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.rdDapAnD = new System.Windows.Forms.RadioButton();
      this.rdDapAnC = new System.Windows.Forms.RadioButton();
      this.rdDapAnB = new System.Windows.Forms.RadioButton();
      this.rdDapAnA = new System.Windows.Forms.RadioButton();
      this.lbCauSo = new System.Windows.Forms.Label();
      this.btnQuayLai = new System.Windows.Forms.Button();
      this.btnCauTiep = new System.Windows.Forms.Button();
      this.lbNoiDung = new System.Windows.Forms.Label();
      this.label = new System.Windows.Forms.Label();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.btnBatDau = new System.Windows.Forms.Button();
      this.cbDeThi = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lbGiay);
      this.groupBox1.Controls.Add(this.lb);
      this.groupBox1.Controls.Add(this.lbPhut);
      this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(807, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(142, 56);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thời gian làm bài";
      // 
      // lbGiay
      // 
      this.lbGiay.AutoSize = true;
      this.lbGiay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbGiay.Location = new System.Drawing.Point(71, 23);
      this.lbGiay.Name = "lbGiay";
      this.lbGiay.Size = new System.Drawing.Size(32, 24);
      this.lbGiay.TabIndex = 2;
      this.lbGiay.Text = "00";
      // 
      // lb
      // 
      this.lb.AutoSize = true;
      this.lb.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lb.Location = new System.Drawing.Point(60, 26);
      this.lb.Name = "lb";
      this.lb.Size = new System.Drawing.Size(15, 19);
      this.lb.TabIndex = 1;
      this.lb.Text = ":";
      this.lb.Click += new System.EventHandler(this.label2_Click);
      // 
      // lbPhut
      // 
      this.lbPhut.AutoSize = true;
      this.lbPhut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbPhut.Location = new System.Drawing.Point(33, 23);
      this.lbPhut.Name = "lbPhut";
      this.lbPhut.Size = new System.Drawing.Size(32, 24);
      this.lbPhut.TabIndex = 0;
      this.lbPhut.Text = "00";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(22, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(107, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Mã Số Sinh Viên";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(22, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 17);
      this.label2.TabIndex = 2;
      this.label2.Text = "Tên Sinh Viên";
      // 
      // lbMaSoSinhVien
      // 
      this.lbMaSoSinhVien.BackColor = System.Drawing.Color.White;
      this.lbMaSoSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbMaSoSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbMaSoSinhVien.ForeColor = System.Drawing.Color.DodgerBlue;
      this.lbMaSoSinhVien.Location = new System.Drawing.Point(135, 16);
      this.lbMaSoSinhVien.Name = "lbMaSoSinhVien";
      this.lbMaSoSinhVien.Size = new System.Drawing.Size(198, 21);
      this.lbMaSoSinhVien.TabIndex = 3;
      // 
      // lbTenSinhVien
      // 
      this.lbTenSinhVien.BackColor = System.Drawing.Color.White;
      this.lbTenSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbTenSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbTenSinhVien.ForeColor = System.Drawing.Color.DodgerBlue;
      this.lbTenSinhVien.Location = new System.Drawing.Point(135, 46);
      this.lbTenSinhVien.Name = "lbTenSinhVien";
      this.lbTenSinhVien.Size = new System.Drawing.Size(198, 21);
      this.lbTenSinhVien.TabIndex = 4;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lbTenSinhVien);
      this.groupBox2.Controls.Add(this.lbMaSoSinhVien);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Location = new System.Drawing.Point(16, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(339, 85);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Sinh Viên";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.groupBox4);
      this.groupBox3.Controls.Add(this.lbCauSo);
      this.groupBox3.Controls.Add(this.btnQuayLai);
      this.groupBox3.Controls.Add(this.btnCauTiep);
      this.groupBox3.Controls.Add(this.lbNoiDung);
      this.groupBox3.Controls.Add(this.label);
      this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox3.Location = new System.Drawing.Point(14, 115);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(935, 237);
      this.groupBox3.TabIndex = 6;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Nội dung câu hỏi";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.rdDapAnD);
      this.groupBox4.Controls.Add(this.rdDapAnC);
      this.groupBox4.Controls.Add(this.rdDapAnB);
      this.groupBox4.Controls.Add(this.rdDapAnA);
      this.groupBox4.Location = new System.Drawing.Point(27, 85);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(879, 117);
      this.groupBox4.TabIndex = 16;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Đáp Án";
      // 
      // rdDapAnD
      // 
      this.rdDapAnD.AutoSize = true;
      this.rdDapAnD.Location = new System.Drawing.Point(442, 73);
      this.rdDapAnD.Name = "rdDapAnD";
      this.rdDapAnD.Size = new System.Drawing.Size(88, 21);
      this.rdDapAnD.TabIndex = 9;
      this.rdDapAnD.TabStop = true;
      this.rdDapAnD.Text = "Đáp Án D";
      this.rdDapAnD.UseVisualStyleBackColor = true;
      // 
      // rdDapAnC
      // 
      this.rdDapAnC.AutoSize = true;
      this.rdDapAnC.Location = new System.Drawing.Point(442, 24);
      this.rdDapAnC.Name = "rdDapAnC";
      this.rdDapAnC.Size = new System.Drawing.Size(87, 21);
      this.rdDapAnC.TabIndex = 2;
      this.rdDapAnC.TabStop = true;
      this.rdDapAnC.Text = "Đáp Án C";
      this.rdDapAnC.UseVisualStyleBackColor = true;
      // 
      // rdDapAnB
      // 
      this.rdDapAnB.AutoSize = true;
      this.rdDapAnB.Location = new System.Drawing.Point(49, 73);
      this.rdDapAnB.Name = "rdDapAnB";
      this.rdDapAnB.Size = new System.Drawing.Size(87, 21);
      this.rdDapAnB.TabIndex = 1;
      this.rdDapAnB.TabStop = true;
      this.rdDapAnB.Text = "Đáp Án B";
      this.rdDapAnB.UseVisualStyleBackColor = true;
      // 
      // rdDapAnA
      // 
      this.rdDapAnA.AutoSize = true;
      this.rdDapAnA.Location = new System.Drawing.Point(49, 34);
      this.rdDapAnA.Name = "rdDapAnA";
      this.rdDapAnA.Size = new System.Drawing.Size(87, 21);
      this.rdDapAnA.TabIndex = 0;
      this.rdDapAnA.TabStop = true;
      this.rdDapAnA.Text = "Đáp Án A";
      this.rdDapAnA.UseVisualStyleBackColor = true;
      // 
      // lbCauSo
      // 
      this.lbCauSo.AutoSize = true;
      this.lbCauSo.Location = new System.Drawing.Point(73, 42);
      this.lbCauSo.Name = "lbCauSo";
      this.lbCauSo.Size = new System.Drawing.Size(15, 17);
      this.lbCauSo.TabIndex = 15;
      this.lbCauSo.Text = "1";
      // 
      // btnQuayLai
      // 
      this.btnQuayLai.Location = new System.Drawing.Point(714, 208);
      this.btnQuayLai.Name = "btnQuayLai";
      this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
      this.btnQuayLai.TabIndex = 14;
      this.btnQuayLai.Text = "Quay Lại";
      this.btnQuayLai.UseVisualStyleBackColor = true;
      // 
      // btnCauTiep
      // 
      this.btnCauTiep.Location = new System.Drawing.Point(805, 208);
      this.btnCauTiep.Name = "btnCauTiep";
      this.btnCauTiep.Size = new System.Drawing.Size(101, 23);
      this.btnCauTiep.TabIndex = 13;
      this.btnCauTiep.Text = "Câu tiếp theo";
      this.btnCauTiep.UseVisualStyleBackColor = true;
      // 
      // lbNoiDung
      // 
      this.lbNoiDung.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbNoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbNoiDung.ForeColor = System.Drawing.Color.DodgerBlue;
      this.lbNoiDung.Location = new System.Drawing.Point(110, 38);
      this.lbNoiDung.Name = "lbNoiDung";
      this.lbNoiDung.Size = new System.Drawing.Size(796, 21);
      this.lbNoiDung.TabIndex = 4;
      // 
      // label
      // 
      this.label.AutoSize = true;
      this.label.Location = new System.Drawing.Point(24, 42);
      this.label.Name = "label";
      this.label.Size = new System.Drawing.Size(49, 17);
      this.label.TabIndex = 0;
      this.label.Text = "Câu số";
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.btnBatDau);
      this.groupBox5.Controls.Add(this.cbDeThi);
      this.groupBox5.Controls.Add(this.label4);
      this.groupBox5.Location = new System.Drawing.Point(399, 17);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(262, 80);
      this.groupBox5.TabIndex = 8;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Môn Thi";
      // 
      // btnBatDau
      // 
      this.btnBatDau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBatDau.Location = new System.Drawing.Point(162, 51);
      this.btnBatDau.Name = "btnBatDau";
      this.btnBatDau.Size = new System.Drawing.Size(75, 23);
      this.btnBatDau.TabIndex = 2;
      this.btnBatDau.Text = "Bắt đầu thi";
      this.btnBatDau.UseVisualStyleBackColor = true;
      // 
      // cbDeThi
      // 
      this.cbDeThi.FormattingEnabled = true;
      this.cbDeThi.Location = new System.Drawing.Point(103, 22);
      this.cbDeThi.Name = "cbDeThi";
      this.cbDeThi.Size = new System.Drawing.Size(153, 21);
      this.cbDeThi.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(13, 25);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(75, 15);
      this.label4.TabIndex = 0;
      this.label4.Text = "Chọn Đề Thi";
      // 
      // frmBatDauThi
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.ClientSize = new System.Drawing.Size(975, 367);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "frmBatDauThi";
      this.Text = "Băt đầu thi trắc nghiệm";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lb;
    private System.Windows.Forms.Label lbPhut;
    private System.Windows.Forms.Label lbGiay;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lbMaSoSinhVien;
    private System.Windows.Forms.Label lbTenSinhVien;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label lbNoiDung;
    private System.Windows.Forms.Label label;
    private System.Windows.Forms.Button btnQuayLai;
    private System.Windows.Forms.Button btnCauTiep;
    private System.Windows.Forms.Label lbCauSo;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnBatDau;
    private System.Windows.Forms.ComboBox cbDeThi;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.RadioButton rdDapAnD;
    private System.Windows.Forms.RadioButton rdDapAnC;
    private System.Windows.Forms.RadioButton rdDapAnB;
    private System.Windows.Forms.RadioButton rdDapAnA;
  }
}