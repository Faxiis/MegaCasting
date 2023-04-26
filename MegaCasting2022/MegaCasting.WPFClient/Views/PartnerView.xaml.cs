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
    /// Logique d'interaction pour PartnerView.xaml
    /// </summary>
    public partial class PartnerView : UserControl
    {
        public DbSet<DiffusionPartner> DiffusionPartners { get; set; }

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

        public PartnerView()
        {
            InitializeComponent();
        }

        private void SaveDiffusionPartner_Click(object sender, RoutedEventArgs e)
        {   //Sauvergarde du partenaire modifié
            ((PartnerViewModel)this.DataContext).Save();
        }

        //Ajout du partenaire
        private void AddDiffusionPartner_Click(object sender, RoutedEventArgs e) => ((PartnerViewModel)this.DataContext).Add();

        //Suppression du partenaire
        private void DeleteDiffusionPartner_Click(object sender, RoutedEventArgs e)
        {
            if (DatagridDiffusionPartner.SelectedItem == null)
            {
                MessageBox.Show("Aucun partenaire séléctionner");
                return;
            }
            ((PartnerViewModel)this.DataContext).Delete();
        }

        //Vérifi si les champs ne sont pas vide
        private void Email_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void Phone_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void Name_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();

        //Vérifi si les champs ne sont pas vide
        private void CheckAddButtonEnability()
        {
            this.AddDiffusionPartner.IsEnabled =(
                !string.IsNullOrWhiteSpace(Name.Text)
                && !string.IsNullOrWhiteSpace(Phone.Text)
                && !string.IsNullOrWhiteSpace(Email.Text)
                );
        }
    }
}
