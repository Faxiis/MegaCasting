using MegaCasting2022.DBLib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPFClient.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {


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

        private Client _ClientToAdd;

        public Client ClientToAdd
        {
            get { return _ClientToAdd; }
            set { _ClientToAdd = value; }
        }

        public ClientViewModel(MegaCastingContext megaCastingContext)
        : base(megaCastingContext)
        {
            this.ClientToAdd = new Client();
            this.Entities.Clients.ToList();
            this.Clients = this.Entities.Clients.Local.ToObservableCollection();
        }

        public void Add()
        {
            //Ajout du Client
            this.Entities.Clients.Add(this.ClientToAdd);
            this.ClientToAdd = new Client();
            this.Entities.SaveChanges();
        }

        /// <summary>
        /// Suppression du Client
        /// </summary>
        public void Delete()
        {
            //Suppression du Client
            this.Entities.Clients.Remove(this.SelectedClient);
            this.Entities.SaveChanges();
        }
    }
}
