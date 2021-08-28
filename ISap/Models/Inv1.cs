using System;
using System.Collections.Generic;

#nullable disable

namespace ISap.Models
{
    public partial class Inv1
    {
        public int IdInv1 { get; set; }
        public int IdOinv { get; set; }
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public decimal Rate { get; set; }
        public decimal DiscPrcnt { get; set; }
        public decimal LineTotal { get; set; }
        public decimal TotalFrgn { get; set; }
        public string TaxCode { get; set; }
        public decimal VatSum { get; set; }
        public decimal VatSumFrgn { get; set; }

        public virtual Oinv IdOinvNavigation { get; set; }
    }
}
