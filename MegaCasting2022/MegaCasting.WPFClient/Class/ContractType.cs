using System;
using System.Collections.Generic;

namespace MegaCasting.WPFClient.Class
{
    public partial class ContractType
    {
        public ContractType()
        {
            Offers = new HashSet<Offer>();
        }

        public int Identifier { get; set; }
        public string Label { get; set; } = null!;
        public string ShortLabel { get; set; } = null!;

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
