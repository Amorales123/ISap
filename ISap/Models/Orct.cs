using System;
using System.Collections.Generic;

#nullable disable

namespace ISap.Models
{
    public partial class Orct
    {
        public int IdOrct { get; set; }
        public int IdOinv { get; set; }
        public int? DocNum { get; set; }
        public DateTime DocDate { get; set; }
        public decimal DocTotal { get; set; }
        public decimal CashSum { get; set; }
        public decimal CreditSum { get; set; }
        public decimal CheckSum { get; set; }
        public decimal TrsfrSum { get; set; }
        public DateTime? SyncronizedDate { get; set; }
        public TimeSpan? SyncronizedTime { get; set; }

        public virtual Oinv IdOinvNavigation { get; set; }
    }
}
