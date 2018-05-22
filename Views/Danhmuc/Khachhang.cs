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
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }
        Khachhang_Model khm = new Khachhang_Model();
        private void Khachhang_Load(object sender, EventArgs e)
        {
            dgvKhachhang.DataSource = khm.LoadDulieu();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbTimkiem.Text == "Mã khách hàng")
            {
                DataTable dt;
                dt = khm.LoadDulieu();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Makh LIKE '%{0}%'", txtTimkiem.Text);
                dgvKhachhang.DataSource = dv;
            }
            else
                if (cbTimkiem.Text == "Tên khách hàng")
                {
                    DataTable dt;
                    dt = khm.LoadDulieu();
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Tenkh LIKE '%{0}%'", txtTimkiem.Text);
                    dgvKhachhang.DataSource = dv;
                }
                else
                    if (cbTimkiem.Text == "Loại khách hàng")
                    {
                        DataTable dt;
                        dt = khm.LoadDulieu();
                        DataView dv = new DataView(dt);
                        dv.RowFilter = string.Format("Loai LIKE '%{0}%'", txtTimkiem.Text);
                        dgvKhachhang.DataSource = dv;
                    }
        }
    }
}
