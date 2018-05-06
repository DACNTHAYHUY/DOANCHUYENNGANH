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
    public partial class Capnhatthongtin : Form
    {
        public Capnhatthongtin()
        {
            InitializeComponent();
        }
        Nhanvien_Controller nvc = new Nhanvien_Controller();
        private void btDongy_Click(object sender, EventArgs e)
        {
            if (txtManv.Text != "" && txtDiachi.Text != "" && txtHoten.Text != "" && txtSdt.Text!="" || rbNam.Checked == false || rbNu.Checked == false)
            {
                if(rbNam.Checked==true)
                {
                    if (nvc.Sua(txtManv.Text, Nhanvien_Model.mk, txtHoten.Text, rbNam.Text, txtDiachi.Text, txtSdt.Text, Nhanvien_Model.chucvu) == true)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi cập nhật thông tin không thành công");
                    }
                }
                else
                {
                    if (rbNu.Checked == true)
                    {
                        if (nvc.Sua(txtManv.Text, Nhanvien_Model.mk, txtHoten.Text, rbNu.Text, txtDiachi.Text, txtSdt.Text, Nhanvien_Model.chucvu) == true)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xảy ra lỗi cập nhật thông tin không thành công");
                        }
                    }
                }              
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ các thông tin");
            }
        }

        private void Capnhatthongtin_Load(object sender, EventArgs e)
        {
            txtManv.Text = Dangnhap.manv;
            txtHoten.Text = Nhanvien_Model.hoten;
            txtDiachi.Text = Nhanvien_Model.diachi;
            txtSdt.Text = Nhanvien_Model.sodienthoai;
            if(Nhanvien_Model.gioitinh=="Nam")
            {
                rbNam.Checked = true;
            }
            else
                if(Nhanvien_Model.gioitinh=="Nữ")
                {
                    rbNu.Checked = true;
                }
        }

        private void Capnhatthongtin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trangchinh1.cntt = null;
        }
    }
}
