using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN.Models;
namespace DATN.Controllers
{
    class Nhomsanpham_Controller
    {
        Nhomsanpham_Model nspm = new Nhomsanpham_Model();
        public bool Them(String mansp,String tennsp)
        {
            return nspm.Them(mansp,tennsp);
        }
        public bool Sua(String mansp, String tennsp)
        {
            return nspm.Sua(mansp, tennsp);
        }
        public bool Xoa(String mansp)
        {
            return nspm.Xoa(mansp);
        }
    }
}
