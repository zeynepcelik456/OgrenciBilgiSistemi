using System;
using System.Collections.Generic;

#nullable disable

namespace OgrData.Models
{
    public partial class TblAdmin
    {
        public int Id { get; set; }
        public string AdminAdı { get; set; }
        public string AdminSoyadı { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPasword { get; set; }
    }
}
