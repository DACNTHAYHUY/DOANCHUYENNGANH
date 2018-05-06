using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DATN.Models
{
    class Hoadonbanhang_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Hoadonbanhang");
            return dt;
        }
        public bool Them(String mahdb,String manv,String makh,String ngayban,String tongtien)
        {
            bool check = false;
            String sqlThem = "insert Hoadonbanhang values('" + mahdb + "','" + manv + "','" + makh + "','" + ngayban + "','" + tongtien + "')";
            if (xl.Thucthi(sqlThem) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Xoa(String mahdb)
        {
            bool check = false;
            String sqlXoa = "delete from Hoadonbanhang where Mahdb='" + mahdb + "'";
            if (xl.Thucthi(sqlXoa) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Sua(String mahdb, String manv, String makh, String ngayban, String tongtien)
        {
            bool check = false;
            String sqlSua = "update Hoadonbanhang set Makh='" + makh + "',Manv='" + manv + "',Mahdb =N'" + mahdb + "',Ngayban='" + ngayban + "',Tongtien='" + tongtien + "'where Mahdb='" + mahdb + "'";
            if (xl.Thucthi(sqlSua) == true)
            {
                check = true;
            }
            return check;
        }
    }
}
