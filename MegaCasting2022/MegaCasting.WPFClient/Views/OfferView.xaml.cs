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

            ExperienceFiltre.ItemsSource = Experiences;
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

        private void ExperienceFiltre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedExperience = (sender as ComboBox).SelectedItem as Experience;

            Datagrid1.ItemsSource = Offers.Where(o => o.Experience.Id == selectedExperience.Id);
        }


    }
}

