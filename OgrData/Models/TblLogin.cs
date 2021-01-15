using System;
using System.Collections.Generic;

#nullable disable

namespace OgrData.Models
{
    public partial class TblLogin
    {
        public TblLogin()
        {
            TblHarcs = new HashSet<TblHarc>();
            TblOgrenciDers = new HashSet<TblOgrenciDer>();
        }

        public int Id { get; set; }
        public string OkulNo { get; set; }
        public string Sıfre { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public int? OgrBolum { get; set; }

        public virtual TblBolum OgrBolumNavigation { get; set; }
        public virtual ICollection<TblHarc> TblHarcs { get; set; }
        public virtual ICollection<TblOgrenciDer> TblOgrenciDers { get; set; }
    }
}
