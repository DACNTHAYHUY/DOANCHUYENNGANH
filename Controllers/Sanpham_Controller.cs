using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Sanpham_Controller
    {
        Sanpham_Model spm = new Sanpham_Model();
        public bool Them(String masp, String tensp, String gia, String soluong)
        {
            return spm.Them(masp,tensp,gia,soluong);
        }
        public bool Sua(String masp, String tensp, String gia, String soluong)
        {
            return spm.Sua(masp, tensp, gia, soluong);
        }
        public bool Xoa(String masp)
        {
            return spm.Xoa(masp);
        }
    }
}
