using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Pack
    {
        public Pack()
        {
            IdentifierPacks = new HashSet<Client>();
        }

        public int Identifier { get; set; }
        public string Label { get; set; } = null!;
        public int OffersNumber { get; set; }
        public double Price { get; set; }

        public virtual ICollection<Client> IdentifierPacks { get; set; }
    }
}
