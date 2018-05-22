using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DATN.Models
{
    class Chitiethoadonnh_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Chitiethoadonnhaphang");
            return dt;
        }
        public DataTable LoadDulieu1(String dieukien)
        {
            DataTable dt;
            dt = xl.GetData("select * from Chitiethoadonnhaphang where Mahdn='" + dieukien + "'");
            return dt;
        }
        public bool Them(String macthdn,String masp, String mahdn, String dongia, String thanhtien, String soluong)
        {
            bool check = false;
            String sqlThem = "insert Chitiethoadonnhaphang values('" + macthdn + "','" + mahdn + "','" + masp + "','" + soluong + "','" + dongia + "','" + thanhtien + "')";
            if (xl.Thucthi(sqlThem) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Xoa(String macthdn)
        {
            bool check = false;
            String sqlXoa = "delete from Chitiethoadonnhaphang where Macthdn='" + macthdn + "'";
            if (xl.Thucthi(sqlXoa) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Sua(String macthdn,String masp, String mahdn, String dongia, String thanhtien, String soluong)
        {
            bool check = false;
            String sqlSua = "update Chitiethoadonnhaphang set Masp='" + masp + "',Macthdn='" + macthdn + "',Mahdn ='" + mahdn + "',Dongia='" + dongia + "',Thanhtien='" + thanhtien + "',Soluong='" + soluong + "' where Macthdn='" + macthdn + "'";
            if (xl.Thucthi(sqlSua) == true)
            {
                check = true;
            }
            return check;
        }
    }
}
