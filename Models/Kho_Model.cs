using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DATN.Models
{
    class Kho_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Kho");
            return dt;
        }
        public bool Them(String masp, String tensp, String gia, String soluong,String loai)
        {
            bool check = false;
            String sqlThem = "insert Kho values('" + masp + "',N'" + tensp + "','" + gia + "','" + soluong + "','" + loai + "')";
            if (xl.Thucthi(sqlThem) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Xoa(String masp)
        {
            bool check = false;
            String sqlXoa = "delete from Kho where Masp='" + masp + "'";
            if (xl.Thucthi(sqlXoa) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Sua(String masp, String tensp, String gia, String soluong,String loai)
        {
            bool check = false;
            String sqlSua = "update Kho set Masp='" + masp + "',Tensp=N'" + tensp + "',Dongia ='" + gia + "',Soluong='" + soluong + "',Loai='" + loai + "' where Masp='" + masp + "'";
            if (xl.Thucthi(sqlSua) == true)
            {
                check = true;
            }
            return check;
        }
    }
}
