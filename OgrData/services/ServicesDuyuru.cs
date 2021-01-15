using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OgrData.Models;

namespace OgrData.services
{
    public class ServicesDuyuru
    {
        public List<OgrData.Models.TblDuyuru> GetByDuyuru()
        {
            var duyurulist = new List<OgrData.Models.TblDuyuru>();
           
            using (var baglanti = new Models.DbOgrSistemContext())
            {

                duyurulist = baglanti.TblDuyurus.ToList();
                
            }

            return duyurulist;

        }

    }
}
