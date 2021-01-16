using System;
using System.Collections.Generic;

#nullable disable

namespace OgrData.Models
{
    public partial class TblBolum
    {
        public TblBolum()
        {
            TblDers = new HashSet<TblDer>();
            TblLogins = new HashSet<TblLogin>();
        }

        public int Id { get; set; }
        public string BolumAdı { get; set; }
        public string BolumAcıklama { get; set; }
        public string BolumEposta { get; set; }

        public virtual ICollection<TblDer> TblDers { get; set; }
        public virtual ICollection<TblLogin> TblLogins { get; set; }

        internal class Find
        {
            public Find()
            {
            }
        }
    }
}
