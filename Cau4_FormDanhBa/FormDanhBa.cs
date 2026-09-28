namespace Cau4_FormDanhBa;

public partial class FormDanhBa : Form
{
    private const string PhanCach = " - ";

    // Index của liên hệ đang được sửa (-1 = đang ở chế độ thêm mới)
    private int _indexDangSua = -1;

    public FormDanhBa()
    {
        InitializeComponent();

        // Dữ liệu mẫu (giống hình minh họa)
        lstLienHe.Items.AddRange(new object[]
        {
            "Nguyễn Văn A - 0901234567",
            "Trần Thị B - 0912345678",
            "Lê Văn C - 0987654321",
            "Phạm Thị D - 0911223344",
            "Hoàng Văn E - 0922334455"
        });
    }

    // Tách "Tên - SĐT" (cắt tại dấu " - " cuối cùng)
    private static void TachLienHe(string item, out string ten, out string sdt)
    {
        int vt = item.LastIndexOf(PhanCach, StringComparison.Ordinal);
        if (vt < 0)
        {
            ten = item;
            sdt = "";
        }
        else
        {
            ten = item.Substring(0, vt);
            sdt = item.Substring(vt + PhanCach.Length);
        }
    }

    private void XoaTextBox()
    {
        txtTen.Clear();
        txtSDT.Clear();
    }

    // ---------- Thêm / Cập nhật ----------
    private void btnThem_Click(object sender, EventArgs e)
    {
        string ten = txtTen.Text.Trim();
        string sdt = txtSDT.Text.Trim();

        if (ten.Length == 0 || sdt.Length == 0)
        {
            MessageBox.Show("Vui lòng nhập đầy đủ Tên và Số điện thoại.", "Thiếu thông tin",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            (ten.Length == 0 ? txtTen : txtSDT).Focus();
            return;
        }

        string item = ten + PhanCach + sdt;

        if (_indexDangSua >= 0 && _indexDangSua < lstLienHe.Items.Count)
        {
            // Chế độ sửa: cập nhật lại item tại vị trí đang sửa
            lstLienHe.Items[_indexDangSua] = item;
            _indexDangSua = -1;
            XoaTextBox();
            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            lstLienHe.Items.Add(item);
            XoaTextBox();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // ---------- Sửa ----------
    private void btnSua_Click(object sender, EventArgs e)
    {
        if (lstLienHe.SelectedIndex < 0)
        {
            MessageBox.Show("Vui lòng chọn một liên hệ để sửa", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        TachLienHe(lstLienHe.SelectedItem.ToString(), out string ten, out string sdt);
        txtTen.Text = ten;
        txtSDT.Text = sdt;
        _indexDangSua = lstLienHe.SelectedIndex;   // nhớ vị trí, bấm "Thêm" để cập nhật
        txtTen.Focus();
    }

    // ---------- Xóa ----------
    private void btnXoa_Click(object sender, EventArgs e)
    {
        int index = lstLienHe.SelectedIndex;
        if (index < 0)
        {
            MessageBox.Show("Vui lòng chọn một liên hệ để xóa", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        TachLienHe(lstLienHe.SelectedItem.ToString(), out string ten, out string _);

        DialogResult kq = MessageBox.Show(
            "Bạn có chắc muốn xóa liên hệ " + ten + "? Thao tác này không thể hoàn tác!",
            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (kq != DialogResult.Yes)
            return;

        lstLienHe.Items.RemoveAt(index);

        // Giữ _indexDangSua đúng sau khi xóa
        if (_indexDangSua == index)
        {
            _indexDangSua = -1;
            XoaTextBox();
        }
        else if (_indexDangSua > index)
        {
            _indexDangSua--;
        }

        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // ---------- Thoát ----------
    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (txtTen.Text.Length == 0 && txtSDT.Text.Length == 0)
            return;

        DialogResult kq = MessageBox.Show("Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
            "Xác nhận thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

        if (kq == DialogResult.Cancel)
            e.Cancel = true;        // ở lại form
        else if (kq == DialogResult.No)
            XoaTextBox();           // xóa TextBox rồi thoát
        // Yes: thoát luôn
    }
}
