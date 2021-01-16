using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Controllers.Admin
{
    public class BolumController : Controller
    {
        public List<OgrData.Models.TblBolum> Listeleme()
        {
            var servis = new OgrData.services.AdminServices.BolumServices();
            List<OgrData.Models.TblBolum> bolum = servis.GetAll();
            return bolum;
        }
        public IActionResult Index()
        {
            var deger = Listeleme();
            return View(deger);
        }
        public IActionResult BolumEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BolumEkle(OgrData.Models.TblBolum eklenecekDeger)
        {
            var servis = new OgrData.services.AdminServices.BolumServices();
            var x = servis.AddBolum(eklenecekDeger);
            return RedirectToAction("Index", "Bolum");
        }

        public IActionResult BolumSil(int bolumId)
        {
            if (bolumId > 0)
            {
                var servis = new OgrData.services.AdminServices.BolumServices();
               servis.DeleteBolum(bolumId);

            }

            return RedirectToAction("Index");

        }
    }
}
