namespace Cau6_NoteManager;

public partial class FormChinh : Form
{
    private int _soThuTu = 0;   // đánh số tên cửa sổ ghi chú: "Ghi chú 1", "Ghi chú 2", ...

    public FormChinh()
    {
        InitializeComponent();
        CapNhatTrangThai();
    }

    // StatusStrip: hiển thị số ghi chú (form con) đang mở
    private void CapNhatTrangThai()
    {
        lblSoGhiChu.Text = "Số ghi chú đang mở: " + this.MdiChildren.Length;
    }

    // ---------- Menu "Tệp" ----------
    private void mnuMoGhiChuMoi_Click(object sender, EventArgs e)
    {
        FormGhiChu f = new FormGhiChu();
        f.Text = "Ghi chú " + (++_soThuTu);
        f.MdiParent = this;                 // gán cha MDI

        // Khi form con đóng => cập nhật lại số lượng.
        // Dùng BeginInvoke để chạy sau khi form con đã được gỡ khỏi MdiChildren.
        f.FormClosed += (s, ev) =>
        {
            if (IsHandleCreated && !IsDisposed)
                BeginInvoke(new Action(CapNhatTrangThai));
        };

        f.Show();                           // MDI Child: dùng Show(), không dùng ShowDialog()
        CapNhatTrangThai();
    }

    private void mnuSapXepCuaSo_Click(object sender, EventArgs e)
    {
        // Sắp xếp lại các biểu tượng cửa sổ con đang thu nhỏ ở đáy vùng MDI
        this.LayoutMdi(MdiLayout.ArrangeIcons);
    }

    private void mnuThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    // ---------- Menu "Cửa sổ" ----------
    private void mnuXepTang_Click(object sender, EventArgs e)
    {
        this.LayoutMdi(MdiLayout.Cascade);
    }

    private void mnuXepNgang_Click(object sender, EventArgs e)
    {
        this.LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void mnuXepDoc_Click(object sender, EventArgs e)
    {
        this.LayoutMdi(MdiLayout.TileVertical);
    }
}
