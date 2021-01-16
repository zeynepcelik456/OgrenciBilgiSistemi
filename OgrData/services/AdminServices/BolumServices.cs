using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgrData.services.AdminServices
{
    public class BolumServices
    {
        public List<OgrData.Models.TblBolum> GetAll()
        {
            var bolumler = new List<OgrData.Models.TblBolum>();
            using (var baglanti = new Models.DbOgrSistemContext())
            {
                bolumler = baglanti.TblBolums.ToList();

            }

            return bolumler;
        }

        public int AddBolum(Models.TblBolum deger)
        {

            using (var baglanti = new Models.DbOgrSistemContext())
            {

                baglanti.TblBolums.Add(deger);
                baglanti.SaveChanges();
            }

            return deger.Id;
        }

        public int UpdateBolum(Models.TblBolum deger)
        {
            using (var baglanti = new Models.DbOgrSistemContext())
            {
                var bolum = baglanti.TblBolums.Find(deger.Id);
                bolum.BolumAdı = deger.BolumAdı;
                bolum.BolumAcıklama = deger.BolumAcıklama;
                bolum.BolumEposta = deger.BolumEposta;
                baglanti.SaveChanges();
            }
            return deger.Id;
        }
        public void DeleteBolum(int bolumId)
        {

            using (var baglanti = new Models.DbOgrSistemContext())
            {
                var bolum = baglanti.TblBolums.Find(bolumId);
                if (bolum != null)
                {
                    baglanti.TblBolums.Remove(bolum);

                }
                baglanti.SaveChanges();
            }
            
        }
 
    }
}
