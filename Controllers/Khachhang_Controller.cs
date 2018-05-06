using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Khachhang_Controller
    {
        Khachhang_Model kh = new Khachhang_Model();
        public bool Them(String makh, String tenkh, String gioitinh, String diachi, String sdt)
        {
            return kh.Them(makh, tenkh, gioitinh, diachi, sdt);
        }
        public bool Sua(String makh, String tenkh, String gioitinh, String diachi, String sdt)
        {
            return kh.Sua(makh, tenkh, gioitinh, diachi, sdt);
        }
        public bool Xoa(String makh)
        {
            return kh.Xoa(makh);
        }
    }
}
