using System;
using System.Collections.Generic;

#nullable disable

namespace OgrData.Models
{
    public partial class TblDer
    {
        public TblDer()
        {
            TblOgrenciDers = new HashSet<TblOgrenciDer>();
        }

        public int ıd { get; set; }
        public string DersAdi { get; set; }
        public string DersKodu { get; set; }
        public int? DersKredi { get; set; }
        public int? Bolum { get; set; }

        public virtual TblBolum BolumNavigation { get; set; }
        public virtual ICollection<TblOgrenciDer> TblOgrenciDers { get; set; }
    }
}
