using System;
using System.Collections.Generic;

namespace MegaCasting.WPFClient.Class
{
    public partial class Activity
    {
        public Activity()
        {
            IdentifierActivities = new HashSet<Offer>();
        }

        public int Identifier { get; set; }
        public string Name { get; set; } = null!;
        public int IdentifierActivityDomain { get; set; }

        public virtual ActivityDomain IdentifierActivityDomainNavigation { get; set; } = null!;

        public virtual ICollection<Offer> IdentifierActivities { get; set; }
    }
}
