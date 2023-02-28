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
    /// Logique d'interaction pour OfferView.xaml
    /// </summary>
    public partial class OfferView : UserControl
    {
        public DbSet<Offer> Offers { get; set; }

        public DbSet<ContractType> ContractTypes { get; set; }


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

        public OfferView()
        {
            InitializeComponent();
        }

        private void SaveOffer_Click(object sender, RoutedEventArgs e)
        {
            ((OfferViewModel)this.DataContext).Save();
        }

        private void AddOffer_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MegaCastingCsharpContext())
            {

                // créez un nouvel objet offer à partir des informations saisies par l'utilisateur
                var offer = new Offer
                {
                    Label = Nom.Text,
                    Description = Description.Text,
                    ParutionDateTime = ParutionDateTime.SelectedDate.Value,
                    Reference = Reference.Text,
                    OfferDateTime = StartDate.SelectedDate.Value,
                    OfferEndDate = EndDate.SelectedDate.Value,
                    Localisation = Localisation.Text,
                    IdentifierActivityDomain = ((ActivityDomain.SelectedItem as ActivityDomain)?.Identifier ?? 0),
                    IdentifierClient = ((Client.SelectedItem as Client)?.Identifier ?? 0),
                    IndentifierContractType = ((ContractType.SelectedItem as ContractType)?.Identifier ?? 0),

                };

                // ajoutez l'objet offer à la base de données et actualisation datagrid
                context.Offers.Add(offer);
                Datagrid1.Items.Refresh();
                context.SaveChanges();
                Datagrid1.Items.Refresh();
                var offers = context.Offers;
                Datagrid1.ItemsSource = offers.ToList();
            }
        }

        private void DeleteOffer_Click(object sender, RoutedEventArgs e)
        {
            using ( var context = new MegaCastingCsharpContext())
            {
                Offer selecteOffer = (Offer)Datagrid1.SelectedItem;
                Offer offerToDelete = context.Offers.Where(e => e.Identifier == selecteOffer.Identifier).FirstOrDefault();
                context.Offers.Remove(offerToDelete);
                Datagrid1.Items.Refresh();
                context.SaveChanges();
                Datagrid1.Items.Refresh();
                var offers = context.Offers;
                Datagrid1.ItemsSource = offers.ToList();
            }

        }
    }
}

