namespace Cau5_FormBanVe;

public partial class FormChonGhe : Form
{
    /// <summary>Ghế người dùng đã chọn (chỉ gán bên trong form này).</summary>
    public string GheChon { get; private set; }

    public FormChonGhe(string gheHienTai)
    {
        InitializeComponent();
        GheChon = gheHienTai ?? "";

        // Chọn sẵn ghế cũ (nếu có)
        if (!string.IsNullOrEmpty(gheHienTai))
            lstGhe.SelectedItem = gheHienTai;
    }

    private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblGheDaChon.Text = "Đang chọn: " + (lstGhe.SelectedItem != null ? lstGhe.SelectedItem.ToString() : "--");
    }

    private void btnXacNhan_Click(object sender, EventArgs e)
    {
        if (lstGhe.SelectedItem == null)
        {
            MessageBox.Show("Vui lòng chọn một ghế trước khi xác nhận!", "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;     // dialog không đóng
        }

        GheChon = lstGhe.SelectedItem.ToString();
        DialogResult = DialogResult.OK;
    }

    private void btnBoQua_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }
}
