namespace Cau3_FormNhapDiem;

partial class FormNhapDiem
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
        this.components = new System.ComponentModel.Container();
        this.txtMaHS = new System.Windows.Forms.TextBox();
        this.txtHoTen = new System.Windows.Forms.TextBox();
        this.txtToan = new System.Windows.Forms.TextBox();
        this.txtVan = new System.Windows.Forms.TextBox();
        this.txtAnh = new System.Windows.Forms.TextBox();
        this.btnLuu = new System.Windows.Forms.Button();
        this.btnXoaTrang = new System.Windows.Forms.Button();
        this.lstKetQua = new System.Windows.Forms.ListBox();
        this.lblMaHS = new System.Windows.Forms.Label();
        this.lblHoTen = new System.Windows.Forms.Label();
        this.lblToan = new System.Windows.Forms.Label();
        this.lblVan = new System.Windows.Forms.Label();
        this.lblAnh = new System.Windows.Forms.Label();
        this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        this.SuspendLayout();
        // 
        // txtMaHS
        // 
        this.txtMaHS.Name = "txtMaHS";
        this.txtMaHS.Location = new System.Drawing.Point(15, 38);
        this.txtMaHS.Size = new System.Drawing.Size(90, 23);
        this.txtMaHS.TabIndex = 0;
        // 
        // txtHoTen
        // 
        this.txtHoTen.Name = "txtHoTen";
        this.txtHoTen.Location = new System.Drawing.Point(120, 38);
        this.txtHoTen.Size = new System.Drawing.Size(160, 23);
        this.txtHoTen.TabIndex = 1;
        // 
        // txtToan
        // 
        this.txtToan.Name = "txtToan";
        this.txtToan.Location = new System.Drawing.Point(295, 38);
        this.txtToan.Size = new System.Drawing.Size(80, 23);
        this.txtToan.TabIndex = 2;
        this.txtToan.Enter += new System.EventHandler(this.DiemTextBox_Enter);
        // 
        // txtVan
        // 
        this.txtVan.Name = "txtVan";
        this.txtVan.Location = new System.Drawing.Point(390, 38);
        this.txtVan.Size = new System.Drawing.Size(80, 23);
        this.txtVan.TabIndex = 3;
        this.txtVan.Enter += new System.EventHandler(this.DiemTextBox_Enter);
        // 
        // txtAnh
        // 
        this.txtAnh.Name = "txtAnh";
        this.txtAnh.Location = new System.Drawing.Point(485, 38);
        this.txtAnh.Size = new System.Drawing.Size(80, 23);
        this.txtAnh.TabIndex = 4;
        this.txtAnh.Enter += new System.EventHandler(this.DiemTextBox_Enter);
        // 
        // btnLuu
        // 
        this.btnLuu.Name = "btnLuu";
        this.btnLuu.BackColor = System.Drawing.Color.MediumSeaGreen;
        this.btnLuu.ForeColor = System.Drawing.Color.White;
        this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLuu.Location = new System.Drawing.Point(15, 75);
        this.btnLuu.Size = new System.Drawing.Size(80, 30);
        this.btnLuu.TabIndex = 5;
        this.btnLuu.Text = "Lưu";
        this.btnLuu.UseVisualStyleBackColor = false;
        this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
        // 
        // btnXoaTrang
        // 
        this.btnXoaTrang.Name = "btnXoaTrang";
        this.btnXoaTrang.Location = new System.Drawing.Point(105, 75);
        this.btnXoaTrang.Size = new System.Drawing.Size(90, 30);
        this.btnXoaTrang.TabIndex = 6;
        this.btnXoaTrang.Text = "Xóa Trắng";
        this.btnXoaTrang.UseVisualStyleBackColor = true;
        this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
        // 
        // lstKetQua
        // 
        this.lstKetQua.Name = "lstKetQua";
        this.lstKetQua.FormattingEnabled = true;
        this.lstKetQua.ItemHeight = 15;
        this.lstKetQua.Location = new System.Drawing.Point(15, 120);
        this.lstKetQua.Size = new System.Drawing.Size(550, 244);
        this.lstKetQua.TabIndex = 7;
        this.lstKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        // 
        // lblMaHS
        // 
        this.lblMaHS.Name = "lblMaHS";
        this.lblMaHS.AutoSize = true;
        this.lblMaHS.Location = new System.Drawing.Point(15, 15);
        this.lblMaHS.Text = "Mã HS";
        this.lblMaHS.TabStop = false;
        this.lblMaHS.TabIndex = 8;
        // 
        // lblHoTen
        // 
        this.lblHoTen.Name = "lblHoTen";
        this.lblHoTen.AutoSize = true;
        this.lblHoTen.Location = new System.Drawing.Point(120, 15);
        this.lblHoTen.Text = "Họ tên";
        this.lblHoTen.TabStop = false;
        this.lblHoTen.TabIndex = 9;
        // 
        // lblToan
        // 
        this.lblToan.Name = "lblToan";
        this.lblToan.AutoSize = true;
        this.lblToan.Location = new System.Drawing.Point(295, 15);
        this.lblToan.Text = "Điểm Toán";
        this.lblToan.TabStop = false;
        this.lblToan.TabIndex = 10;
        // 
        // lblVan
        // 
        this.lblVan.Name = "lblVan";
        this.lblVan.AutoSize = true;
        this.lblVan.Location = new System.Drawing.Point(390, 15);
        this.lblVan.Text = "Điểm Văn";
        this.lblVan.TabStop = false;
        this.lblVan.TabIndex = 11;
        // 
        // lblAnh
        // 
        this.lblAnh.Name = "lblAnh";
        this.lblAnh.AutoSize = true;
        this.lblAnh.Location = new System.Drawing.Point(485, 15);
        this.lblAnh.Text = "Điểm Anh";
        this.lblAnh.TabStop = false;
        this.lblAnh.TabIndex = 12;
        // 
        // errorProvider1
        // 
        this.errorProvider1.ContainerControl = this;
        // 
        // FormNhapDiem
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(580, 380);
        this.Text = "Nhập điểm học sinh";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Controls.Add(this.txtMaHS);
        this.Controls.Add(this.txtHoTen);
        this.Controls.Add(this.txtToan);
        this.Controls.Add(this.txtVan);
        this.Controls.Add(this.txtAnh);
        this.Controls.Add(this.btnLuu);
        this.Controls.Add(this.btnXoaTrang);
        this.Controls.Add(this.lstKetQua);
        this.Controls.Add(this.lblMaHS);
        this.Controls.Add(this.lblHoTen);
        this.Controls.Add(this.lblToan);
        this.Controls.Add(this.lblVan);
        this.Controls.Add(this.lblAnh);
        this.Name = "FormNhapDiem";
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox txtMaHS;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.TextBox txtToan;
    private System.Windows.Forms.TextBox txtVan;
    private System.Windows.Forms.TextBox txtAnh;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnXoaTrang;
    private System.Windows.Forms.ListBox lstKetQua;
    private System.Windows.Forms.Label lblMaHS;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.Label lblToan;
    private System.Windows.Forms.Label lblVan;
    private System.Windows.Forms.Label lblAnh;
    private System.Windows.Forms.ErrorProvider errorProvider1;
}
