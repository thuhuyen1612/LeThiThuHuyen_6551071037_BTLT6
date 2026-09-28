namespace Cau5_FormBanVe;

partial class FormBanVe
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.lblTenKhach = new System.Windows.Forms.Label();
        this.txtTenKhach = new System.Windows.Forms.TextBox();
        this.lblPhim = new System.Windows.Forms.Label();
        this.cboPhim = new System.Windows.Forms.ComboBox();
        this.lblSuatChieu = new System.Windows.Forms.Label();
        this.cboSuatChieu = new System.Windows.Forms.ComboBox();
        this.lblGheDaChon = new System.Windows.Forms.Label();
        this.txtGheDaChon = new System.Windows.Forms.TextBox();
        this.lblGia = new System.Windows.Forms.Label();
        this.btnChonGhe = new System.Windows.Forms.Button();
        this.btnDatVe = new System.Windows.Forms.Button();
        this.btnHuy = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // lblTenKhach
        // 
        this.lblTenKhach.Name = "lblTenKhach";
        this.lblTenKhach.AutoSize = true;
        this.lblTenKhach.Location = new System.Drawing.Point(20, 15);
        this.lblTenKhach.Text = "Tên khách:";
        this.lblTenKhach.TabIndex = 0;
        // 
        // txtTenKhach
        // 
        this.txtTenKhach.Name = "txtTenKhach";
        this.txtTenKhach.Location = new System.Drawing.Point(20, 38);
        this.txtTenKhach.Size = new System.Drawing.Size(370, 23);
        this.txtTenKhach.TabIndex = 1;
        // 
        // lblPhim
        // 
        this.lblPhim.Name = "lblPhim";
        this.lblPhim.AutoSize = true;
        this.lblPhim.Location = new System.Drawing.Point(20, 75);
        this.lblPhim.Text = "Phim:";
        this.lblPhim.TabIndex = 2;
        // 
        // cboPhim
        // 
        this.cboPhim.Name = "cboPhim";
        this.cboPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboPhim.FormattingEnabled = true;
        this.cboPhim.Location = new System.Drawing.Point(20, 98);
        this.cboPhim.Size = new System.Drawing.Size(370, 23);
        this.cboPhim.TabIndex = 3;
        this.cboPhim.Items.AddRange(new object[] {
            "Chiến binh cuối cùng",
            "Mùa hè năm ấy",
            "Truy tìm kho báu",
            "Đêm không ngủ"});
        // 
        // lblSuatChieu
        // 
        this.lblSuatChieu.Name = "lblSuatChieu";
        this.lblSuatChieu.AutoSize = true;
        this.lblSuatChieu.Location = new System.Drawing.Point(20, 135);
        this.lblSuatChieu.Text = "Suất chiếu:";
        this.lblSuatChieu.TabIndex = 4;
        // 
        // cboSuatChieu
        // 
        this.cboSuatChieu.Name = "cboSuatChieu";
        this.cboSuatChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboSuatChieu.FormattingEnabled = true;
        this.cboSuatChieu.Location = new System.Drawing.Point(20, 158);
        this.cboSuatChieu.Size = new System.Drawing.Size(370, 23);
        this.cboSuatChieu.TabIndex = 5;
        this.cboSuatChieu.Items.AddRange(new object[] {
            "09:00",
            "13:30",
            "16:00",
            "19:00",
            "21:30"});
        // 
        // lblGheDaChon
        // 
        this.lblGheDaChon.Name = "lblGheDaChon";
        this.lblGheDaChon.AutoSize = true;
        this.lblGheDaChon.Location = new System.Drawing.Point(20, 195);
        this.lblGheDaChon.Text = "Ghế đã chọn:";
        this.lblGheDaChon.TabIndex = 6;
        // 
        // txtGheDaChon
        // 
        this.txtGheDaChon.Name = "txtGheDaChon";
        this.txtGheDaChon.Location = new System.Drawing.Point(20, 218);
        this.txtGheDaChon.ReadOnly = true;
        this.txtGheDaChon.Size = new System.Drawing.Size(370, 23);
        this.txtGheDaChon.TabIndex = 7;
        // 
        // lblGia
        // 
        this.lblGia.Name = "lblGia";
        this.lblGia.AutoSize = true;
        this.lblGia.Location = new System.Drawing.Point(20, 255);
        this.lblGia.Text = "Giá vé: 75.000đ/vé";
        this.lblGia.TabIndex = 8;
        // 
        // btnChonGhe
        // 
        this.btnChonGhe.Name = "btnChonGhe";
        this.btnChonGhe.Location = new System.Drawing.Point(20, 300);
        this.btnChonGhe.Size = new System.Drawing.Size(110, 36);
        this.btnChonGhe.Text = "Chọn ghế";
        this.btnChonGhe.UseVisualStyleBackColor = true;
        this.btnChonGhe.TabIndex = 9;
        this.btnChonGhe.Click += new System.EventHandler(this.btnChonGhe_Click);
        // 
        // btnDatVe
        // 
        this.btnDatVe.Name = "btnDatVe";
        this.btnDatVe.Location = new System.Drawing.Point(150, 300);
        this.btnDatVe.Size = new System.Drawing.Size(110, 36);
        this.btnDatVe.Text = "Đặt vé";
        this.btnDatVe.UseVisualStyleBackColor = true;
        this.btnDatVe.TabIndex = 10;
        this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
        // 
        // btnHuy
        // 
        this.btnHuy.Name = "btnHuy";
        this.btnHuy.Location = new System.Drawing.Point(280, 300);
        this.btnHuy.Size = new System.Drawing.Size(110, 36);
        this.btnHuy.Text = "Hủy";
        this.btnHuy.UseVisualStyleBackColor = true;
        this.btnHuy.TabIndex = 11;
        this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
        // 
        // FormBanVe
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(410, 360);
        this.Text = "Bán vé xem phim";
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Controls.Add(this.lblTenKhach);
        this.Controls.Add(this.txtTenKhach);
        this.Controls.Add(this.lblPhim);
        this.Controls.Add(this.cboPhim);
        this.Controls.Add(this.lblSuatChieu);
        this.Controls.Add(this.cboSuatChieu);
        this.Controls.Add(this.lblGheDaChon);
        this.Controls.Add(this.txtGheDaChon);
        this.Controls.Add(this.lblGia);
        this.Controls.Add(this.btnChonGhe);
        this.Controls.Add(this.btnDatVe);
        this.Controls.Add(this.btnHuy);
        this.Name = "FormBanVe";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTenKhach;
    private System.Windows.Forms.TextBox txtTenKhach;
    private System.Windows.Forms.Label lblPhim;
    private System.Windows.Forms.ComboBox cboPhim;
    private System.Windows.Forms.Label lblSuatChieu;
    private System.Windows.Forms.ComboBox cboSuatChieu;
    private System.Windows.Forms.Label lblGheDaChon;
    private System.Windows.Forms.TextBox txtGheDaChon;
    private System.Windows.Forms.Label lblGia;
    private System.Windows.Forms.Button btnChonGhe;
    private System.Windows.Forms.Button btnDatVe;
    private System.Windows.Forms.Button btnHuy;
}
