using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATN.Models;
using DATN.Controllers;
namespace DATN.Views
{
    public partial class Hoadonnhaphang_View : Form
    {
        public Hoadonnhaphang_View()
        {
            InitializeComponent();
        }
        bool thaotac = true;
        public void SetButton_Open()
        {
            btThem.Enabled = true;
            btHuy.Enabled = false;
            btLuu.Enabled = false;
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }
        public void SetButton_Close()
        {
            btThem.Enabled = false;
            btHuy.Enabled = true;
            btLuu.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }
        public void SetNull()
        {
            txtTongtien.Text = "";
            txtMahdn.Text = "";
            cbManv.Text = "";
        }
        Nhacungcap_Model nccm = new Nhacungcap_Model();
        Nhanvien_Model nvm = new Nhanvien_Model();
        Hoadonnhaphang_Model hdnm = new Hoadonnhaphang_Model();
        Hoadonnhaphang_Controller hdnc = new Hoadonnhaphang_Controller();
        private void Hoadonnhaphang_View_Load(object sender, EventArgs e)
        {
            cbMancc.DataSource = nccm.LoadDulieu();
            cbMancc.ValueMember = "Mancc";
            cbMancc.DisplayMember = "Tenncc";
            cbManv.DataSource = nvm.LoadDulieu();
            cbManv.ValueMember = "Manv";
            cbManv.DisplayMember = "Manv";
            dgvHoadonnhap.DataSource = hdnm.LoadDulieu();
            SetButton_Open();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            thaotac = true;
            SetNull();
            SetButton_Close();
            DataTable dt = hdnm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMahdn.Text = "HDN01";
            }
            else
            {
                chuoi = Convert.ToString(dt.Rows[count - 1]["Mahdn"].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMahdn.Text = "HDN0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMahdn.Text = "HDN" + (chuoi2 + 1).ToString();
            }           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            thaotac = false;
            SetNull();
            SetButton_Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (thaotac == true)
            {
                if (txtMahdn.Text == "" && cbManv.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if (hdnc.Them(txtMahdn.Text,cbManv.Text,dtNgaynhap.Text,txtTongtien.Text,cbMancc.SelectedValue.ToString()) == true)
                    {
                        MessageBox.Show("Bạn đã thêm thành công");
                        Hoadonnhaphang_View_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi thêm không thành công");
                        SetButton_Close();
                    }
                }
            }
            else
            {
                if (hdnc.Sua(txtMahdn.Text, cbManv.Text, dtNgaynhap.Text, txtTongtien.Text, cbMancc.SelectedValue.ToString()) == true)
                {
                    MessageBox.Show("Bạn đã sửa thành công");
                    Hoadonnhaphang_View_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi sửa không thành công");
                    SetButton_Close();
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            SetNull();
            Hoadonnhaphang_View_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdnc.Xoa(txtMahdn.Text) == true)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                }
            }
            SetNull();
            Hoadonnhaphang_View_Load(sender, e);
        }

        private void dgvHoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvHoadonnhap.CurrentRow.Index;
                cbMancc.Text = dgvHoadonnhap.Rows[i].Cells[2].Value.ToString();
                txtMahdn.Text = dgvHoadonnhap.Rows[i].Cells[0].Value.ToString();
                cbManv.Text = dgvHoadonnhap.Rows[i].Cells[1].Value.ToString();
                txtTongtien.Text = dgvHoadonnhap.Rows[i].Cells[4].Value.ToString();
                dtNgaynhap.Text = dgvHoadonnhap.Rows[i].Cells[3].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt;
            dt = hdnm.LoadDulieu();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Mahdn LIKE '%{0}%'", txtTimkiem.Text);
            dgvHoadonnhap.DataSource = dv;
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
        }
        public static String Mahd;
        Chitiethoadonnh_View cthdnv = new Chitiethoadonnh_View();
        private void btXem_Click(object sender, EventArgs e)
        {
            if (txtMahdn.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần xem chi tiết");
            }
            else
            {
                Mahd = txtMahdn.Text;
                Chitiethoadonnh_View.tt = 2;
                cthdnv.ShowDialog();
            }
            
        }
    }
}
