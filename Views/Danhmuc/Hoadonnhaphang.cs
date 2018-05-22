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
    public partial class Hoadonnhaphang : Form
    {
        public Hoadonnhaphang()
        {
            InitializeComponent();
        }
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from v_Danhsachhoadonnhap");
            return dt;
        }
        private void Hoadonnhaphang_Load(object sender, EventArgs e)
        {
            dgvHoadonnhap.DataSource = LoadDulieu();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbTimkiem.Text == "Mã hóa đơn")
            {
                DataTable dt;
                dt = LoadDulieu();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Mahdn LIKE '%{0}%'", txtTimkiem.Text);
                dgvHoadonnhap.DataSource = dv;
            }
            else
                if (cbTimkiem.Text == "Mã nhân viên")
                {
                    DataTable dt;
                    dt = LoadDulieu();
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Manv LIKE '%{0}%'", txtTimkiem.Text);
                    dgvHoadonnhap.DataSource = dv;
                }
                else
                    if (cbTimkiem.Text == "Tên nhân viên")
                    {
                        DataTable dt;
                        dt = LoadDulieu();
                        DataView dv = new DataView(dt);
                        dv.RowFilter = string.Format("Tennv LIKE '%{0}%'", txtTimkiem.Text);
                        dgvHoadonnhap.DataSource = dv;
                    }
                    else
                        if (cbTimkiem.Text == "Mã nhà cung cấp")
                        {
                            DataTable dt;
                            dt = LoadDulieu();
                            DataView dv = new DataView(dt);
                            dv.RowFilter = string.Format("Mancc LIKE '%{0}%'", txtTimkiem.Text);
                            dgvHoadonnhap.DataSource = dv;
                        }
                        else
                            if (cbTimkiem.Text == "Tên nhà cung cấp")
                            {
                                DataTable dt;
                                dt = LoadDulieu();
                                DataView dv = new DataView(dt);
                                dv.RowFilter = string.Format("Tenncc LIKE '%{0}%'", txtTimkiem.Text);
                                dgvHoadonnhap.DataSource = dv;
                            }
                            else
                                if (cbTimkiem.Text == "Ngày nhập")
                                {
                                    DataTable dt;
                                    dt = LoadDulieu();
                                    DataView dv = new DataView(dt);
                                    dv.RowFilter = string.Format("Convert(Ngaynhap, System.String) LIKE '%{0}%'", txtTimkiem.Text);
                                    dgvHoadonnhap.DataSource = dv;
                                }
        }
    }
}
