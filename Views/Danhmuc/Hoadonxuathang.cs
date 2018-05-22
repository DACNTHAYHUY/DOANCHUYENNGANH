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
    public partial class Hoadonxuathang : Form
    {
        public Hoadonxuathang()
        {
            InitializeComponent();
        }
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from v_Danhsachhoadonxuat");
            return dt;
        }
        private void Hoadonxuathang_Load(object sender, EventArgs e)
        {
            dgvHoadonxuat.DataSource = LoadDulieu();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbTimkiem.Text == "Mã hóa đơn")
            {
                DataTable dt;
                dt = LoadDulieu();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Mahdx LIKE '%{0}%'", txtTimkiem.Text);
                dgvHoadonxuat.DataSource = dv;
            }
            else
                if (cbTimkiem.Text == "Mã nhân viên")
                {
                    DataTable dt;
                    dt = LoadDulieu();
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Manv LIKE '%{0}%'", txtTimkiem.Text);
                    dgvHoadonxuat.DataSource = dv;
                }
                else
                    if (cbTimkiem.Text == "Tên nhân viên")
                    {
                        DataTable dt;
                        dt = LoadDulieu();
                        DataView dv = new DataView(dt);
                        dv.RowFilter = string.Format("Tennv LIKE '%{0}%'", txtTimkiem.Text);
                        dgvHoadonxuat.DataSource = dv;
                    }
                    else
                            if (cbTimkiem.Text == "Ngày xuất")
                            {
                                DataTable dt;
                                dt = LoadDulieu();
                                DataView dv = new DataView(dt);
                                dv.RowFilter = string.Format("Convert(Ngayxuat, System.String) LIKE '%{0}%'", txtTimkiem.Text);
                                dgvHoadonxuat.DataSource = dv;
                            }
        }
    }
}
