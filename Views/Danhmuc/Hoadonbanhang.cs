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
    public partial class Hoadonbanhang : Form
    {
        public Hoadonbanhang()
        {
            InitializeComponent();
        }
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from v_Danhsachhoadonban");
            return dt;
        }
        private void Hoadonbanhang_Load(object sender, EventArgs e)
        {
            dgvHoadonban.DataSource = LoadDulieu();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if(cbTimkiem.Text=="Mã hóa đơn")
            {
                DataTable dt;
                dt = LoadDulieu();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Mahdb LIKE '%{0}%'", txtTimkiem.Text);
                dgvHoadonban.DataSource = dv;
            }
            else
                if(cbTimkiem.Text=="Mã khách hàng")
                {
                    DataTable dt;
                    dt = LoadDulieu();
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Makh LIKE '%{0}%'", txtTimkiem.Text);
                    dgvHoadonban.DataSource = dv;
                }
                else
                    if(cbTimkiem.Text=="Mã nhân viên")
                    {
                        DataTable dt;
                        dt = LoadDulieu();
                        DataView dv = new DataView(dt);
                        dv.RowFilter = string.Format("Manv LIKE '%{0}%'", txtTimkiem.Text);
                        dgvHoadonban.DataSource = dv;
                    }
                    else
                        if(cbTimkiem.Text=="Tên khách hàng")
                        {
                            DataTable dt;
                            dt = LoadDulieu();
                            DataView dv = new DataView(dt);
                            dv.RowFilter = string.Format("Tenkh LIKE '%{0}%'", txtTimkiem.Text);
                            dgvHoadonban.DataSource = dv;
                        }
                        else
                            if(cbTimkiem.Text=="Ngày bán")
                            {
                                DataTable dt;
                                dt = LoadDulieu();
                                DataView dv = new DataView(dt);
                                dv.RowFilter = string.Format("Convert(Ngayban,System.String) LIKE '%{0}%'", txtTimkiem.Text);
                                dgvHoadonban.DataSource = dv;
                            }
                            else
                                if (cbTimkiem.Text == "Tên nhân viên")
                                {
                                    DataTable dt;
                                    dt = LoadDulieu();
                                    DataView dv = new DataView(dt);
                                    dv.RowFilter = string.Format("Tennv LIKE '%{0}%'", txtTimkiem.Text);
                                    dgvHoadonban.DataSource = dv;
                                }
        }
    }
}
