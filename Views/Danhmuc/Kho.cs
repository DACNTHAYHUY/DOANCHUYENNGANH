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
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
        }
        Kho_Model km = new Kho_Model();
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbTimkiem.Text == "Mã sản phẩm")
            {
                DataTable dt;
                dt = km.LoadDulieu();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Masp LIKE '%{0}%'", txtTimkiem.Text);
                dgvKho.DataSource = dv;
            }
            else
                if (cbTimkiem.Text == "Tên sản phẩm")
                {
                    DataTable dt;
                    dt = km.LoadDulieu();
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Tensp LIKE '%{0}%'", txtTimkiem.Text);
                    dgvKho.DataSource = dv;
                }
                else
                    if (cbTimkiem.Text == "Số lượng")
                    {
                        DataTable dt;
                        dt = km.LoadDulieu();
                        DataView dv = new DataView(dt);
                        dv.RowFilter = string.Format("Convert(Soluong, System.String) LIKE '%{0}%'", txtTimkiem.Text);
                        dgvKho.DataSource = dv;
                    }
        }

        private void Kho_Load(object sender, EventArgs e)
        {
            dgvKho.DataSource = km.LoadDulieu();
        }
    }
}
