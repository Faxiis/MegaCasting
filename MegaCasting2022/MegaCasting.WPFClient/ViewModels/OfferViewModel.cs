using MegaCasting2022.DBLib.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPFClient.ViewModels
{
    public class OfferViewModel : ViewModelBase
    {

        #region Attributes
        private ObservableCollection<Offer> _Offers;
        private Offer _SelectedOffer;
        private Offer _OfferToAdd;
        private ObservableCollection<ContractType> _ContractTypes;
        private ContractType _SelectedContractType;
        private ObservableCollection<Activity> _Activities;
        private Activity _SelectedActivity;
        private ObservableCollection<Client> _Clients;
        private Client _SelectedClient;
        private ObservableCollection<Experience> _Experiences;
        private Experience _SelectedExperience;
        private ObservableCollection<Civility> _Civilities;
        private Civility _SelectedCivility;
        #endregion

        #region Properties
        public ObservableCollection<Offer> Offers
        {
            get { return _Offers; }
            set { _Offers = value; }
        }

        public Offer SelectedOffer
        {
            get { return _SelectedOffer; }
            set { _SelectedOffer = value; }
        }

        public Offer OfferToAdd
        {
            get { return _OfferToAdd; }
            set { _OfferToAdd = value; }
        }

        public ObservableCollection<ContractType> ContractTypes
        {
            get { return _ContractTypes; }
            set { _ContractTypes = value; }
        }

        public ContractType SelectedContractType
        {
            get { return _SelectedContractType; }
            set { _SelectedContractType = value; }
        }

        public ObservableCollection<Activity> Activities
        {
            get { return _Activities; }
            set { _Activities = value; }
        }

        public Activity SelectedActivity
        {
            get { return _SelectedActivity; }
            set { _SelectedActivity = value; }
        }

        public ObservableCollection<Client> Clients
        {
            get { return _Clients; }
            set { _Clients = value; }
        }

        public Client SelectedClient
        {
            get { return _SelectedClient; }
            set { _SelectedClient = value; }
        }

        public ObservableCollection<Experience> Experiences
        {
            get { return _Experiences; }
            set { _Experiences = value; }
        }

        public Experience SelectedExperience
        {
            get { return _SelectedExperience; }
            set { _SelectedExperience = value; }
        }

        public ObservableCollection<Civility> Civilities
        {
            get { return _Civilities; }
            set { _Civilities = value; }
        }

        public Civility SelectedCivility
        {
            get { return _SelectedCivility; }
            set { _SelectedCivility = value; }
        }
        #endregion

        #region Constructor
        public OfferViewModel(MegaCastingContext megaCastingContext)
        : base(megaCastingContext)
        {
            this.OfferToAdd = new Offer();

            // Précharge les collections de navigation many-to-many pour toutes les offres
            this.Entities.Offers
                .Include(o => o.IdentifierOffers)
                //.Include(o => o.IdentifierOffers1)    (Récupération des candidatures si besoin)
                .Include(o => o.IdentifierOffersNavigation)
                .ToList();

            this.Activities = this.Entities.Activities.Local.ToObservableCollection();

            this.Civilities = this.Entities.Civilities.Local.ToObservableCollection();

            this.Entities.Offers.ToList();
            this.Offers = this.Entities.Offers.Local.ToObservableCollection();

            this.Entities.ContractTypes.ToList();
            this.ContractTypes = this.Entities.ContractTypes.Local.ToObservableCollection();

            this.Entities.Clients.ToList();
            this.Clients = this.Entities.Clients.Local.ToObservableCollection();

            this.Entities.Experiences.ToList();
            this.Experiences = this.Entities.Experiences.Local.ToObservableCollection();


        }
        #endregion

        #region Methods
        /// <summary>
        /// Ajout de l'offre
        /// </summary>
        public void Add()
        {
            //Ajout de l'offre
            this.Entities.Offers.Add(this.OfferToAdd);
            this.OfferToAdd = new Offer();
            this.Entities.SaveChanges();
        }

        /// <summary>
        /// Suppression de l'offre
        /// </summary>
        public void Delete()
        {
            //Suppression de l'offre
            this.Entities.Offers.Remove(this.SelectedOffer);
            this.Entities.SaveChanges();
        }
        #endregion
    }
}
