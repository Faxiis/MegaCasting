using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class ActivityDomain
    {
        public ActivityDomain()
        {
            Offers = new HashSet<Offer>();
        }

        public long Identifier { get; set; }
        public string? Label { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
