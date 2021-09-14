using System;
using System.Collections.Generic;

#nullable disable

namespace ISap.Models
{
    public partial class DbServer
    {
        public int IdDbServer { get; set; }
        public string ServerType { get; set; }
        public string ServerName { get; set; }
        public string ServerUser { get; set; }
        public string ServerPass { get; set; }
    }
}
