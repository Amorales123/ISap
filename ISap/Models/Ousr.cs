using System;
using System.Collections.Generic;

#nullable disable

namespace ISap.Models
{
    public partial class Ousr
    {
        public Ousr()
        {
            Oinvs = new HashSet<Oinv>();
        }

        public int IdOusr { get; set; }
        public string Usercode { get; set; }
        public string Username { get; set; }

        public virtual ICollection<Oinv> Oinvs { get; set; }
    }
}
