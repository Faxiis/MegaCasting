using System;
using System.Collections.Generic;

namespace MegaCasting.WPFClient.Class
{
    public partial class Experience
    {
        public Experience()
        {
            Offers = new HashSet<Offer>();
        }

        public int Id { get; set; }
        public string? Label { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
