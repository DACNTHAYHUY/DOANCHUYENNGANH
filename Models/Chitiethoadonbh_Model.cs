using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DATN.Views;
namespace DATN.Models
{
    class Chitiethoadonbh_Model
    {
        Xuly xl = new Xuly();
        public DataTable LoadDulieu()
        {
            DataTable dt;
            dt = xl.GetData("select * from Chitiethoadonbanhang");
            return dt;
        }
        public DataTable LoadDulieu1()
        {
            DataTable dt;
            dt = xl.GetData("select * from Chitiethoadonbanhang where Mahdb='" + HoadonKCTT.Mahd + "'");
            return dt;
        }
        public DataTable LoadDulieu2()
        {
            DataTable dt;
            dt = xl.GetData("select * from Chitiethoadonbanhang where Mahdb='" + HoadonKCCTT.Mahd + "'");
            return dt;
        }
        public DataTable LoadDulieu3()
        {
            DataTable dt;
            dt = xl.GetData("select * from Chitiethoadonbanhang where Mahdb='" + ChinhsuaHoadon.Mahd + "'");
            return dt;
        }
        public bool Them(String macthdb, String masp, String mahdb, String dongia, String thanhtien, String soluong)
        {
            bool check = false;
            String sqlThem = "insert Chitiethoadonbanhang values('" + macthdb + "','" + mahdb + "','" + masp + "','" + soluong + "','" + dongia + "','" + thanhtien + "')";
            if (xl.Thucthi(sqlThem) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Xoa(String macthdb)
        {
            bool check = false;
            String sqlXoa = "delete from Chitiethoadonbanhang where Macthdb='" + macthdb + "'";
            if (xl.Thucthi(sqlXoa) == true)
            {
                check = true;
            }
            return check;
        }
        public bool Sua(String macthdb, String masp, String mahdb, String dongia, String thanhtien,String soluong)
        {
            bool check = false;
            String sqlSua = "update Chitiethoadonbanhang set Masp='" + masp + "',Macthdb='" + macthdb + "',Mahdb =N'" + mahdb + "',Dongia='" + dongia + "',Thanhtien='" + thanhtien + "',Soluong='" + soluong + "'where Macthdb='" + macthdb + "'";
            if (xl.Thucthi(sqlSua) == true)
            {
                check = true;
            }
            return check;
        }
    }
}
