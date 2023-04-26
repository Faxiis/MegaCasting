using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Civility
    {
        public Civility()
        {
            IdentifierCivilities = new HashSet<Offer>();
        }

        public int Identifier { get; set; }
        public string ShortLabel { get; set; } = null!;
        public string Longlabel { get; set; } = null!;

        public virtual ICollection<Offer> IdentifierCivilities { get; set; }
    }
}
