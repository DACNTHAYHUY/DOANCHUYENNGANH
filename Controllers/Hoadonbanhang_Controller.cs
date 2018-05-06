using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Hoadonbanhang_Controller
    {
        Hoadonbanhang_Model hdb = new Hoadonbanhang_Model();
        public bool Them(String mahdb, String manv,String makh, String ngayban, String tongtien)
        {
            return hdb.Them(mahdb,manv,makh,ngayban,tongtien);
        }
        public bool Sua(String mahdb, String manv, String makh, String ngayban, String tongtien)
        {
            return hdb.Sua(mahdb, manv, makh, ngayban, tongtien);
        }
        public bool Xoa(String mahdb)
        {
            return hdb.Xoa(mahdb);
        }
    }
}
