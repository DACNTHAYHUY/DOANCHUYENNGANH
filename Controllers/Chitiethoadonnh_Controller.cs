using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Chitiethoadonnh_Controller
    {
        Chitiethoadonnh_Model cthdnm = new Chitiethoadonnh_Model();
        public bool Them(String macthdn,String masp, String mahdn, String dongia, String thanhtien, String soluong)
        {
            return cthdnm.Them(macthdn,masp, mahdn, dongia, thanhtien, soluong);
        }
        public bool Sua(String macthdn,String masp, String mahdn, String dongia, String thanhtien, String soluong)
        {
            return cthdnm.Sua(macthdn,masp, mahdn, dongia, thanhtien, soluong);
        }
        public bool Xoa(String macthdn)
        {
            return cthdnm.Xoa(macthdn);
        }
    }
}
