namespace demo
{
    partial class KhachHang
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
            this.components = new System.ComponentModel.Container();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.txtMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtSDTKhachHang = new System.Windows.Forms.TextBox();
            this.txtIDKhachHang = new System.Windows.Forms.TextBox();
            this.lblIDKhachHang = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiemTichLuy = new System.Windows.Forms.TextBox();
            this.lblDiemTichLuy = new System.Windows.Forms.Label();
            this.lblSDTKhachHang = new System.Windows.Forms.Label();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCuaHangBanDoAnNhanhDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanDoAnNhanhDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoGenerateColumns = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.DataSource = this.khachHangBindingSource;
            this.dgvKhachHang.Location = new System.Drawing.Point(31, 228);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(741, 213);
            this.dgvKhachHang.TabIndex = 61;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(398, 191);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(293, 22);
            this.txtTimKiem.TabIndex = 74;
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Location = new System.Drawing.Point(294, 81);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(52, 16);
            this.txtHoTen.TabIndex = 73;
            this.txtHoTen.Text = "Họ Tên";
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(398, 78);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(148, 22);
            this.txtMaKhuyenMai.TabIndex = 72;
            // 
            // txtSDTKhachHang
            // 
            this.txtSDTKhachHang.Location = new System.Drawing.Point(597, 78);
            this.txtSDTKhachHang.Name = "txtSDTKhachHang";
            this.txtSDTKhachHang.Size = new System.Drawing.Size(148, 22);
            this.txtSDTKhachHang.TabIndex = 71;
            // 
            // txtIDKhachHang
            // 
            this.txtIDKhachHang.Location = new System.Drawing.Point(126, 78);
            this.txtIDKhachHang.Name = "txtIDKhachHang";
            this.txtIDKhachHang.Size = new System.Drawing.Size(148, 22);
            this.txtIDKhachHang.TabIndex = 70;
            // 
            // lblIDKhachHang
            // 
            this.lblIDKhachHang.AutoSize = true;
            this.lblIDKhachHang.Location = new System.Drawing.Point(28, 81);
            this.lblIDKhachHang.Name = "lblIDKhachHang";
            this.lblIDKhachHang.Size = new System.Drawing.Size(89, 16);
            this.lblIDKhachHang.TabIndex = 69;
            this.lblIDKhachHang.Text = "ID Khác Hàng";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhachHang.Location = new System.Drawing.Point(262, 9);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(284, 32);
            this.lblKhachHang.TabIndex = 67;
            this.lblKhachHang.Text = "Quản Lý Khách Hàng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(697, 190);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 66;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(285, 191);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 65;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(112, 191);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 64;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(193, 191);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 63;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 191);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 62;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiemTichLuy
            // 
            this.txtDiemTichLuy.Location = new System.Drawing.Point(137, 127);
            this.txtDiemTichLuy.Name = "txtDiemTichLuy";
            this.txtDiemTichLuy.Size = new System.Drawing.Size(148, 22);
            this.txtDiemTichLuy.TabIndex = 76;
            // 
            // lblDiemTichLuy
            // 
            this.lblDiemTichLuy.AutoSize = true;
            this.lblDiemTichLuy.Location = new System.Drawing.Point(25, 127);
            this.lblDiemTichLuy.Name = "lblDiemTichLuy";
            this.lblDiemTichLuy.Size = new System.Drawing.Size(91, 16);
            this.lblDiemTichLuy.TabIndex = 75;
            this.lblDiemTichLuy.Text = "Điểm Tích Lũy";
            // 
            // lblSDTKhachHang
            // 
            this.lblSDTKhachHang.AutoSize = true;
            this.lblSDTKhachHang.Location = new System.Drawing.Point(539, 81);
            this.lblSDTKhachHang.Name = "lblSDTKhachHang";
            this.lblSDTKhachHang.Size = new System.Drawing.Size(35, 16);
            this.lblSDTKhachHang.TabIndex = 77;
            this.lblSDTKhachHang.Text = "SDT";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSDTKhachHang);
            this.Controls.Add(this.txtDiemTichLuy);
            this.Controls.Add(this.lblDiemTichLuy);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaKhuyenMai);
            this.Controls.Add(this.txtSDTKhachHang);
            this.Controls.Add(this.txtIDKhachHang);
            this.Controls.Add(this.lblIDKhachHang);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanDoAnNhanhDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.TextBox txtMaKhuyenMai;
        private System.Windows.Forms.TextBox txtSDTKhachHang;
        private System.Windows.Forms.TextBox txtIDKhachHang;
        private System.Windows.Forms.Label lblIDKhachHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiemTichLuy;
        private System.Windows.Forms.Label lblDiemTichLuy;
        private System.Windows.Forms.Label lblSDTKhachHang;
       
       
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.BindingSource quanLyCuaHangBanDoAnNhanhDataSet1BindingSource;
  
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTichLuyDataGridViewTextBoxColumn;
    }
}