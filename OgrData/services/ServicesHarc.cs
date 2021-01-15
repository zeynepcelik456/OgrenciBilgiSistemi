using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace OgrData.services
{
    public class ServicesHarc
    {
        public OgrData.Models.TblHarc GetByHarc(int id)
        {
            OgrData.Models.TblHarc result = new Models.TblHarc();
            using (var services = new Models.DbOgrSistemContext())
            {
                result = services.TblHarcs.Include(x => x.OgrenciNavigation).FirstOrDefault(x => x.OgrenciNavigation.Id == id);

            }

            return result;

        }
    }
}