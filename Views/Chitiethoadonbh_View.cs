using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATN.Controllers;
using DATN.Models;
namespace DATN.Views
{
    public partial class Chitiethoadonbh_View : Form
    {
        public Chitiethoadonbh_View()
        {
            InitializeComponent();
        }
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
            txtSoluong.Text = "";
            txtMacthdb.Text = "";
            cbMasp.Text = "";
        }
        bool thaotac = true;
        Sanpham_Model spm = new Sanpham_Model();
        Chitiethoadonbh_Controller cthdbc = new Chitiethoadonbh_Controller();
        Chitiethoadonbh_Model cthdbm = new Chitiethoadonbh_Model();
        public static int tt;
        private void Chitiethoadonbh_View_Load(object sender, EventArgs e)
        {
            SetButton_Open();
            cbMasp.DataSource = spm.LoadDulieu();
            cbMasp.DisplayMember = "Tensp";
            cbMasp.ValueMember = "Masp";
            if (tt ==1)
            {
                txtMahdb.Enabled = false;
                txtMahdb.Text = HoadonKCTT.Mahd;
                dgvHoadonban.DataSource = cthdbm.LoadDulieu1();
            }
            else
            {
                if (tt == 2)
                {
                    txtMahdb.Enabled = false;
                    txtMahdb.Text = HoadonKCCTT.Mahd;
                    dgvHoadonban.DataSource = cthdbm.LoadDulieu2();
                }
                else
                {
                    if(tt==3)
                    {
                        txtMahdb.Enabled = false;
                        txtMahdb.Text=ChinhsuaHoadon.Mahd;
                        dgvHoadonban.DataSource=cthdbm.LoadDulieu3();
                    }
                    else
                        dgvHoadonban.DataSource = cthdbm.LoadDulieu();
                }                
            }                           
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            thaotac = true;
            SetNull();
            SetButton_Close();
            DataTable dt = cthdbm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMacthdb.Text = "CTHDB01";
            }
            else
            {
                chuoi = Convert.ToString(dt.Rows[count - 1][0].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 5)));
                if (chuoi2 + 1 < 10)
                    txtMacthdb.Text = "CTHDB0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMacthdb.Text = "CTHDB" + (chuoi2 + 1).ToString();
            }           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            thaotac = false;
            SetButton_Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (thaotac == true)
            {
                if (txtMahdb.Text == "" && cbMasp.Text == "" && txtSoluong.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if (cthdbc.Them(txtMacthdb.Text,cbMasp.SelectedValue.ToString(),txtMahdb.Text,txtDongia.Text,txtThanhtien.Text,txtSoluong.Text) == true)
                    {
                        MessageBox.Show("Bạn đã thêm thành công");
                        Chitiethoadonbh_View_Load(sender, e);
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
                if (cthdbc.Sua(txtMacthdb.Text, cbMasp.SelectedValue.ToString(), txtMahdb.Text, txtDongia.Text, txtThanhtien.Text, txtSoluong.Text) == true)
                {
                    MessageBox.Show("Bạn đã sửa thành công");
                    Chitiethoadonbh_View_Load(sender, e);
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
            Chitiethoadonbh_View_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (cthdbc.Xoa(txtMacthdb.Text) == true)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                }
            }
            SetNull();
            Chitiethoadonbh_View_Load(sender, e);
        }

        private void dgvHoadonban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvHoadonban.CurrentRow.Index;
                cbMasp.Text = dgvHoadonban.Rows[i].Cells["Masp"].Value.ToString();
                txtMahdb.Text = dgvHoadonban.Rows[i].Cells["Mahdb"].Value.ToString();
                txtDongia.Text = dgvHoadonban.Rows[i].Cells["Dongia"].Value.ToString();
                txtThanhtien.Text = dgvHoadonban.Rows[i].Cells["Thanhtien"].Value.ToString();
                txtSoluong.Text = dgvHoadonban.Rows[i].Cells["Soluong"].Value.ToString();
                txtMacthdb.Text = dgvHoadonban.Rows[i].Cells["Macthdb"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }

       
    }
}
