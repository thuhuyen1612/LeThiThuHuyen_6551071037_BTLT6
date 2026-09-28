namespace Cau5_FormBanVe;

public partial class FormBanVe : Form
{
    private const string GiaVe = "75.000đ";

    public FormBanVe()
    {
        InitializeComponent();
    }

    private void btnChonGhe_Click(object sender, EventArgs e)
    {
        // ShowDialog() chặn tương tác với form chính cho đến khi dialog đóng.
        using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
        {
            if (dlg.ShowDialog(this) == DialogResult.OK)
                txtGheDaChon.Text = dlg.GheChon;
        }
    }

    private void btnDatVe_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
        {
            CanhBao("Vui lòng nhập tên khách.");
            txtTenKhach.Focus();
            return;
        }
        if (cboPhim.SelectedIndex < 0)
        {
            CanhBao("Vui lòng chọn phim.");
            cboPhim.Focus();
            return;
        }
        if (cboSuatChieu.SelectedIndex < 0)
        {
            CanhBao("Vui lòng chọn suất chiếu.");
            cboSuatChieu.Focus();
            return;
        }
        if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
        {
            CanhBao("Vui lòng chọn ghế (bấm nút \"Chọn ghế\").");
            btnChonGhe.Focus();
            return;
        }

        MessageBox.Show(
            "Đặt vé thành công!\n\n" +
            "Khách hàng: " + txtTenKhach.Text.Trim() + "\n" +
            "Phim: " + cboPhim.Text + "\n" +
            "Suất chiếu: " + cboSuatChieu.Text + "\n" +
            "Ghế: " + txtGheDaChon.Text + "\n" +
            "Giá: " + GiaVe + "/vé",
            "Xác nhận đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        // Hủy thao tác đặt vé: đưa form về trạng thái ban đầu.
        txtTenKhach.Clear();
        cboPhim.SelectedIndex = -1;
        cboSuatChieu.SelectedIndex = -1;
        txtGheDaChon.Clear();
        txtTenKhach.Focus();
    }

    private static void CanhBao(string noiDung)
    {
        MessageBox.Show(noiDung, "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
