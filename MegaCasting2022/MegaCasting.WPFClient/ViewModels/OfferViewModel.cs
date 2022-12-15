using MegaCasting2022.DBLib.Class;
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
        private ObservableCollection<Offer> _Offers;

        public ObservableCollection<Offer> Offers 
        {
            get { return _Offers; }
            set { _Offers = value; }
        }

        private Offer _SelectedOffer;

        public Offer SelectedOffer
        {
            get { return _SelectedOffer; }
            set { _SelectedOffer = value; }
        }

        private ObservableCollection<ContractType> _ContractTypes;

        public ObservableCollection<ContractType> ContractTypes
        {
            get { return _ContractTypes; }
            set { _ContractTypes = value; }
        }

        private ContractType _SelectedContractType;

        public ContractType SelectedContractType
        {
            get { return _SelectedContractType; }
            set { _SelectedContractType = value; }
        }

        private ObservableCollection<ActivityDomain> _ActivityDomains;

        public ObservableCollection<ActivityDomain> ActivityDomains
        {
            get { return _ActivityDomains; }
            set { _ActivityDomains = value; }
        }

        private ActivityDomain _SelectedActivityDomain;

        public ActivityDomain SelectedActivityDomainerty
        {
            get { return _SelectedActivityDomain; }
            set { _SelectedActivityDomain = value; }
        }

        private ObservableCollection<Client> _Clients;

        public ObservableCollection<Client> Clients
        {
            get { return _Clients; }
            set { _Clients = value; }
        }

        private Client _SelectedClient;

        public Client SelectedClient
        {
            get { return _SelectedClient; }
            set { _SelectedClient = value; }
        }


        public OfferViewModel(MegaCastingCsharpContext megaCastingCsharpContext)
            : base(megaCastingCsharpContext)
        {
            this.Entities.Offers.ToList();
            this.Offers = this.Entities.Offers.Local.ToObservableCollection();

            this.Entities.ContractTypes.ToList();
            this.ContractTypes = this.Entities.ContractTypes.Local.ToObservableCollection();

            this.Entities.ActivityDomains.ToList();
            this.ActivityDomains = this.Entities.ActivityDomains.Local.ToObservableCollection();

            this.Entities.Clients.ToList();
            this.Clients = this.Entities.Clients.Local.ToObservableCollection();
        }

    }
}
