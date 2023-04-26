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
        private MegaCastingContext _Entities;
        #endregion

        #region Properties
        /// <summary>
        /// Obtient le context
        /// </summary>
        public MegaCastingContext Entities
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
            //Sauvegarde de l'offre qui à été modifié
            ((OfferViewModel)this.DataContext).Save();
        }

        private void ShowAddOffer_Click(object sender, RoutedEventArgs e)
        {
            AddOfferPanel.Visibility = Visibility.Visible;
            Edit.Visibility = Visibility.Collapsed;
        }


        private void AddOffer_Click(object sender, RoutedEventArgs e) => ((OfferViewModel)this.DataContext).Add();

        private void ShowEditOffer_Click(object sender, RoutedEventArgs e)
        {
            if (Datagrid1.SelectedValue != null)
            {
                Edit.Visibility = Visibility.Visible;
                AddOfferPanel.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageBox.Show("Veuillez séléctionner une offre afin de la modifier");
            }
        }
        


        private void DeleteOffer_Click(object sender, RoutedEventArgs e)
        {
            if (Datagrid1.SelectedItem == null)
            {
                MessageBox.Show("Aucune offre séléctionner");
                return;
            }
            ((OfferViewModel)this.DataContext).Delete();
        }



    //private void AddOffer_Click(object sender, RoutedEventArgs e)
    //{
    //    using (var context = new MegaCastingContext())
    //    {
    //
    //
    //        // créez un nouvel objet offer à partir des informations saisies par l'utilisateur
    //        var offer = new Offer
    //        {
    //            Label = Nom.Text,
    //            Description = Description.Text,
    //            ParutionDateTime = ParutionDateTime.SelectedDate.Value,
    //            Reference = Reference.Text,
    //            OfferStartDate = StartDate.SelectedDate.Value,
    //            OfferEndDate = EndDate.SelectedDate.Value,
    //            Localisation = Localisation.Text,
    //            IdentifierClient = ((Client.SelectedItem as Client)?.Identifier ?? 0),
    //            IdentifierContractType = ((ContractType.SelectedItem as ContractType)?.Identifier ?? 0),
    //
    //        };
    //
    //        // ajoutez l'objet offer à la base de données et actualisation datagrid
    //        context.Offers.Add(offer);
    //        Datagrid1.Items.Refresh();
    //        context.SaveChanges();
    //        Datagrid1.Items.Refresh();
    //        var offers = context.Offers;
    //        Datagrid1.ItemsSource = offers.ToList();
    //    }
    //}


}
}

