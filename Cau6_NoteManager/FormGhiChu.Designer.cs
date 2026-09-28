namespace Cau6_NoteManager;

partial class FormGhiChu
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
        this.lblTieuDeForm = new System.Windows.Forms.Label();
        this.lblTieuDe = new System.Windows.Forms.Label();
        this.txtTieuDe = new System.Windows.Forms.TextBox();
        this.lblNoiDung = new System.Windows.Forms.Label();
        this.lblDem = new System.Windows.Forms.Label();
        this.txtNoiDung = new System.Windows.Forms.TextBox();
        this.lblUuTien = new System.Windows.Forms.Label();
        this.cboMucDoUuTien = new System.Windows.Forms.ComboBox();
        this.btnLuuGhiChu = new System.Windows.Forms.Button();
        this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        this.SuspendLayout();
        // 
        // lblTieuDeForm
        // 
        this.lblTieuDeForm.Name = "lblTieuDeForm";
        this.lblTieuDeForm.BackColor = System.Drawing.Color.SteelBlue;
        this.lblTieuDeForm.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTieuDeForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTieuDeForm.ForeColor = System.Drawing.Color.White;
        this.lblTieuDeForm.Location = new System.Drawing.Point(0, 0);
        this.lblTieuDeForm.Size = new System.Drawing.Size(460, 32);
        this.lblTieuDeForm.Text = "GHI CHÚ CÔNG VIỆC  (nhấp đúp để phóng to / thu nhỏ)";
        this.lblTieuDeForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblTieuDeForm.TabStop = false;
        this.lblTieuDeForm.TabIndex = 0;
        this.lblTieuDeForm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblTieuDeForm_MouseDoubleClick);
        // 
        // lblTieuDe
        // 
        this.lblTieuDe.Name = "lblTieuDe";
        this.lblTieuDe.AutoSize = true;
        this.lblTieuDe.Location = new System.Drawing.Point(15, 45);
        this.lblTieuDe.Text = "Tiêu đề";
        this.lblTieuDe.TabStop = false;
        this.lblTieuDe.TabIndex = 1;
        // 
        // txtTieuDe
        // 
        this.txtTieuDe.Name = "txtTieuDe";
        this.txtTieuDe.Location = new System.Drawing.Point(15, 65);
        this.txtTieuDe.Size = new System.Drawing.Size(430, 23);
        this.txtTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        this.txtTieuDe.TabIndex = 2;
        this.txtTieuDe.TextChanged += new System.EventHandler(this.NoiDungThayDoi);
        this.txtTieuDe.Validating += new System.ComponentModel.CancelEventHandler(this.txtTieuDe_Validating);
        this.txtTieuDe.Validated += new System.EventHandler(this.txtTieuDe_Validated);
        // 
        // lblNoiDung
        // 
        this.lblNoiDung.Name = "lblNoiDung";
        this.lblNoiDung.AutoSize = true;
        this.lblNoiDung.Location = new System.Drawing.Point(15, 100);
        this.lblNoiDung.Text = "Nội dung";
        this.lblNoiDung.TabStop = false;
        this.lblNoiDung.TabIndex = 3;
        // 
        // lblDem
        // 
        this.lblDem.Name = "lblDem";
        this.lblDem.AutoSize = false;
        this.lblDem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        this.lblDem.Location = new System.Drawing.Point(345, 100);
        this.lblDem.Size = new System.Drawing.Size(100, 15);
        this.lblDem.Text = "0/500";
        this.lblDem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.lblDem.TabStop = false;
        this.lblDem.TabIndex = 4;
        // 
        // txtNoiDung
        // 
        this.txtNoiDung.Name = "txtNoiDung";
        this.txtNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        this.txtNoiDung.Location = new System.Drawing.Point(15, 120);
        this.txtNoiDung.MaxLength = 500;
        this.txtNoiDung.Multiline = true;
        this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtNoiDung.Size = new System.Drawing.Size(430, 150);
        this.txtNoiDung.TabIndex = 5;
        this.txtNoiDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoiDung_KeyPress);
        this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
        // 
        // lblUuTien
        // 
        this.lblUuTien.Name = "lblUuTien";
        this.lblUuTien.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        this.lblUuTien.AutoSize = true;
        this.lblUuTien.Location = new System.Drawing.Point(15, 282);
        this.lblUuTien.Text = "Priority (Mức độ ưu tiên):";
        this.lblUuTien.TabStop = false;
        this.lblUuTien.TabIndex = 6;
        // 
        // cboMucDoUuTien
        // 
        this.cboMucDoUuTien.Name = "cboMucDoUuTien";
        this.cboMucDoUuTien.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        this.cboMucDoUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboMucDoUuTien.FormattingEnabled = true;
        this.cboMucDoUuTien.Location = new System.Drawing.Point(15, 302);
        this.cboMucDoUuTien.Size = new System.Drawing.Size(160, 23);
        this.cboMucDoUuTien.TabIndex = 7;
        this.cboMucDoUuTien.SelectedIndexChanged += new System.EventHandler(this.NoiDungThayDoi);
        this.cboMucDoUuTien.Items.AddRange(new object[] {
            "Thấp",
            "Trung bình",
            "Cao"});
        // 
        // btnLuuGhiChu
        // 
        this.btnLuuGhiChu.Name = "btnLuuGhiChu";
        this.btnLuuGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        this.btnLuuGhiChu.BackColor = System.Drawing.Color.LightGray;
        this.btnLuuGhiChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLuuGhiChu.Location = new System.Drawing.Point(355, 300);
        this.btnLuuGhiChu.Size = new System.Drawing.Size(90, 28);
        this.btnLuuGhiChu.Text = "Lưu";
        this.btnLuuGhiChu.UseVisualStyleBackColor = false;
        this.btnLuuGhiChu.TabIndex = 8;
        this.btnLuuGhiChu.Click += new System.EventHandler(this.btnLuuGhiChu_Click);
        this.btnLuuGhiChu.MouseEnter += new System.EventHandler(this.btnLuuGhiChu_MouseEnter);
        this.btnLuuGhiChu.MouseLeave += new System.EventHandler(this.btnLuuGhiChu_MouseLeave);
        // 
        // errorProvider1
        // 
        this.errorProvider1.ContainerControl = this;
        // 
        // FormGhiChu
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(460, 345);
        this.Text = "Ghi chú";
        this.KeyPreview = true;
        this.Controls.Add(this.lblTieuDeForm);
        this.Controls.Add(this.lblTieuDe);
        this.Controls.Add(this.txtTieuDe);
        this.Controls.Add(this.lblNoiDung);
        this.Controls.Add(this.lblDem);
        this.Controls.Add(this.txtNoiDung);
        this.Controls.Add(this.lblUuTien);
        this.Controls.Add(this.cboMucDoUuTien);
        this.Controls.Add(this.btnLuuGhiChu);
        this.Name = "FormGhiChu";
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGhiChu_KeyDown);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDeForm;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.TextBox txtTieuDe;
    private System.Windows.Forms.Label lblNoiDung;
    private System.Windows.Forms.Label lblDem;
    private System.Windows.Forms.TextBox txtNoiDung;
    private System.Windows.Forms.Label lblUuTien;
    private System.Windows.Forms.ComboBox cboMucDoUuTien;
    private System.Windows.Forms.Button btnLuuGhiChu;
    private System.Windows.Forms.ErrorProvider errorProvider1;
}
