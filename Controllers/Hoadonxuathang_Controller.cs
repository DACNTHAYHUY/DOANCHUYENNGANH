using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Hoadonxuathang_Controller
    {
        Hoadonxuathang_Model hdxm = new Hoadonxuathang_Model();
        public bool Them(String mahdx, String manv, String ngayxuat)
        {
            return hdxm.Them(mahdx, manv, ngayxuat);
        }
        public bool Sua(String mahdx, String manv, String ngayxuat)
        {
            return hdxm.Sua(mahdx, manv, ngayxuat);
        }
        public bool Xoa(String mahdx)
        {
            return hdxm.Xoa(mahdx);
        }
    }
}
