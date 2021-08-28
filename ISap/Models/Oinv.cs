using System;
using System.Collections.Generic;

#nullable disable

namespace ISap.Models
{
    public partial class Oinv
    {
        public Oinv()
        {
            Inv1s = new HashSet<Inv1>();
            Orcts = new HashSet<Orct>();
        }

        public int IdOinv { get; set; }
        public int? DocEntry { get; set; }
        public int? DocNum { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime TaxDate { get; set; }
        public DateTime DocDueDate { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public decimal DocTotal { get; set; }
        public int SyncronizedBy { get; set; }
        public DateTime SyncronizedDate { get; set; }
        public TimeSpan SyncronizedTime { get; set; }

        public virtual Ousr SyncronizedByNavigation { get; set; }
        public virtual ICollection<Inv1> Inv1s { get; set; }
        public virtual ICollection<Orct> Orcts { get; set; }
    }
}
