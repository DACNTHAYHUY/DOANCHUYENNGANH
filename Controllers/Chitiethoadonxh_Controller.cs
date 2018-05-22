using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Chitiethoadonxh_Controller
    {
        Chitiethoadonxh_Model cthdxm = new Chitiethoadonxh_Model();
        public bool Them(String macthdx,String masp, String mahdx,String soluong)
        {
            return cthdxm.Them(macthdx, masp, mahdx, soluong);
        }
        public bool Sua(String macthdx, String masp, String mahdx, String soluong)
        {
            return cthdxm.Sua(macthdx, masp, mahdx, soluong);
        }
        public bool Xoa(String macthdx)
        {
            return cthdxm.Xoa(macthdx);
        }
    }
}
