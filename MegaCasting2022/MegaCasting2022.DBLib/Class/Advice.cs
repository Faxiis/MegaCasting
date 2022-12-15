using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Advice
    {
        public int Identifier { get; set; }
        public string Label { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
