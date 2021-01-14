using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Helper
{//Kişi Login mi diye kontrol ettiğimiz kısım //yanlışsa loginde kalmasını sağlıyor
    public class IsLogin : ActionFilterAttribute
    {
        //override OnActionExecuting yazarız
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userID = context.HttpContext.Session.GetString("LoginKontrol");
            if (string.IsNullOrEmpty(userID))
            {
                context.Result = new RedirectResult("/Home/Login");
            }

        }
    }
}
