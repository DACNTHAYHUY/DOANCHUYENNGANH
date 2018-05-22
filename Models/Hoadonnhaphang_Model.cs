using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DATN.Models
{
    class Hoadonnhaphang_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Hoadonnhaphang");
            return dt;
        }
        public bool Them(String mahdn, String manv, String ngaynhap, String tongtien,String mancc)
        {
            bool check = false;
            String sqlThem = "insert Hoadonnhaphang values('" + mahdn + "','" + manv + "','" + mancc + "','" + ngaynhap + "','" + tongtien + "')";
            if (xl.Thucthi(sqlThem) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Xoa(String mahdn)
        {
            bool check = false;
            String sqlXoa = "delete from Hoadonnhaphang where Mahdn='" + mahdn + "'";
            if (xl.Thucthi(sqlXoa) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Sua(String mahdn, String manv, String ngaynhap, String tongtien,String mancc)
        {
            bool check = false;
            String sqlSua = "update Hoadonnhaphang set Manv='" + manv + "',Mahdn ='" + mahdn + "',Ngaynhap='" + ngaynhap + "',Tongtien='" + tongtien + "',Mancc='" + mancc + "' where Mahdn='" + mahdn + "'";
            if (xl.Thucthi(sqlSua) == true)
            {
                check = true;
            }
            return check;
        }
    }
}
