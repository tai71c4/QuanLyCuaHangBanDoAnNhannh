namespace demo
{
    partial class DonHang
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
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtIDDonHang = new System.Windows.Forms.TextBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.cbKhuyenMai = new System.Windows.Forms.ComboBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.lblIDDonHang = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblKhuyenMai = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblDonHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AutoGenerateColumns = false;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.DataSource = this.hoaDonBindingSource;
            this.dgvDonHang.Location = new System.Drawing.Point(23, 231);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.Size = new System.Drawing.Size(741, 213);
            this.dgvDonHang.TabIndex = 75;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(390, 194);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(293, 22);
            this.txtTimKiem.TabIndex = 81;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(689, 193);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 80;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(277, 194);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 79;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(104, 194);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 78;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(185, 194);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 77;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 194);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtIDDonHang
            // 
            this.txtIDDonHang.Location = new System.Drawing.Point(138, 44);
            this.txtIDDonHang.Name = "txtIDDonHang";
            this.txtIDDonHang.Size = new System.Drawing.Size(121, 22);
            this.txtIDDonHang.TabIndex = 82;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(469, 95);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(121, 24);
            this.cbNhanVien.TabIndex = 83;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(469, 140);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(121, 24);
            this.cbTrangThai.TabIndex = 84;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(138, 87);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(121, 24);
            this.cbKhachHang.TabIndex = 85;
            // 
            // cbKhuyenMai
            // 
            this.cbKhuyenMai.FormattingEnabled = true;
            this.cbKhuyenMai.Location = new System.Drawing.Point(138, 132);
            this.cbKhuyenMai.Name = "cbKhuyenMai";
            this.cbKhuyenMai.Size = new System.Drawing.Size(121, 24);
            this.cbKhuyenMai.TabIndex = 86;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Location = new System.Drawing.Point(469, 50);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayTao.TabIndex = 87;
            // 
            // lblIDDonHang
            // 
            this.lblIDDonHang.AutoSize = true;
            this.lblIDDonHang.Location = new System.Drawing.Point(54, 47);
            this.lblIDDonHang.Name = "lblIDDonHang";
            this.lblIDDonHang.Size = new System.Drawing.Size(83, 16);
            this.lblIDDonHang.TabIndex = 88;
            this.lblIDDonHang.Text = "ID Đơn Hàng";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(54, 95);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(80, 16);
            this.lblKhachHang.TabIndex = 89;
            this.lblKhachHang.Text = "Khách Hàng";
            // 
            // lblKhuyenMai
            // 
            this.lblKhuyenMai.AutoSize = true;
            this.lblKhuyenMai.Location = new System.Drawing.Point(54, 140);
            this.lblKhuyenMai.Name = "lblKhuyenMai";
            this.lblKhuyenMai.Size = new System.Drawing.Size(76, 16);
            this.lblKhuyenMai.TabIndex = 90;
            this.lblKhuyenMai.Text = "Khuyến Mãi";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(352, 98);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(69, 16);
            this.lblNhanVien.TabIndex = 91;
            this.lblNhanVien.Text = "Nhân Viên";
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Location = new System.Drawing.Point(352, 50);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(68, 16);
            this.lblNgayTao.TabIndex = 92;
            this.lblNgayTao.Text = "Ngày Tạo";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(352, 143);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(73, 16);
            this.lblTrangThai.TabIndex = 93;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // lblDonHang
            // 
            this.lblDonHang.AutoSize = true;
            this.lblDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDonHang.Location = new System.Drawing.Point(271, 9);
            this.lblDonHang.Name = "lblDonHang";
            this.lblDonHang.Size = new System.Drawing.Size(255, 32);
            this.lblDonHang.TabIndex = 94;
            this.lblDonHang.Text = "Quản Lý Đơn Hàng";
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDonHang);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblKhuyenMai);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.lblIDDonHang);
            this.Controls.Add(this.dtpNgayTao);
            this.Controls.Add(this.cbKhuyenMai);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(this.txtIDDonHang);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "DonHang";
            this.Text = "DonHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtIDDonHang;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.ComboBox cbKhuyenMai;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label lblIDDonHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblKhuyenMai;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblDonHang;
       
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDonHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
    }
}