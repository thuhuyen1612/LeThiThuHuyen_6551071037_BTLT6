namespace Cau4_FormDanhBa;

partial class FormDanhBa
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
        this.lstLienHe = new System.Windows.Forms.ListBox();
        this.lblTen = new System.Windows.Forms.Label();
        this.txtTen = new System.Windows.Forms.TextBox();
        this.lblSDT = new System.Windows.Forms.Label();
        this.txtSDT = new System.Windows.Forms.TextBox();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnThoat = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // lstLienHe
        // 
        this.lstLienHe.Name = "lstLienHe";
        this.lstLienHe.FormattingEnabled = true;
        this.lstLienHe.ItemHeight = 15;
        this.lstLienHe.Location = new System.Drawing.Point(12, 12);
        this.lstLienHe.Size = new System.Drawing.Size(300, 334);
        this.lstLienHe.TabIndex = 0;
        // 
        // lblTen
        // 
        this.lblTen.Name = "lblTen";
        this.lblTen.AutoSize = true;
        this.lblTen.Location = new System.Drawing.Point(330, 12);
        this.lblTen.Text = "Tên";
        this.lblTen.TabStop = false;
        this.lblTen.TabIndex = 1;
        // 
        // txtTen
        // 
        this.txtTen.Name = "txtTen";
        this.txtTen.Location = new System.Drawing.Point(330, 32);
        this.txtTen.Size = new System.Drawing.Size(240, 23);
        this.txtTen.TabIndex = 2;
        // 
        // lblSDT
        // 
        this.lblSDT.Name = "lblSDT";
        this.lblSDT.AutoSize = true;
        this.lblSDT.Location = new System.Drawing.Point(330, 70);
        this.lblSDT.Text = "Số điện thoại";
        this.lblSDT.TabStop = false;
        this.lblSDT.TabIndex = 3;
        // 
        // txtSDT
        // 
        this.txtSDT.Name = "txtSDT";
        this.txtSDT.Location = new System.Drawing.Point(330, 90);
        this.txtSDT.Size = new System.Drawing.Size(240, 23);
        this.txtSDT.TabIndex = 4;
        // 
        // btnThem
        // 
        this.btnThem.Name = "btnThem";
        this.btnThem.Location = new System.Drawing.Point(330, 140);
        this.btnThem.Size = new System.Drawing.Size(240, 30);
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.TabIndex = 5;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
        // 
        // btnSua
        // 
        this.btnSua.Name = "btnSua";
        this.btnSua.Location = new System.Drawing.Point(330, 178);
        this.btnSua.Size = new System.Drawing.Size(240, 30);
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = true;
        this.btnSua.TabIndex = 6;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
        // 
        // btnXoa
        // 
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Location = new System.Drawing.Point(330, 216);
        this.btnXoa.Size = new System.Drawing.Size(240, 30);
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.TabIndex = 7;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
        // 
        // btnThoat
        // 
        this.btnThoat.Name = "btnThoat";
        this.btnThoat.Location = new System.Drawing.Point(330, 316);
        this.btnThoat.Size = new System.Drawing.Size(240, 30);
        this.btnThoat.Text = "Thoát";
        this.btnThoat.UseVisualStyleBackColor = true;
        this.btnThoat.TabIndex = 8;
        this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
        // 
        // FormDanhBa
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(590, 360);
        this.Text = "Quản lý danh bạ";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Controls.Add(this.lstLienHe);
        this.Controls.Add(this.lblTen);
        this.Controls.Add(this.txtTen);
        this.Controls.Add(this.lblSDT);
        this.Controls.Add(this.txtSDT);
        this.Controls.Add(this.btnThem);
        this.Controls.Add(this.btnSua);
        this.Controls.Add(this.btnXoa);
        this.Controls.Add(this.btnThoat);
        this.Name = "FormDanhBa";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDanhBa_FormClosing);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.ListBox lstLienHe;
    private System.Windows.Forms.Label lblTen;
    private System.Windows.Forms.TextBox txtTen;
    private System.Windows.Forms.Label lblSDT;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnThoat;
}
