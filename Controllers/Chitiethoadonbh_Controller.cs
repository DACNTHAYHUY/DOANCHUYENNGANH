using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Chitiethoadonbh_Controller
    {
        Chitiethoadonbh_Model cthdbm = new Chitiethoadonbh_Model();
        public bool Them(String macthdb, String masp, String mahdb, String dongia, String thanhtien, String soluong)
        {
            return cthdbm.Them(macthdb, masp, mahdb, dongia, thanhtien, soluong);
        }
        public bool Sua(String macthdb, String masp, String mahdb, String dongia, String thanhtien, String soluong)
        {
            return cthdbm.Sua(macthdb, masp, mahdb, dongia, thanhtien, soluong);
        }
        public bool Xoa(String macthdb)
        {
            return cthdbm.Xoa(macthdb);
        }
    }
}
