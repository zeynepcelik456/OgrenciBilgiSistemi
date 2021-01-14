using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgrData.services
{
    public class ServicesLogin
    {
        //bu kısımda login işlemini kontrol ettiriyoruz
        public int Login(string okulno, string sifre)
        {
            int result = 0;
            using (var services = new Models.DbOgrSistemContext())
            {
                var userLogin = services.TblLogins.FirstOrDefault(x => x.OkulNo == okulno && x.Sıfre == sifre);
                result = userLogin != null && userLogin.Id > 0 ? userLogin.Id : 0;
            }

            return result;
        }

        public OgrData.Models.TblLogin GetByData(int id)
        {
            OgrData.Models.TblLogin result = new Models.TblLogin();
            using (var services = new Models.DbOgrSistemContext())
            {
                 result = services.TblLogins.FirstOrDefault(x => x.Id==id);
                
            }

            return result;

        }
    }
}
