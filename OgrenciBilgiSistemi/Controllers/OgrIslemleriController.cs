using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OgrenciBilgiSistemi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Controllers
{
    [IsLogin]
    public class OgrIslemleriController : Controller
    {
        public IActionResult HarcBilgi()
        {
            OgrData.Models.TblLogin user = new OgrData.Models.TblLogin();
            OgrData.services.ServicesLogin srvs = new OgrData.services.ServicesLogin();
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            user = srvs.GetByData(id);
            return View(user);
        }
        public IActionResult HarcIade()
        {
            OgrData.Models.TblLogin user = new OgrData.Models.TblLogin();
            OgrData.services.ServicesLogin srvs = new OgrData.services.ServicesLogin();
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            user = srvs.GetByData(id);
            return View(user);
        }
        public IActionResult AcilanDersler()
        {
            OgrData.Models.TblLogin user = new OgrData.Models.TblLogin();
            OgrData.services.ServicesLogin srvs = new OgrData.services.ServicesLogin();
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            user = srvs.GetByData(id);
            return View(user);
        }
    }
}
