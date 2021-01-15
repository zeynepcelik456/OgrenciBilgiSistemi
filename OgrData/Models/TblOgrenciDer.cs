using System;
using System.Collections.Generic;

#nullable disable

namespace OgrData.Models
{
    public partial class TblOgrenciDer
    {
        public int ıd { get; set; }
        public int? Ogrenci { get; set; }
        public int? Ders { get; set; }
        public double? Vize { get; set; }
        public double? Final { get; set; }

        public virtual TblDer DersNavigation { get; set; }
        public virtual TblLogin OgrenciNavigation { get; set; }
    }
}
