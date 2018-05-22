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
    public partial class Nhacungcap : Form
    {
        public Nhacungcap()
        {
            InitializeComponent();
        }
        Nhacungcap_Model nccm = new Nhacungcap_Model();
        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            dgvNhacungcap.DataSource = nccm.LoadDulieu();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbTimkiem.Text == "Mã nhà cung cấp")
            {
                DataTable dt;
                dt = nccm.LoadDulieu();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Mancc LIKE '%{0}%'", txtTimkiem.Text);
                dgvNhacungcap.DataSource = dv;
            }
            else
                if (cbTimkiem.Text == "Tên nhà cung cấp")
                {
                    DataTable dt;
                    dt = nccm.LoadDulieu();
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Tenncc LIKE '%{0}%'", txtTimkiem.Text);
                    dgvNhacungcap.DataSource = dv;
                }
        }
    }
}
