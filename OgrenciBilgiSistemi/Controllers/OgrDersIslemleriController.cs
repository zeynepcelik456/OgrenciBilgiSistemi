﻿using Microsoft.AspNetCore.Http;
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
            OgrData.Models.TblLogin user = new OgrData.Models.TblLogin();
            OgrData.services.ServicesLogin srvs = new OgrData.services.ServicesLogin();
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            user = srvs.GetByData(id);
            return View(user);
        }
        public IActionResult GenelNot()
        {
            OgrData.Models.TblLogin user = new OgrData.Models.TblLogin();
            OgrData.services.ServicesLogin srvs = new OgrData.services.ServicesLogin();
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            user = srvs.GetByData(id);
            return View(user);
        }
        public IActionResult DersListesi()
        {
            OgrData.Models.TblLogin user = new OgrData.Models.TblLogin();
            OgrData.services.ServicesLogin srvs = new OgrData.services.ServicesLogin();
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            user = srvs.GetByData(id);
            return View(user);
        }
        public IActionResult DersProgramı()
        {
            OgrData.Models.TblLogin user = new OgrData.Models.TblLogin();
            OgrData.services.ServicesLogin srvs = new OgrData.services.ServicesLogin();
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            user = srvs.GetByData(id);
            return View(user);
        }
        public IActionResult SinavProgramı()
        {
            OgrData.Models.TblLogin user = new OgrData.Models.TblLogin();
            OgrData.services.ServicesLogin srvs = new OgrData.services.ServicesLogin();
            int id = (int)HttpContext.Session.GetInt32("LoginKontrol");
            user = srvs.GetByData(id);
            return View(user);
        }
    }
}
