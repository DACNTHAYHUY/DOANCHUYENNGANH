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
    public partial class HoadonKCCTT : Form
    {
        public HoadonKCCTT()
        {
            InitializeComponent();
        }

        private void HoadonKCCTT_Load(object sender, EventArgs e)
        {
            txtManv.Text = Dangnhap.manv;
            rbNam.Checked = true;
        }
        Khachhang_Model khm = new Khachhang_Model();
        Hoadonbanhang_Controller hdbc = new Hoadonbanhang_Controller();
        Hoadonbanhang_Model hdbm = new Hoadonbanhang_Model();
        Khachhang_Controller khc = new Khachhang_Controller();
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
            DataTable dt1 = khm.LoadDulieu();
            int count1 = 0;
            count1 = dt1.Rows.Count;
            string chuoi1 = "";
            int chuoi21 = 0;
            if (count1 <= 0)
            {
                txtMakh.Text = "KH01";
            }
            else
            {
                chuoi1 = Convert.ToString(dt1.Rows[count1 - 1][0].ToString());
                chuoi21 = Convert.ToInt32((chuoi1.Remove(0, 3)));
                if (chuoi21 + 1 < 10)
                    txtMakh.Text = "KH0" + (chuoi21 + 1).ToString();
                else
                    if (chuoi21 + 1 < 100)
                        txtMakh.Text = "KH" + (chuoi21 + 1).ToString();
            }
        }
        public static String Mahd;
        public void Tacvu()
        {
            Matangdan();
            Mahd = txtMahdb.Text;
            Chitiethoadonbh_View.tt = 2;
            if ((txtMakh.Text == "" && txtMahdb.Text == "" && txtManv.Text == ""))
            {
                MessageBox.Show("Không thể tạo hóa đơn nếu không có hoặc thiếu dữ liệu");
            }
            else
            {
                if (rbNam.Checked == true)
                {
                    if (khc.Them(txtMakh.Text, txtTenkh.Text, rbNam.Text, "", txtSdt.Text) == true)
                    {
                        if (hdbc.Them(txtMahdb.Text, txtManv.Text, txtMakh.Text, dtNgayban.Text, "") == true)
                        {
                            MessageBox.Show("Tạo hóa đơn thành công");
                            this.Hide();
                            cthdbv.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi tạo hóa đơn không thành công");
                    }
                }
                else if (rbNu.Checked == true)
                {
                    if (khc.Them(txtMakh.Text, txtTenkh.Text, rbNam.Text, "", txtSdt.Text) == true)
                    {
                        if (hdbc.Them(txtMahdb.Text, txtManv.Text, txtMakh.Text, dtNgayban.Text, "") == true)
                        {
                            MessageBox.Show("Tạo hóa đơn thành công");
                            this.Hide();
                            cthdbv.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi tạo hóa đơn không thành công");
                    }
                }
            }
        }
        private void btTaohd_Click(object sender, EventArgs e)
        {
            this.Tacvu();
        }

        private void txtMahdb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Tacvu();
            }
        }

        private void txtTenkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Tacvu();
            }
        }

        private void rbNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Tacvu();
            }
        }

        private void txtSdt_KeyDown(object sender, KeyEventArgs e)
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
