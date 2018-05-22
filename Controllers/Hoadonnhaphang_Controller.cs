  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Hoadonnhaphang_Controller
    {
        Hoadonnhaphang_Model hdnm = new Hoadonnhaphang_Model();
        public bool Them(String mahdn, String manv, String ngaynhap, String tongtien,String mancc)
        {
            return hdnm.Them(mahdn, manv,ngaynhap, tongtien,mancc);
        }
        public bool Sua(String mahdn, String manv, String ngaynhap, String tongtien,String mancc)
        {
            return hdnm.Sua(mahdn, manv, ngaynhap, tongtien,mancc);
        }
        public bool Xoa(String mahdn)
        {
            return hdnm.Xoa(mahdn);
        }
    }
}
