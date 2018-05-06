using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DATN.Models
{
    class Nhanvien_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Nhanvien");
            return dt;
        }
        public bool Them(String manv, String matkhau, String tennv, String gioitinh, String diachi, String sdt, String chucvu)
        {
                bool check = false;
                String sqlThem = "insert Nhanvien values('" + manv + "','" + matkhau + "',N'" + tennv + "',N'" + gioitinh + "',N'" + diachi + "','" + sdt + "',N'" + chucvu + "')";
                if(xl.Thucthi(sqlThem)==true)
                {
                    check = true;
                }
                return check;
        }
        public bool Xoa(String manv)
        {
                bool check = false;
                String sqlXoa = "delete from Nhanvien where Manv='" + manv + "'";
                if(xl.Thucthi(sqlXoa)==true)
                {
                    check = true;
                }
                return check;
        }
        public bool Sua(String manv, String matkhau, String tennv, String gioitinh, String diachi, String sdt, String chucvu)
        {
                bool check = false;
                String sqlSua = "update Nhanvien set Manv='" + manv + "',Tennv=N'" + tennv + "',Gioitinh =N'" + gioitinh + "',Diachi=N'" + diachi + "',Sodienthoai='" + sdt + "',Chucvu='" + chucvu + "',Matkhau='" + matkhau + "'where Manv='" + manv + "'";
                if(xl.Thucthi(sqlSua)==true)
                {
                    check = true;
                }
                return check;
        }
        public bool Doimatkhau(String manv,String matkhaucu,String matkhaumoi)
        {
            bool check = false;
            String sqlDmk="update Nhanvien set Manv='" + manv + "',Matkhau='" + matkhaumoi + "' where Manv='" + manv + "' and Matkhau='" + matkhaucu + "'";
            if(xl.Thucthi(sqlDmk)==true)
            {
                check = true;
            }
            return check;
        }
        public static String chucvu;
        public static String hoten;
        public static String gioitinh;
        public static String diachi;
        public static String sodienthoai;
        public static String mk;
        public String Dangnhap(String manv, String matkhau)
        {
            String mnv="";
            try
            {
                String dl = "select * from Nhanvien where Manv='" + manv + "' and Matkhau='" + matkhau + "'";
                DataTable dt = new DataTable();
                dt=xl.GetData(dl);
                if(dt!=null)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        chucvu = dr["Chucvu"].ToString();
                        gioitinh = dr["Gioitinh"].ToString();
                        diachi = dr["Diachi"].ToString();
                        sodienthoai = dr["Sodienthoai"].ToString();
                        hoten = dr["Tennv"].ToString();
                        mk = dr["Matkhau"].ToString();
                        mnv = dr["Manv"].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return mnv;
        }
    }
}
