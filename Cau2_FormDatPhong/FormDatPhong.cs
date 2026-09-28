using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Cau2_FormDatPhong;

public partial class FormDatPhong : Form
{
    private const string DinhDangNgay = "dd/MM/yyyy";

    public FormDatPhong()
    {
        InitializeComponent();
    }

    // ---------- Hàm dùng chung ----------
    private void BaoLoi(TextBox txt, CancelEventArgs e, string thongBao)
    {
        e.Cancel = true;                            // giữ focus lại ở field sai
        errorProvider1.SetError(txt, thongBao);     // icon lỗi + tooltip
        txt.BackColor = Color.MistyRose;            // nền đỏ nhạt
    }

    private void BaoDung(TextBox txt)
    {
        errorProvider1.SetError(txt, "");
        txt.BackColor = Color.Honeydew;             // nền xanh lá nhạt
    }

    private static bool TryParseNgay(string s, out DateTime ngay)
    {
        return DateTime.TryParseExact(s.Trim(), DinhDangNgay, CultureInfo.InvariantCulture, DateTimeStyles.None, out ngay);
    }

    // ---------- Validating ----------
    private void txtHoTen_Validating(object sender, CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            BaoLoi(txtHoTen, e, "Họ tên không được để trống");
        else
            BaoDung(txtHoTen);
    }

    private void txtCCCD_Validating(object sender, CancelEventArgs e)
    {
        if (!Regex.IsMatch(txtCCCD.Text.Trim(), "^[0-9]{12}$"))
            BaoLoi(txtCCCD, e, "Số CCCD phải gồm đúng 12 chữ số");
        else
            BaoDung(txtCCCD);
    }

    private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
    {
        if (!TryParseNgay(txtNgayNhan.Text, out DateTime ngayNhan))
            BaoLoi(txtNgayNhan, e, "Ngày nhận phòng phải đúng định dạng dd/MM/yyyy");
        else if (ngayNhan.Date < DateTime.Today)
            BaoLoi(txtNgayNhan, e, "Ngày nhận phòng phải từ hôm nay trở đi");
        else
            BaoDung(txtNgayNhan);
    }

    private void txtNgayTra_Validating(object sender, CancelEventArgs e)
    {
        if (!TryParseNgay(txtNgayTra.Text, out DateTime ngayTra))
        {
            BaoLoi(txtNgayTra, e, "Ngày trả phòng phải đúng định dạng dd/MM/yyyy");
        }
        else if (!TryParseNgay(txtNgayNhan.Text, out DateTime ngayNhan))
        {
            BaoLoi(txtNgayTra, e, "Hãy nhập ngày nhận phòng hợp lệ trước");
        }
        else if (ngayTra.Date <= ngayNhan.Date)
        {
            BaoLoi(txtNgayTra, e, "Ngày trả phải sau ngày nhận");
        }
        else
        {
            BaoDung(txtNgayTra);
        }
    }

    private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
    {
        if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out int n) || n < 1 || n > 4)
            BaoLoi(txtSoNguoiLon, e, "Số người lớn phải là số nguyên từ 1 đến 4");
        else
            BaoDung(txtSoNguoiLon);
    }

    private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
    {
        if (!int.TryParse(txtSoTreEm.Text.Trim(), out int n) || n < 0 || n > 3)
            BaoLoi(txtSoTreEm, e, "Số trẻ em phải là số nguyên từ 0 đến 3");
        else
            BaoDung(txtSoTreEm);
    }

    // ---------- Validated (dùng chung cho 6 TextBox) ----------
    private void Txt_Validated(object sender, EventArgs e)
    {
        ((TextBox)sender).BackColor = Color.Honeydew;
    }

    // ---------- Đặt phòng ----------
    private void btnDatPhong_Click(object sender, EventArgs e)
    {
        // Các field chưa từng được focus sẽ chưa được kiểm tra -> kiểm tra lại toàn bộ.
        if (!ValidateChildren())
        {
            foreach (TextBox tb in new[] { txtHoTen, txtCCCD, txtNgayNhan, txtNgayTra, txtSoNguoiLon, txtSoTreEm })
            {
                if (errorProvider1.GetError(tb) != "")
                {
                    tb.Focus();
                    break;
                }
            }
            return;
        }

        DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text.Trim(), DinhDangNgay, CultureInfo.InvariantCulture);
        DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text.Trim(), DinhDangNgay, CultureInfo.InvariantCulture);
        int soDem = (ngayTra - ngayNhan).Days;

        MessageBox.Show(
            "Đặt phòng thành công!\n\n" +
            "Khách hàng: " + txtHoTen.Text.Trim() + "\n" +
            "Nhận phòng: " + txtNgayNhan.Text.Trim() + "\n" +
            "Trả phòng: " + txtNgayTra.Text.Trim() + "\n" +
            "Số đêm: " + soDem + "\n" +
            "Số người lớn: " + txtSoNguoiLon.Text.Trim() + " | Trẻ em: " + txtSoTreEm.Text.Trim(),
            "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void txtHoTen_TextChanged(object sender, EventArgs e)
    {

    }
}
