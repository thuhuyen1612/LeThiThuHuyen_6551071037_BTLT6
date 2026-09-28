using System.ComponentModel;

namespace Cau6_NoteManager;

public partial class FormGhiChu : Form
{
    private const int GioiHanKyTu = 500;
    private const int GioiHanTieuDe = 50;

    private bool _daThayDoi;        // nội dung đã bị thay đổi chưa lưu?
    private Color _mauNenNutGoc;    // màu nền gốc của nút Lưu (để trả lại sau hiệu ứng hover)

    public FormGhiChu()
    {
        InitializeComponent();
        cboMucDoUuTien.SelectedIndex = 1;               // mặc định: Trung bình
        _mauNenNutGoc = btnLuuGhiChu.BackColor;
        CapNhatBoDem();
        _daThayDoi = false;                             // khởi tạo xong => chưa có thay đổi
    }

    // =================== ③ KEYBOARD & MOUSE ===================

    // KeyPreview = true (đặt trong Designer) => form nhận phím trước các control con
    private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.S)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;
            btnLuuGhiChu.PerformClick();
        }
        else if (e.KeyCode == Keys.Escape)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;

            if (!_daThayDoi)
            {
                Close();
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Nội dung ghi chú đã thay đổi. Bạn có chắc muốn đóng ghi chú này không?",
                "Đóng ghi chú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                Close();
        }
    }

    // Giới hạn tối đa 500 ký tự trong nội dung
    private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
    {
        bool kyTuDieuKhien = char.IsControl(e.KeyChar);     // Backspace, Enter, ...
        bool dangBoiDen = txtNoiDung.SelectionLength > 0;   // gõ đè lên vùng chọn thì không tăng độ dài

        if (!kyTuDieuKhien && !dangBoiDen && txtNoiDung.TextLength >= GioiHanKyTu)
            e.Handled = true;                               // chặn ký tự thêm
    }

    private void txtNoiDung_TextChanged(object sender, EventArgs e)
    {
        CapNhatBoDem();
        _daThayDoi = true;
    }

    private void CapNhatBoDem()
    {
        lblDem.Text = txtNoiDung.TextLength + "/" + GioiHanKyTu;
        lblDem.ForeColor = txtNoiDung.TextLength >= GioiHanKyTu ? Color.Firebrick : SystemColors.ControlText;
    }

    // Dùng chung cho txtTieuDe.TextChanged và cboMucDoUuTien.SelectedIndexChanged
    private void NoiDungThayDoi(object sender, EventArgs e)
    {
        _daThayDoi = true;
    }

    // Double-click vào tiêu đề: phóng to / thu nhỏ cửa sổ ghi chú con
    private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        this.WindowState = (this.WindowState == FormWindowState.Maximized)
            ? FormWindowState.Normal
            : FormWindowState.Maximized;
    }

    // Hiệu ứng hover cho nút Lưu
    private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
    {
        btnLuuGhiChu.BackColor = Color.LightSkyBlue;
    }

    private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
    {
        btnLuuGhiChu.BackColor = _mauNenNutGoc;
    }

    // =================== ④ VALIDATING / VALIDATED ===================

    private void txtTieuDe_Validating(object sender, CancelEventArgs e)
    {
        string tieuDe = txtTieuDe.Text.Trim();
        string loi = null;

        if (tieuDe.Length == 0)
            loi = "Tiêu đề không được để trống";
        else if (tieuDe.Length > GioiHanTieuDe)
            loi = "Tiêu đề tối đa " + GioiHanTieuDe + " ký tự (hiện có " + tieuDe.Length + ")";

        if (loi != null)
        {
            e.Cancel = true;
            errorProvider1.SetError(txtTieuDe, loi);
            txtTieuDe.BackColor = Color.MistyRose;
        }
    }

    private void txtTieuDe_Validated(object sender, EventArgs e)
    {
        txtTieuDe.BackColor = Color.White;
        errorProvider1.SetError(txtTieuDe, "");
    }

    private void btnLuuGhiChu_Click(object sender, EventArgs e)
    {
        // Kích hoạt Validating của toàn bộ control trên form; false = còn lỗi
        if (!this.ValidateChildren())
            return;

        this.Text = txtTieuDe.Text;     // đổi tiêu đề cửa sổ con
        _daThayDoi = false;

        MessageBox.Show("Đã lưu ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
