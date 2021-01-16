using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgrData.services
{
    public class ServicesGetOgr
    {
        public OgrData.Models.TblLogin GetByData(int id)
        {
            OgrData.Models.TblLogin result = new Models.TblLogin();
            using (var services = new Models.DbOgrSistemContext())
            {
                //ınclude kısmı ekranda ilişkili tabloların aracısıyla görünmesini sağlar
                result = services.TblLogins.Include(x => x.OgrBolumNavigation).FirstOrDefault(x => x.Id == id);

            }

            return result;

        }
    }
}
