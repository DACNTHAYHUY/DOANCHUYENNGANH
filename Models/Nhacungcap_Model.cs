using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DATN.Models
{
    class Nhacungcap_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Nhacungcap");
            return dt;
        }
        public bool Them(String mancc,String tenncc,String diachi,String sdt)
        {
            bool check = false;
            String sqlThem = "insert Nhacungcap values('" + mancc + "',N'" + tenncc + "',N'" + diachi + "','" + sdt + "')";
            if (xl.Thucthi(sqlThem) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Xoa(String mancc)
        {
            bool check = false;
            String sqlXoa = "delete from Nhacungcap where Mancc='" + mancc + "'";
            if (xl.Thucthi(sqlXoa) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Sua(String mancc, String tenncc, String diachi, String sdt)
        {
            bool check = false;
            String sqlSua = "update Nhacungcap set Mancc='" + mancc + "',Tenncc=N'" + tenncc + "',Sodienthoai ='" + sdt + "',Diachi=N'" + diachi + "' where Mancc='" + mancc + "'";
            if (xl.Thucthi(sqlSua) == true)
            {
                check = true;
            }
            return check;
        }
    }
}
