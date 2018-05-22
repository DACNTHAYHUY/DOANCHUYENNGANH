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
    public partial class Nhomsanpham : Form
    {
        public Nhomsanpham()
        {
            InitializeComponent();
        }
        Nhomsanpham_Model nspm = new Nhomsanpham_Model();
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbTimkiem.Text == "Mã nhóm sản phẩm")
            {
                DataTable dt;
                dt = nspm.LoadDulieu();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Mansp LIKE '%{0}%'", txtTimkiem.Text);
                dgvNhomsanpham.DataSource = dv;
            }
            else
                if (cbTimkiem.Text == "Tên nhóm sản phẩm")
                {
                    DataTable dt;
                    dt = nspm.LoadDulieu();
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Tennsp LIKE '%{0}%'", txtTimkiem.Text);
                    dgvNhomsanpham.DataSource = dv;
                }
        }

        private void Nhomsanpham_Load(object sender, EventArgs e)
        {
            dgvNhomsanpham.DataSource = nspm.LoadDulieu();
        }
    }
}
