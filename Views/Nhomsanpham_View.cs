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
    public partial class Nhomsanpham_View : Form
    {
        public Nhomsanpham_View()
        {
            InitializeComponent();
        }
        Nhomsanpham_Model nspm = new Nhomsanpham_Model();
        Nhomsanpham_Controller nspc = new Nhomsanpham_Controller();
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
            txtMansp.Text = "";
            txtTennsp.Text = "";
        }
        bool thaotac = true;
        private void Nhomsanpham_View_Load(object sender, EventArgs e)
        {
            SetButton_Open();
            dgvNhomsanpham.DataSource = nspm.LoadDulieu();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            thaotac = true;
            SetNull();
            SetButton_Close();
            DataTable dt = nspm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            if (count <= 0)
            {
                txtMansp.Text = "NSP01";
            }
            else
            {
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dt.Rows[count - 1]["Mansp"].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMansp.Text = "NSP0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMansp.Text = "NSP" + (chuoi2 + 1).ToString();
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
                if (txtMansp.Text == "" && txtTennsp.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if (nspc.Them(txtMansp.Text, txtTennsp.Text) == true)
                    {

                        MessageBox.Show("Bạn đã thêm thành công");
                        Nhomsanpham_View_Load(sender, e);
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
                if (nspc.Sua(txtMansp.Text, txtTennsp.Text) == true)
                {

                    MessageBox.Show("Bạn đã sửa thành công");
                    Nhomsanpham_View_Load(sender, e);
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
            Nhomsanpham_View_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nspc.Xoa(txtMansp.Text) == true)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                }
            }
            SetNull();
            Nhomsanpham_View_Load(sender, e);
        }

        private void dgvNhomsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvNhomsanpham.CurrentRow.Index;
                txtMansp.Text = dgvNhomsanpham.Rows[i].Cells[0].Value.ToString();
                txtTennsp.Text = dgvNhomsanpham.Rows[i].Cells[1].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt;
            dt = nspm.LoadDulieu();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Tennsp LIKE '%{0}%'", txtTimkiem.Text);
            dgvNhomsanpham.DataSource = dv;
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
        }

        
    }
}
