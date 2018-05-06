using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DATN.Models;
using DATN.Controllers;
namespace DATN.Views
{
    public partial class Nhacungcap_View : Form
    {
        Nhacungcap_Controller nccc = new Nhacungcap_Controller();
        Nhacungcap_Model nccm = new Nhacungcap_Model();
        public Nhacungcap_View()
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
            txtMancc.Text = "";
            txtTenncc.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
        }
        bool thaotac = true;
        private void btSua_Click(object sender, EventArgs e)
        {
            thaotac = false;
            SetButton_Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            thaotac = true;
            SetNull();
            SetButton_Close();
            DataTable dt = nccm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if(count<=0)
            {
                txtMancc.Text = "NCC01";
            }
            else
            {
                chuoi = Convert.ToString(dt.Rows[count - 1]["Mancc"].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMancc.Text = "NCC0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMancc.Text = "NCC" + (chuoi2 + 1).ToString();
            }          
        }

        private void Nhacungcap_View_Load(object sender, EventArgs e)
        {
            SetButton_Open();
            dgvNhacungcap.DataSource = nccm.LoadDulieu();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (thaotac == true)
            {
                if (txtMancc.Text == "" && txtTenncc.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if (nccc.Them(txtMancc.Text, txtTenncc.Text, txtDiachi.Text, txtSdt.Text) == true)
                    {

                        MessageBox.Show("Bạn đã thêm thành công");
                        Nhacungcap_View_Load(sender, e);
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
                if (nccc.Sua(txtMancc.Text, txtTenncc.Text, txtDiachi.Text, txtSdt.Text) == true)
                {

                    MessageBox.Show("Bạn đã sửa thành công");
                    Nhacungcap_View_Load(sender, e);
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
            Nhacungcap_View_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nccc.Xoa(txtMancc.Text) == true)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                }
            }
            SetNull();
            Nhacungcap_View_Load(sender, e);
        }

        private void dgvNhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvNhacungcap.CurrentRow.Index;
                txtMancc.Text = dgvNhacungcap.Rows[i].Cells["Mancc"].Value.ToString();
                txtTenncc.Text = dgvNhacungcap.Rows[i].Cells["Tenncc"].Value.ToString();
                txtDiachi.Text = dgvNhacungcap.Rows[i].Cells["Diachi"].Value.ToString();
                txtSdt.Text = dgvNhacungcap.Rows[i].Cells["Sodienthoai"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }

        private void Nhacungcap_View_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trangchinh1.ncc = null;
        }
    }
}
