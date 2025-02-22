namespace QuanLyCuaHangBanDoAnNhanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.ckbHienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckbHienMatKhau
            // 
            this.ckbHienMatKhau.AutoSize = true;
            this.ckbHienMatKhau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ckbHienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ckbHienMatKhau.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ckbHienMatKhau.Location = new System.Drawing.Point(356, 268);
            this.ckbHienMatKhau.Name = "ckbHienMatKhau";
            this.ckbHienMatKhau.Size = new System.Drawing.Size(124, 21);
            this.ckbHienMatKhau.TabIndex = 31;
            this.ckbHienMatKhau.Text = "Hiên Mật Khẩu";
            this.ckbHienMatKhau.UseVisualStyleBackColor = false;
            this.ckbHienMatKhau.CheckedChanged += new System.EventHandler(this.ckbHienMatKhau_CheckedChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDangKy.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDangKy.Location = new System.Drawing.Point(365, 303);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(102, 32);
            this.btnDangKy.TabIndex = 30;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDangNhap.Location = new System.Drawing.Point(253, 303);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(102, 32);
            this.btnDangNhap.TabIndex = 29;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMatKhau.Location = new System.Drawing.Point(253, 240);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(214, 22);
            this.txtMatKhau.TabIndex = 28;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.White;
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.txtTenDangNhap.Location = new System.Drawing.Point(253, 177);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(214, 22);
            this.txtTenDangNhap.TabIndex = 27;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.Black;
            this.lblMatKhau.Location = new System.Drawing.Point(250, 219);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(103, 18);
            this.lblMatKhau.TabIndex = 26;
            this.lblMatKhau.Text = "🔑Mật Khẩu:";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDangNhap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTenDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTenDangNhap.Location = new System.Drawing.Point(250, 156);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(148, 18);
            this.lblTenDangNhap.TabIndex = 25;
            this.lblTenDangNhap.Text = "💁Tên Đăng Nhập:";
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.Black;
            this.lblDangNhap.Location = new System.Drawing.Point(262, 91);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(189, 32);
            this.lblDangNhap.TabIndex = 24;
            this.lblDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(719, 458);
            this.Controls.Add(this.ckbHienMatKhau);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblDangNhap);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbHienMatKhau;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblDangNhap;
    }
}