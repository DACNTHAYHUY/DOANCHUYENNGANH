using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DATN.Models
{
    class Chitiethoadonxh_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Chitiethoadonxuathang");
            return dt;
        }
        public DataTable LoadDulieu1(String dieukien)
        {
            DataTable dt;
            dt = xl.GetData("select * from Chitiethoadonxuathang where Mahdx='" + dieukien + "'");
            return dt;
        }
        public bool Them(String macthdx,String masp, String mahdx,String soluong)
        {
            bool check = false;
            String sqlThem = "insert Chitiethoadonxuathang values('" + macthdx + "','" + mahdx + "','" + masp + "','" + soluong + "')";
            if (xl.Thucthi(sqlThem) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Xoa(String macthdx)
        {
            bool check = false;
            String sqlXoa = "delete from Chitiethoadonxuathang where Macthdx='" + macthdx + "'";
            if (xl.Thucthi(sqlXoa) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Sua(String macthdx, String masp, String mahdx, String soluong)
        {
            bool check = false;
            String sqlSua = "update Chitiethoadonxuathang set Masp='" + masp + "',Macthdx='" + macthdx + "',Mahdx ='" + mahdx + "',Soluong='" + soluong + "' where Macthdx='" + macthdx + "'";
            if (xl.Thucthi(sqlSua) == true)
            {
                check = true;
            }
            return check;
        }
    }
}
