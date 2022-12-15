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

        public ClientViewModel(MegaCastingCsharpContext megaCastingCsharpContext)
        : base(megaCastingCsharpContext)
        {

            this.Entities.Clients.ToList();
            this.Clients = this.Entities.Clients.Local.ToObservableCollection();
        }
    }
}
