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
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {


            OgrData.services.ServicesDuyuru srvs = new OgrData.services.ServicesDuyuru();
            List<OgrData.Models.TblDuyuru> duyurulist = srvs.GetByDuyuru();
            return View(duyurulist);

         

        }


    }
}
