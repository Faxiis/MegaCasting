using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class DiffusionPartner
    {
        public int Identifier { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
