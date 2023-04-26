using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Offer
    {
        public Offer()
        {
            IdentifierOffers = new HashSet<Activity>();
            IdentifierOffers1 = new HashSet<User>();
            IdentifierOffersNavigation = new HashSet<Civility>();
        }

        public int Identifier { get; set; }
        public string Label { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime ParutionDateTime { get; set; }
        public DateTime OfferStartDate { get; set; }
        public DateTime OfferEndDate { get; set; }
        public string Localisation { get; set; } = null!;
        public int IdentifierContractType { get; set; }
        public int IdentifierClient { get; set; }
        public int? ProfesionalLevel { get; set; }
        public bool? Sponsor { get; set; }
        public int? Status { get; set; }

        public virtual Client IdentifierClientNavigation { get; set; } = null!;
        public virtual ContractType IdentifierContractTypeNavigation { get; set; } = null!;

        public virtual ICollection<Activity> IdentifierOffers { get; set; }
        public virtual ICollection<User> IdentifierOffers1 { get; set; }
        public virtual ICollection<Civility> IdentifierOffersNavigation { get; set; }

        public String Activities { get { return String.Join(", ", this.IdentifierOffers.Select<Activity, String>(x => x.Name)); } }
        public String Civilities { get { return String.Join(", ", this.IdentifierOffersNavigation.Select<Civility, String>(x => x.ShortLabel)); } }
    }
}
