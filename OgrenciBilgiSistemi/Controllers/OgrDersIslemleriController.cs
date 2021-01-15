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
    public class OgrDersIslemleriController : Controller
    {
        public IActionResult YariyilNot()
        {
            return View();
        }
        public IActionResult GenelNot()
        {
            return View();
        }
        public IActionResult DersListesi()
        {
            return View();
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
