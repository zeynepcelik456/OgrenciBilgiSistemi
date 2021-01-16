using System;
using System.Collections.Generic;
using System.Text;

namespace OgrData.services
{
    public class ServicesSifreGuncelleme
    {
        public int sıfreGuncelle(OgrData.Models.TblLogin s)
        {
            int result = 0;
            using (OgrData.Models.DbOgrSistemContext db = new OgrData.Models.DbOgrSistemContext())
            {
                var ogr = db.TblLogins.Find(s.Id);
                ogr.Sıfre = s.Sıfre;
                db.SaveChanges();

            }
            result = s.Id;
            return result;




        }

    }
}
