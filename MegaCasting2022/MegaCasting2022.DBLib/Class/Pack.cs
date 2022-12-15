using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Pack
    {
        public int Identifier { get; set; }
        public string Label { get; set; } = null!;
        public int? OfferNumber { get; set; }
        public double? Price { get; set; }
    }
}
