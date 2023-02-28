using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Offer
    {
        public long Identifier { get; set; }
        public string Label { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime ParutionDateTime { get; set; }
        public string Reference { get; set; } = null!;
        public DateTime OfferDateTime { get; set; }
        public DateTime OfferEndDate { get; set; }
        public string Localisation { get; set; } = null!;
        public long IndentifierContractType { get; set; }
        public long IdentifierClient { get; set; }
        public long IdentifierActivityDomain { get; set; }

        public virtual ActivityDomain IdentifierActivityDomainNavigation { get; set; } = null!;
        public virtual Client IdentifierClientNavigation { get; set; } = null!;
        public virtual ContractType IndentifierContractTypeNavigation { get; set; } = null!;


        public string getStatus()
        {
            if(OfferDateTime > DateTime.Now)
            {
                return "A venir";
            }
            if(OfferEndDate < DateTime.Now)
            {
                return "Offre finit";
            }

            return "Offre en cours";

        }
    }
}
