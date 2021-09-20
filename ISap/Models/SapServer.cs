using System;
using System.Collections.Generic;

#nullable disable

namespace ISap.Models
{
    public partial class SapServer
    {
        public int IdSapServer { get; set; }
        public string DbName { get; set; }
        public string CmpName { get; set; }
        public string VersStr { get; set; }
        public string Loc { get; set; }

    }
}
