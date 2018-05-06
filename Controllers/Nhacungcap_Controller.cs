using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Nhacungcap_Controller
    {
        Nhacungcap_Model nccm = new Nhacungcap_Model();
        public bool Them(String mancc, String tenncc, String diachi, String sdt)
        {
            return nccm.Them(mancc, tenncc, diachi, sdt);
        }
        public bool Sua(String mancc, String tenncc, String diachi, String sdt)
        {
            return nccm.Sua(mancc, tenncc,diachi, sdt);
        }
        public bool Xoa(String mancc)
        {
            return nccm.Xoa(mancc);
        }
    }
}
