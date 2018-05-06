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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        Nhanvien_Controller nvc = new Nhanvien_Controller();
        Trangchinh1 tc = new Trangchinh1();
        public static String manv;
        private void Login()
        {
            if (txtMatkhau.Text == "123" && txtId.Text == "trung")
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Close();
            }
            if (txtId.Text != "" && txtMatkhau.Text != "")
            {
                manv = nvc.Dangnhap(txtId.Text, txtMatkhau.Text);
                if (manv != "")
                {
                    MessageBox.Show("Đăng nhập thành công" + "\nXin chào" + Nhanvien_Model.hoten);
                    this.Hide();
                    tc.ShowDialog();
                    this.Show();
                    txtMatkhau.Text = "";
                }
                else
                {
                    MessageBox.Show("Sai mã nhân viên hoặc mật khẩu");
                }

            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên hoặc mật khẩu");
            }           
        }
        private void btDangnhap_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        private void btQuaylai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trangchinh1.dn = null;
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Login();
            }
        }

      

    

       
    }
}
