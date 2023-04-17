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
            //Sauvegarde du client modifié 
            ((ClientViewModel)this.DataContext).Save();
        }

        //Ajout du Client
        private void AddClient_Click(object sender, RoutedEventArgs e) => ((ClientViewModel)this.DataContext).Add();

        //Suppression du Client
        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {
            if (DatagridClient.SelectedItem == null)
            {
                MessageBox.Show("Aucun client séléctionner");
                return;
            }
            ((ClientViewModel)this.DataContext).Delete();
        }

        //Vérifi si les champs ne sont pas vide
        private void Nom_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void telephone_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void Email_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void Adresse_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void CodePostal_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void Ville_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void Description_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();

        //Vérifi si les champs ne sont pas vide
        private void CheckAddButtonEnability()
        {
            this.AddClient.IsEnabled = (
                !string.IsNullOrWhiteSpace(Nom.Text)
                && !string.IsNullOrWhiteSpace(telephone.Text)
                && !string.IsNullOrWhiteSpace(Email.Text)
                && !string.IsNullOrWhiteSpace(Adresse.Text)
                && !string.IsNullOrWhiteSpace(CodePostal.Text)
                && !string.IsNullOrWhiteSpace(Ville.Text)
                && !string.IsNullOrWhiteSpace(Description.Text)
                );
        }

    }
}
