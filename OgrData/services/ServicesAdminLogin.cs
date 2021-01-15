using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace OgrData.services
{
   public class ServicesAdminLogin
    {
        public int AdminLogin(string AdminUsername, string adminPassword)
        {
            int result = 0;
            using (var services = new Models.DbOgrSistemContext())
            {
                var adminLogin = services.TblAdmins.FirstOrDefault(x => x.AdminUserName == AdminUsername && x.AdminPasword == adminPassword);
                result = adminLogin != null && adminLogin.Id > 0 ? adminLogin.Id : 0;
            }

            return result;
        }

    }
}