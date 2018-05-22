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
using DATN.Reportss;
using DevExpress.XtraReports.UI;
namespace DATN.Views.Danhmuc
{
    public partial class Sanpham : Form
    {
        public Sanpham()
        {
            InitializeComponent();
        }
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from v_Danhsachsanpham");
            return dt;
        }

        private void Sanpham_Load(object sender, EventArgs e)
        {
            dgvSanpham.DataSource = LoadDulieu();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbTimkiem.Text == "Nhóm sản phẩm")
            {
                DataTable dt;
                dt = LoadDulieu();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Tennsp LIKE '%{0}%'", txtTimkiem.Text);
                dgvSanpham.DataSource = dv;
            }
            else
                if (cbTimkiem.Text == "Mã sản phẩm")
                {
                    DataTable dt;
                    dt = LoadDulieu();
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Masp LIKE '%{0}%'", txtTimkiem.Text);
                    dgvSanpham.DataSource = dv;
                }
                else
                    if (cbTimkiem.Text == "Tên sản phẩm")
                    {
                        DataTable dt;
                        dt = LoadDulieu();
                        DataView dv = new DataView(dt);
                        dv.RowFilter = string.Format("Tensp LIKE '%{0}%'", txtTimkiem.Text);
                        dgvSanpham.DataSource = dv;
                    }
                    else
                        if (cbTimkiem.Text == "Loại")
                        {
                            DataTable dt;
                            dt = LoadDulieu();
                            DataView dv = new DataView(dt);
                            dv.RowFilter = string.Format("Convert(Loai, System.String) LIKE '%{0}%'", txtTimkiem.Text);
                            dgvSanpham.DataSource = dv;
                        }
                        else
                            if(cbTimkiem.Text == "Số lượng")
                            {
                                DataTable dt;
                                dt = LoadDulieu();
                                DataView dv = new DataView(dt);
                                dv.RowFilter = string.Format("Convert(Soluong, System.String) LIKE '%{0}%'", txtTimkiem.Text);
                                dgvSanpham.DataSource = dv;
                            }
        }

        private void btBaocao_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = LoadDulieu();
            RpDanhsachsp report = new RpDanhsachsp();
            report.DataSource = dt;
            report.ShowPreviewDialog();
        }
    }
}
