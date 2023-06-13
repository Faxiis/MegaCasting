using System;
using System.Collections.Generic;

namespace MegaCasting.WPFClient.Class
{
    public partial class ActivityDomain
    {
        public ActivityDomain()
        {
            Activities = new HashSet<Activity>();
        }

        public int Identifier { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Activity> Activities { get; set; }
    }
}
