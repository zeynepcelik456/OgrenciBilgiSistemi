using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OgrenciBilgiSistemi.Helper;
using OgrenciBilgiSistemi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [IsLogin]
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Models.UsersClass users)
        {
            OgrData.services.ServicesLogin usersLoginServices = new OgrData.services.ServicesLogin();
           
            var userID = usersLoginServices.Login(users.userName, users.userPassword);
           
            if (userID != 0 && userID > 0)
            {
                //login yaptığımızda session kontrol edilip ıd kaydediliyor
                HttpContext.Session.SetInt32("LoginKontrol", userID);
                return RedirectToAction("Index", "Ogrenci");
            }
            return View();
        }
    }
}
