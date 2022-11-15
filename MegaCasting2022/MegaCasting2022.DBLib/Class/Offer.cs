using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Offer
    {
        public long Identifier { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime ParutionDateTime { get; set; }
        public long IndentifierContractType { get; set; }
        public long IdentifierClient { get; set; }

        public virtual Client IdentifierClientNavigation { get; set; } = null!;
        public virtual ContractType IndentifierContractTypeNavigation { get; set; } = null!;
    }
}
