using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Interview
    {
        public int Identifier { get; set; }
        public string Label { get; set; } = null!;
        public string? Url { get; set; }
    }
}
