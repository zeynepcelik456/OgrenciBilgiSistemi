using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OgrenciBilgiSistemi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(OgrData.Models.TblAdmin admin)
        {
            OgrData.services.ServicesAdminLogin usersAdminLoginServices = new OgrData.services.ServicesAdminLogin();
            //OgrData.Models.TblAdmin admin = new OgrData.Models.TblAdmin();
            var userID = usersAdminLoginServices.AdminLogin(admin.AdminUserName, admin.AdminPasword);

            if (userID != 0 && userID > 0)
            {
                //login yaptığımızda session kontrol edilip ıd kaydediliyor
                HttpContext.Session.SetInt32("AdminLoginKontrol", userID);
                return RedirectToAction("Index1", "Admin");
            }
            return View();
        }
        [ısAdminLogin]
        public IActionResult Index1()
        {
            return View();
        }
    }
}
