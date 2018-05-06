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
    public partial class Doimatkhau : Form
    {
        public Doimatkhau()
        {
            InitializeComponent();
        }
        Nhanvien_Model nvm = new Nhanvien_Model();
        Nhanvien_Controller nvc = new Nhanvien_Controller();
        private void Doimatkhau_Load(object sender, EventArgs e)
        {
            txtManv.Text = Dangnhap.manv;
        }

        private void btDongy_Click(object sender, EventArgs e)
        {
            if (txtMkc.Text != "" && txtMkm1.Text != "")
            {
                if (txtMkm1.Text != txtMkm2.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu mới không đúng");
                }
                else
                {
                    if (txtMkc.Text != Nhanvien_Model.mk)
                    {
                        MessageBox.Show("Bạn nhập mật khẩu cũ không đúng");
                    }
                    else
                    {
                        if (nvc.Doimatkhau(txtManv.Text, txtMkc.Text, txtMkm1.Text) == true)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xảy ra lỗi đổi mật khẩu không thành công");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Bạn chưa nhập đủ các thông tin");                
        }

        private void Doimatkhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trangchinh1.dmk = null;
        }
    }
}
