using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DATN.Models
{
    class Khachhang_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Khachhang");
            return dt;
        }
        public bool Them(String makh,String tenkh, String gioitinh, String diachi, String sdt)
        {
            bool check = false;
                String sqlThem = "insert Khachhang values('" + makh + "',N'" + tenkh + "',N'" + gioitinh + "',N'" + diachi + "','" + sdt + "')";
                if(xl.Thucthi(sqlThem)==true)
                {
                    check = true;
                }
                return check;
        }
        public bool Xoa(String makh)
        {
                bool check = false;
                String sqlXoa = "delete from Khachhang where Makh='" + makh + "'";
                if(xl.Thucthi(sqlXoa)==true)
                {
                    check = true;
                }
                return check;
        }
        public bool Sua(String makh, String tenkh, String gioitinh, String diachi, String sdt)
        {
                bool check = false;
                String sqlSua = "update Khachhang set Makh='" + makh + "',Tenkh=N'" + tenkh + "',Gioitinh =N'" + gioitinh + "',Diachi=N'" + diachi + "',Sodienthoai='" + sdt + "'where Makh='" + makh + "'";
                if(xl.Thucthi(sqlSua)==true)
                {
                    check = true;
                }
                return check;
        }
    }
}
