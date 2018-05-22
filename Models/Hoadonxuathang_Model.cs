using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DATN.Models
{
    class Hoadonxuathang_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Hoadonxuathang");
            return dt;
        }
        public bool Them(String mahdx, String manv, String ngayxuat)
        {
            bool check = false;
            String sqlThem = "insert Hoadonxuathang values('" + mahdx + "','" + manv + "','" + ngayxuat + "')";
            if (xl.Thucthi(sqlThem) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Xoa(String mahdx)
        {
            bool check = false;
            String sqlXoa = "delete from Hoadonxuathang where Mahdx='" + mahdx + "'";
            if (xl.Thucthi(sqlXoa) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Sua(String mahdx, String manv, String ngayxuat)
        {
            bool check = false;
            String sqlSua = "update Hoadonxuathang set Manv='" + manv + "',Mahdx ='" + mahdx + "',Ngayxuat='" + ngayxuat + "' where Mahdx='" + mahdx + "'";
            if (xl.Thucthi(sqlSua) == true)
            {
                check = true;
            }
            return check;
        }
    }
}
