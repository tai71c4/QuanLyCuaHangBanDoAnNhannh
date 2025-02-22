namespace QuanLyCuaHangBanDoAnNhanh
{
    partial class KhuyenMai
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblMaKhuyenMai = new System.Windows.Forms.Label();
            this.txtMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtPhanTramGiam = new System.Windows.Forms.TextBox();
            this.txtIDKhuyenMai = new System.Windows.Forms.TextBox();
            this.lblIDKhuyenMai = new System.Windows.Forms.Label();
            this.lblPhanTramGiam = new System.Windows.Forms.Label();
            this.lblKhuyenMai = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCuaHangBanDoAnNhanhDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            this.khuyenMaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanDoAnNhanhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(397, 191);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(293, 22);
            this.txtTimKiem.TabIndex = 56;
            // 
            // lblMaKhuyenMai
            // 
            this.lblMaKhuyenMai.AutoSize = true;
            this.lblMaKhuyenMai.Location = new System.Drawing.Point(293, 81);
            this.lblMaKhuyenMai.Name = "lblMaKhuyenMai";
            this.lblMaKhuyenMai.Size = new System.Drawing.Size(98, 16);
            this.lblMaKhuyenMai.TabIndex = 55;
            this.lblMaKhuyenMai.Text = "Mã Khuyến Mãi";
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(397, 78);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(148, 22);
            this.txtMaKhuyenMai.TabIndex = 53;
            // 
            // txtPhanTramGiam
            // 
            this.txtPhanTramGiam.Location = new System.Drawing.Point(596, 78);
            this.txtPhanTramGiam.Name = "txtPhanTramGiam";
            this.txtPhanTramGiam.Size = new System.Drawing.Size(148, 22);
            this.txtPhanTramGiam.TabIndex = 52;
            // 
            // txtIDKhuyenMai
            // 
            this.txtIDKhuyenMai.Location = new System.Drawing.Point(125, 78);
            this.txtIDKhuyenMai.Name = "txtIDKhuyenMai";
            this.txtIDKhuyenMai.Size = new System.Drawing.Size(148, 22);
            this.txtIDKhuyenMai.TabIndex = 51;
            // 
            // lblIDKhuyenMai
            // 
            this.lblIDKhuyenMai.AutoSize = true;
            this.lblIDKhuyenMai.Location = new System.Drawing.Point(27, 81);
            this.lblIDKhuyenMai.Name = "lblIDKhuyenMai";
            this.lblIDKhuyenMai.Size = new System.Drawing.Size(92, 16);
            this.lblIDKhuyenMai.TabIndex = 50;
            this.lblIDKhuyenMai.Text = "ID Khuyến Mãi";
            // 
            // lblPhanTramGiam
            // 
            this.lblPhanTramGiam.AutoSize = true;
            this.lblPhanTramGiam.Location = new System.Drawing.Point(571, 81);
            this.lblPhanTramGiam.Name = "lblPhanTramGiam";
            this.lblPhanTramGiam.Size = new System.Drawing.Size(19, 16);
            this.lblPhanTramGiam.TabIndex = 48;
            this.lblPhanTramGiam.Text = "%";
            // 
            // lblKhuyenMai
            // 
            this.lblKhuyenMai.AutoSize = true;
            this.lblKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhuyenMai.Location = new System.Drawing.Point(317, 9);
            this.lblKhuyenMai.Name = "lblKhuyenMai";
            this.lblKhuyenMai.Size = new System.Drawing.Size(164, 32);
            this.lblKhuyenMai.TabIndex = 47;
            this.lblKhuyenMai.Text = "Khuyến Mãi";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(696, 190);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 46;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(284, 191);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 45;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(111, 191);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(192, 191);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 43;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(30, 191);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(125, 136);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayBatDau.TabIndex = 57;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(544, 136);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayKetThuc.TabIndex = 58;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(29, 141);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(90, 16);
            this.lblNgayBatDau.TabIndex = 59;
            this.lblNgayBatDau.Text = "Ngày Bắt Đầu";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(443, 142);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(95, 16);
            this.lblNgayKetThuc.TabIndex = 60;
            this.lblNgayKetThuc.Text = "Ngày Kết Thúc";
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.AutoGenerateColumns = false;
            this.dgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuyenMai.DataSource = this.khuyenMaiBindingSource;
            this.dgvKhuyenMai.Location = new System.Drawing.Point(30, 228);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.RowHeadersWidth = 51;
            this.dgvKhuyenMai.RowTemplate.Height = 24;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(741, 213);
            this.dgvKhuyenMai.TabIndex = 41;
            this.dgvKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuyenMai_CellClick);
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNgayKetThuc);
            this.Controls.Add(this.lblNgayBatDau);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.dgvKhuyenMai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblMaKhuyenMai);
            this.Controls.Add(this.txtMaKhuyenMai);
            this.Controls.Add(this.txtPhanTramGiam);
            this.Controls.Add(this.txtIDKhuyenMai);
            this.Controls.Add(this.lblIDKhuyenMai);
            this.Controls.Add(this.lblPhanTramGiam);
            this.Controls.Add(this.lblKhuyenMai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "KhuyenMai";
            this.Text = "KhuyenMai";
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanDoAnNhanhDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblMaKhuyenMai;
        private System.Windows.Forms.TextBox txtMaKhuyenMai;
        private System.Windows.Forms.TextBox txtPhanTramGiam;
        private System.Windows.Forms.TextBox txtIDKhuyenMai;
        private System.Windows.Forms.Label lblIDKhuyenMai;
        private System.Windows.Forms.Label lblPhanTramGiam;
        private System.Windows.Forms.Label lblKhuyenMai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.BindingSource quanLyCuaHangBanDoAnNhanhDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgvKhuyenMai;
        private System.Windows.Forms.BindingSource khuyenMaiBindingSource;
    }
}