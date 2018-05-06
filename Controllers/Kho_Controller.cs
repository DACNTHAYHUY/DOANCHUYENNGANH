using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Kho_Controller
    {
        Kho_Model km = new Kho_Model();
        public bool Them(String masp, String tensp, String gia, String soluong,String loai)
        {
            return km.Them(masp, tensp, gia, soluong,loai);
        }
        public bool Sua(String masp, String tensp, String gia, String soluong,String loai)
        {
            return km.Sua(masp, tensp, gia, soluong,loai);
        }
        public bool Xoa(String masp)
        {
            return km.Xoa(masp);
        }
    }
}
