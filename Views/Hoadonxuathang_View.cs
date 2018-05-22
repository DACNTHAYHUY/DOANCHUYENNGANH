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
    public partial class Hoadonxuathang_View : Form
    {
        public Hoadonxuathang_View()
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
            txtMahdx.Text = "";
            cbManv.Text = "";
        }
        Nhanvien_Model nvm = new Nhanvien_Model();
        Hoadonxuathang_Controller hdxc = new Hoadonxuathang_Controller();
        Hoadonxuathang_Model hdxm = new Hoadonxuathang_Model();
        private void Hoadonxuathang_View_Load(object sender, EventArgs e)
        {
            cbManv.DataSource = nvm.LoadDulieu();
            cbManv.ValueMember = "Manv";
            cbManv.DisplayMember = "Manv";
            dgvHoadonxuat.DataSource = hdxm.LoadDulieu();
            SetButton_Open();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            thaotac = true;
            SetNull();
            SetButton_Close();
            DataTable dt = hdxm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMahdx.Text = "HDX01";
            }
            else
            {
                chuoi = Convert.ToString(dt.Rows[count - 1]["Mahdx"].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMahdx.Text = "HDX0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMahdx.Text = "HDX" + (chuoi2 + 1).ToString();
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
                if (txtMahdx.Text == "" && cbManv.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if (hdxc.Them(txtMahdx.Text, cbManv.Text, dtNgayxuat.Text) == true)
                    {
                        MessageBox.Show("Bạn đã thêm thành công");
                        Hoadonxuathang_View_Load(sender, e);
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
                if (hdxc.Sua(txtMahdx.Text, cbManv.Text, dtNgayxuat.Text) == true)
                {
                    MessageBox.Show("Bạn đã sửa thành công");
                    Hoadonxuathang_View_Load(sender, e);
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
            Hoadonxuathang_View_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdxc.Xoa(txtMahdx.Text) == true)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                }
            }
            SetNull();
            Hoadonxuathang_View_Load(sender, e);
        }

        private void dgvHoadonxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvHoadonxuat.CurrentRow.Index;
                txtMahdx.Text = dgvHoadonxuat.Rows[i].Cells[0].Value.ToString();
                cbManv.Text = dgvHoadonxuat.Rows[i].Cells[1].Value.ToString();
                dtNgayxuat.Text = dgvHoadonxuat.Rows[i].Cells[2].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt;
            dt = hdxm.LoadDulieu();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Mahdx LIKE '%{0}%'", txtTimkiem.Text);
            dgvHoadonxuat.DataSource = dv;
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
        }
        public static String Mahd;
        Chitiethoadonxh_View cthdxv = new Chitiethoadonxh_View();
        private void btXem_Click(object sender, EventArgs e)
        {
            if(txtMahdx.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần xem chi tiết");
            }
            else
            {
                Mahd = txtMahdx.Text;
                Chitiethoadonxh_View.tt = 2;
                cthdxv.ShowDialog();
            }          
        }
    }
}
