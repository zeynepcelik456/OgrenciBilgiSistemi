using System;
using System.Collections.Generic;

#nullable disable

namespace OgrData.Models
{
    public partial class TblLogin
    {
        public int Id { get; set; }
        public string OkulNo { get; set; }
        public string Sıfre { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
    }
}
