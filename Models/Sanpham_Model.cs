using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DATN.Models
{
    class Sanpham_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Thongtinsanpham");
            return dt;
        }
        public bool Them(String masp, String tensp, String gia, String soluong)
        {
            bool check = false;
            String sqlThem = "insert Thongtinsanpham values('" + masp + "',N'" + tensp + "','" + soluong + "','" + gia + "')";
            if (xl.Thucthi(sqlThem) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Sua(String masp, String tensp, String gia, String soluong)
        {
            bool check = false;
            String sqlSua = "update Thongtinsanpham set Masp='" + masp + "',Tensp=N'" + tensp + "',Giaban ='" + gia + "',Soluong='" + soluong + "' where Masp='" + masp + "'";
            if (xl.Thucthi(sqlSua) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Xoa(String masp)
        {
            bool check = false;
            String sqlXoa = "delete from Thongtinsanpham where Masp='" + masp + "'";
            if (xl.Thucthi(sqlXoa) == true)
            {
                check = true;
            }
            return check;
        }
        
    }
}
