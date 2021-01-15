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
            OgrData.Models.TblHarc ogrHarc = new OgrData.Models.TblHarc();
            OgrData.services.ServicesHarc bg = new OgrData.services.ServicesHarc();
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            ogrHarc = bg.GetByHarc(id);
            return View(ogrHarc);
           
        }
     
        public IActionResult AcilanDersler()
        {
            return View();
        }
    }
}
