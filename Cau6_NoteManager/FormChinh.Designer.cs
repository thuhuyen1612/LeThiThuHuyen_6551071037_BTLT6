namespace Cau6_NoteManager;

partial class FormChinh
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
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.mnuTep = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuMoGhiChuMoi = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuSapXepCuaSo = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuXepTang = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuXepNgang = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuXepDoc = new System.Windows.Forms.ToolStripMenuItem();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.lblSoGhiChu = new System.Windows.Forms.ToolStripStatusLabel();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Size = new System.Drawing.Size(900, 24);
        this.menuStrip1.Text = "menuStrip1";
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuTep, this.mnuCuaSo });
        // 
        // mnuTep
        // 
        this.mnuTep.Name = "mnuTep";
        this.mnuTep.Text = "Tệp";
        this.mnuTep.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuMoGhiChuMoi, this.mnuSapXepCuaSo, this.mnuThoat });
        // 
        // mnuMoGhiChuMoi
        // 
        this.mnuMoGhiChuMoi.Name = "mnuMoGhiChuMoi";
        this.mnuMoGhiChuMoi.Text = "Mở ghi chú mới";
        this.mnuMoGhiChuMoi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        this.mnuMoGhiChuMoi.Click += new System.EventHandler(this.mnuMoGhiChuMoi_Click);
        // 
        // mnuSapXepCuaSo
        // 
        this.mnuSapXepCuaSo.Name = "mnuSapXepCuaSo";
        this.mnuSapXepCuaSo.Text = "Sắp xếp cửa sổ";
        this.mnuSapXepCuaSo.Click += new System.EventHandler(this.mnuSapXepCuaSo_Click);
        // 
        // mnuThoat
        // 
        this.mnuThoat.Name = "mnuThoat";
        this.mnuThoat.Text = "Thoát";
        this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
        // 
        // mnuCuaSo
        // 
        this.mnuCuaSo.Name = "mnuCuaSo";
        this.mnuCuaSo.Text = "Cửa sổ";
        this.mnuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuXepTang, this.mnuXepNgang, this.mnuXepDoc });
        // 
        // mnuXepTang
        // 
        this.mnuXepTang.Name = "mnuXepTang";
        this.mnuXepTang.Text = "Xếp tầng";
        this.mnuXepTang.Click += new System.EventHandler(this.mnuXepTang_Click);
        // 
        // mnuXepNgang
        // 
        this.mnuXepNgang.Name = "mnuXepNgang";
        this.mnuXepNgang.Text = "Xếp ngang";
        this.mnuXepNgang.Click += new System.EventHandler(this.mnuXepNgang_Click);
        // 
        // mnuXepDoc
        // 
        this.mnuXepDoc.Name = "mnuXepDoc";
        this.mnuXepDoc.Text = "Xếp dọc";
        this.mnuXepDoc.Click += new System.EventHandler(this.mnuXepDoc_Click);
        // 
        // statusStrip1
        // 
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Location = new System.Drawing.Point(0, 428);
        this.statusStrip1.Size = new System.Drawing.Size(900, 22);
        this.statusStrip1.Text = "statusStrip1";
        this.statusStrip1.TabIndex = 9;
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblSoGhiChu });
        // 
        // lblSoGhiChu
        // 
        this.lblSoGhiChu.Name = "lblSoGhiChu";
        this.lblSoGhiChu.Text = "Số ghi chú đang mở: 0";
        // 
        // FormChinh
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 450);
        this.Text = "Note Manager - Quản lý ghi chú công việc";
        this.IsMdiContainer = true;
        this.MainMenuStrip = this.menuStrip1;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Controls.Add(this.menuStrip1);
        this.Controls.Add(this.statusStrip1);
        this.Name = "FormChinh";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuTep;
    private System.Windows.Forms.ToolStripMenuItem mnuMoGhiChuMoi;
    private System.Windows.Forms.ToolStripMenuItem mnuSapXepCuaSo;
    private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
    private System.Windows.Forms.ToolStripMenuItem mnuXepTang;
    private System.Windows.Forms.ToolStripMenuItem mnuXepNgang;
    private System.Windows.Forms.ToolStripMenuItem mnuXepDoc;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblSoGhiChu;
}
