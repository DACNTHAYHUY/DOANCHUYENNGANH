using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DATN.Models
{
    class Nhomsanpham_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Nhomsanpham");
            return dt;
        }
        public bool Them(String mansp, String tennsp)
        {
            bool check = false;
            String sqlThem = "insert Nhomsanpham values('" + mansp + "','" + tennsp + "')";
            if (xl.Thucthi(sqlThem) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Xoa(String mansp)
        {
            bool check = false;
            String sqlXoa = "delete from Nhomsanpham where Mansp='" + mansp + "'";
            if (xl.Thucthi(sqlXoa) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Sua(String mansp, String tennsp)
        {
            bool check = false;
            String sqlSua = "update Nhomsanpham set Mansp ='" + mansp + "',Tennsp='" + tennsp + "' where Mansp='" + mansp + "'";
            if (xl.Thucthi(sqlSua) == true)
            {
                check = true;
            }
            return check;
        }
    }
}
