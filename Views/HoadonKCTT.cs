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
    public partial class HoadonKCTT : Form
    {
        public HoadonKCTT()
        {
            InitializeComponent();
        }
        Khachhang_Model khm = new Khachhang_Model();
        Hoadonbanhang_Controller hdbc = new Hoadonbanhang_Controller();
        Hoadonbanhang_Model hdbm = new Hoadonbanhang_Model();
        private void HoadonKCTT_Load(object sender, EventArgs e)
        {
            cbMakh.DataSource = khm.LoadDulieu();
            cbMakh.ValueMember = "Makh";
            cbMakh.DisplayMember = "Makh";
            txtManv.Text = Dangnhap.manv;
        }
        Chitiethoadonbh_View cthdbv = new Chitiethoadonbh_View();
        public void Matangdan()
        {
            DataTable dt = hdbm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMahdb.Text = "HDB01";
            }
            else
            {
                chuoi = Convert.ToString(dt.Rows[count - 1][0].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMahdb.Text = "HDB0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMahdb.Text = "HDB" + (chuoi2 + 1).ToString();
            }
        }
        public static String Mahd;
        public void Tacvu()
        {
            Matangdan();
            Mahd = txtMahdb.Text;
            Chitiethoadonbh_View.tt = 1;
            if (txtMahdb.Text == "" && txtManv.Text == "" && cbMakh.Text == "")
            {
                MessageBox.Show("Không thể tạo hóa đơn nếu thiếu dữ liệu");
            }
            else
            {
                if (hdbc.Them(txtMahdb.Text, txtManv.Text, cbMakh.Text, dtNgayban.Text, "") == true)
                {
                    MessageBox.Show("Tạo hóa đơn thành công");
                    this.Hide();
                    cthdbv.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi tạo hóa đơn không thành công");
                }

            }
        }
        private void btTaohd_Click(object sender, EventArgs e)
        {
            this.Tacvu();
        }

        private void cbMakh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Tacvu();
            }
        }

        private void dtNgayban_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Tacvu();
            }
        }
    }
}

