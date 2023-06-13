using System;
using System.Collections.Generic;

namespace MegaCasting.WPFClient.Class
{
    public partial class DiffusionPartner
    {
        public int Identifier { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
