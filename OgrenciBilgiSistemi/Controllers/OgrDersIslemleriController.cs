using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OgrenciBilgiSistemi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Controllers
{
    [IsLogin]
    public class OgrDersIslemleriController : Controller
    {  
        OgrData.Models.DbOgrSistemContext db = new OgrData.Models.DbOgrSistemContext();
        public IActionResult YariyilNot()
        {
           
          
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");

            List<OgrData.Models.TblOgrenciDer> dlist = db.TblOgrenciDers.Include(x => x.DersNavigation).Where(x => x.OgrenciNavigation.Id == id).ToList();

           //// foreach (var item in dlist)
           /// {
           //    var  ortalama=(item.Vize*40/100) + (item.Final*60/100);
           //    ViewBag.ort = ortalama;
           // }
             
          

            return View(dlist);

        }

        public IActionResult DersListesi()
        {

           
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            List<OgrData.Models.TblDer> dlist = db.TblDers.Where(x => x.BolumNavigation.Id == id ).Include(x => x.BolumNavigation).ToList();
            return View(dlist);
            //return View();
        }
        public IActionResult DersProgramı()
        {
            return View();
        }
        public IActionResult SinavProgramı()
        {
            return View();
        }
    }
}
