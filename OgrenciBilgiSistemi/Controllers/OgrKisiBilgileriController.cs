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
    public class OgrKisiBilgileriController : Controller
    {
        public IActionResult BilgiGoruntule()
        {
            OgrData.Models.TblLogin user = new OgrData.Models.TblLogin();
            OgrData.services.ServicesGetOgr srvs = new OgrData.services.ServicesGetOgr();
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            user = srvs.GetByData(id);
            return View(user);
        }
        [HttpGet]
        public IActionResult SifreIslemleri()
        {
            OgrData.Models.TblLogin user = new OgrData.Models.TblLogin();
            OgrData.services.ServicesGetOgr srvs = new OgrData.services.ServicesGetOgr();
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            user = srvs.GetByData(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult SifreIslemleri(OgrData.Models.TblLogin s)
        {

            //OgrData.services.ServicesSifreGuncelleme srvs = new OgrData.services.ServicesSifreGuncelleme();
            //srvs.sıfreGuncelle(s);
            

            OgrData.Models.DbOgrSistemContext db = new OgrData.Models.DbOgrSistemContext();
            var ogr = db.TblLogins.Find(s.Id);
            ogr.Sıfre = s.Sıfre;
            db.SaveChanges();
            return RedirectToAction("SifreIslemleri", "OgrKisiBilgileri");
        }
    }
}
