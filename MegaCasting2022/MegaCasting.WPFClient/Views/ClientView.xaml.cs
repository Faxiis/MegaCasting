using MegaCasting.WPFClient.ViewModels;
using MegaCasting2022.DBLib.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaCasting.WPFClient.Views
{
    /// <summary>
    /// Logique d'interaction pour ClientView.xaml
    /// </summary>
    public partial class ClientView : UserControl
    {

        public DbSet<Client> Clients { get; set; }

        #region Attributes
        /// <summary>
        /// Context
        /// </summary>
        private MegaCastingCsharpContext _Entities;
        #endregion

        #region Properties
        /// <summary>
        /// Obtient le context
        /// </summary>
        public MegaCastingCsharpContext Entities
        {
            get { return _Entities; }
            private set { _Entities = value; }

        }
        #endregion

        public ClientView()
        {
            InitializeComponent();
        }

        private void SaveClient_Click(object sender, RoutedEventArgs e)
        {
            ((ClientViewModel)this.DataContext).Save();
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MegaCastingCsharpContext())
            {

                // créez un nouvel objet offer à partir des informations saisies par l'utilisateur
                var client = new Client
                {
                    Name = Nom.Text,
                    Phone = telephone.Text,
                    Email = Email.Text,
                    Description = Description.Text,
                    City = Ville.Text,
                    Address = Adresse.Text,
                    AddressZipCode = CodePostal.Text
                };

                // ajoutez l'objet offer à la base de données et actualisation datagrid
                context.Clients.Add(client);
                DatagridClient.Items.Refresh();
                context.SaveChanges();
                DatagridClient.Items.Refresh();
                var clients = context.Clients;
                DatagridClient.ItemsSource = clients.ToList();
            }
        }

        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MegaCastingCsharpContext())
            {
                Client selectedClient = (Client)DatagridClient.SelectedItem;
                Client clientToDelete = context.Clients.Where(e => e.Identifier == selectedClient.Identifier).FirstOrDefault();
                context.Clients.Remove(clientToDelete);
                DatagridClient.Items.Refresh();
                context.SaveChanges();
                DatagridClient.Items.Refresh();
                var clients = context.Clients;
                DatagridClient.ItemsSource = clients.ToList();
            }

        }
    }
}
