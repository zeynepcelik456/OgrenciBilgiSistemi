using System;
using System.Collections.Generic;

#nullable disable

namespace OgrData.Models
{
    public partial class TblHarc
    {
        public int ıd { get; set; }
        public int? Ogrenci { get; set; }
        public double? HarcTutarı { get; set; }
        public string Durum { get; set; }

        public virtual TblLogin OgrenciNavigation { get; set; }
    }
}
