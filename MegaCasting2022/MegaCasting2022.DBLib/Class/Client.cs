using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Client
    {
        public Client()
        {
            Offers = new HashSet<Offer>();
        }

        public long Identifier { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string AddressZipCode { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
