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
namespace DATN.Views.Danhmuc
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }
        Nhanvien_Model nvm = new Nhanvien_Model();
        private void Nhanvien_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = nvm.LoadDulieu();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbTimkiem.Text == "Mã nhân viên")
            {
                DataTable dt;
                dt = nvm.LoadDulieu();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Manv LIKE '%{0}%'", txtTimkiem.Text);
                dgvNhanvien.DataSource = dv;
            }
            else
                if (cbTimkiem.Text == "Tên nhân viên")
                {
                    DataTable dt;
                    dt = nvm.LoadDulieu();
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Tennv LIKE '%{0}%'", txtTimkiem.Text);
                    dgvNhanvien.DataSource = dv;
                }
                else
                    if (cbTimkiem.Text == "Chức vụ")
                    {
                        DataTable dt;
                        dt = nvm.LoadDulieu();
                        DataView dv = new DataView(dt);
                        dv.RowFilter = string.Format("Chucvu LIKE '%{0}%'", txtTimkiem.Text);
                        dgvNhanvien.DataSource = dv;
                    }
        }
    }
}
