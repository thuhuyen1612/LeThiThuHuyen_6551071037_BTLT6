using System.Globalization;

namespace Cau3_FormNhapDiem;

public partial class FormNhapDiem : Form
{
    public FormNhapDiem()
    {
        InitializeComponent();
        DangKyEnterChuyenField();
    }

    /// <summary>
    /// Duyệt tất cả TextBox trên form, đăng ký KeyPress: Enter => chuyển sang field kế tiếp
    /// (riêng txtAnh: Enter => bấm nút Lưu).
    /// </summary>
    private void DangKyEnterChuyenField()
    {
        foreach (Control c in Controls)
        {
            if (c is TextBox tb)
                tb.KeyPress += TextBox_KeyPress_Enter;
        }
    }

    private void TextBox_KeyPress_Enter(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != (char)Keys.Enter)
            return;

        e.Handled = true;   // chặn tiếng "beep" mặc định của Enter

        if (sender == txtAnh)
            btnLuu.PerformClick();
        else
            SelectNextControl((Control)sender, true, true, true, true);
    }

    // Sự kiện Enter (nhận focus) của txtToan, txtVan, txtAnh: bôi xanh toàn bộ nội dung cũ.
    private void DiemTextBox_Enter(object sender, EventArgs e)
    {
        TextBox tb = (TextBox)sender;
        // BeginInvoke để SelectAll chạy sau khi focus/click xử lý xong, không bị mất bôi chọn.
        BeginInvoke(new Action(tb.SelectAll));
    }

    private static bool TryParseDiem(string s, out decimal diem)
    {
        s = s.Trim().Replace(',', '.');
        return decimal.TryParse(s, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out diem);
    }

    // Kiểm tra 1 ô điểm: hợp lệ => xóa lỗi; sai => hiện ErrorProvider đúng field.
    private bool KiemTraDiem(TextBox txt, string tenMon, out decimal diem)
    {
        bool ok = TryParseDiem(txt.Text, out diem) && diem >= 0.0m && diem <= 10.0m;
        errorProvider1.SetError(txt, ok ? "" : "Điểm " + tenMon + " phải là số từ 0.0 đến 10.0");
        return ok;
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        string maHS = txtMaHS.Text.Trim();
        string hoTen = txtHoTen.Text.Trim();

        bool okMa = maHS.Length > 0;
        errorProvider1.SetError(txtMaHS, okMa ? "" : "Mã học sinh không được để trống");
        bool okTen = hoTen.Length > 0;
        errorProvider1.SetError(txtHoTen, okTen ? "" : "Họ tên không được để trống");

        // Kiểm tra cả 3 điểm (không dừng ở lỗi đầu tiên để hiện lỗi đúng từng field)
        bool okToan = KiemTraDiem(txtToan, "Toán", out decimal toan);
        bool okVan = KiemTraDiem(txtVan, "Văn", out decimal van);
        bool okAnh = KiemTraDiem(txtAnh, "Anh", out decimal anh);

        if (!(okMa && okTen && okToan && okVan && okAnh))
        {
            // Đưa focus về field lỗi đầu tiên
            if (!okMa) txtMaHS.Focus();
            else if (!okTen) txtHoTen.Focus();
            else if (!okToan) txtToan.Focus();
            else if (!okVan) txtVan.Focus();
            else txtAnh.Focus();
            return;
        }

        // Hợp lệ => thêm dòng vào ListBox theo đúng định dạng yêu cầu
        string dong = FormattableString.Invariant(
            $"{maHS} | {hoTen} | T:{toan:0.0} V:{van:0.0} A:{anh:0.0}");
        lstKetQua.Items.Add(dong);
        lstKetQua.TopIndex = lstKetQua.Items.Count - 1;

        XoaTrangForm();     // xóa trắng form, focus về txtMaHS
    }

    private void btnXoaTrang_Click(object sender, EventArgs e)
    {
        XoaTrangForm();
    }

    private void XoaTrangForm()
    {
        txtMaHS.Clear();
        txtHoTen.Clear();
        txtToan.Clear();
        txtVan.Clear();
        txtAnh.Clear();
        errorProvider1.Clear();
        txtMaHS.Focus();
    }
}
