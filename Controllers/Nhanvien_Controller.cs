using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Nhanvien_Controller
    {
        Nhanvien_Model nv = new Nhanvien_Model();
        public bool Them(String manv, String matkhau, String tennv, String gioitinh, String diachi, String sdt, String chucvu)
        {
            return nv.Them(manv, matkhau, tennv, gioitinh, diachi, sdt, chucvu);
        }
        public bool Sua(String manv, String matkhau, String tennv, String gioitinh, String diachi, String sdt, String chucvu)
        {
            return nv.Sua(manv, matkhau, tennv, gioitinh, diachi, sdt, chucvu);
        }
        public bool Xoa(String manv)
        {
            return nv.Xoa(manv);
        }
        public String Dangnhap(String manv, String matkhau)
        {
            return nv.Dangnhap(manv, matkhau);
        }
        public bool Doimatkhau(String manv,String matkhaucu,String matkhaumoi)
        {
            return nv.Doimatkhau(manv, matkhaucu, matkhaumoi);
        }
    }
}
