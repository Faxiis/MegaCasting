using MegaCasting.WPFClient.ViewModels;
using MegaCasting2022.DBLib.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public ClientView()
        {
            InitializeComponent();
        }

        Boolean EmailValide = false;

        private void SaveClient_Click(object sender, RoutedEventArgs e)
        {
            //Sauvegarde du client modifié 
            ((ClientViewModel)this.DataContext).Save();
        }

        //Ajout du Client
        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            if(EmailValide = true)
            {
                ((ClientViewModel)this.DataContext).Add();
            }
            else
            {
                MessageBox.Show("Veuillez rentrer un email valide");
            }
        }

        //Suppression du Client
        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {
            if (DatagridClient.SelectedItem == null)
            {
                MessageBox.Show("Aucun client séléctionner");
                return;
            }

            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette offre ?", "Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                ((ClientViewModel)this.DataContext).Delete();
            }
        }

        private void ShowAddClient_Click(object sender, RoutedEventArgs e)
        {
            AddClientPanel.Visibility = Visibility.Visible;
            Edit.Visibility = Visibility.Collapsed;
        }

        private void ShowEditClient_Click(object sender, RoutedEventArgs e)
        {
            if (DatagridClient.SelectedValue != null)
            {
                Edit.Visibility = Visibility.Visible;
                AddClientPanel.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageBox.Show("Veuillez séléctionner une offre afin de la modifier");
            }
        }


        //Vérifie si les champs ne sont pas vide
        private void Prenom_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void Nom_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void telephone_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void Email_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void Adresse_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void CodePostal_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();
        private void Ville_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();

        //Vérifie si les champs ne sont pas vide
        private void CheckAddButtonEnability()
        {
            this.AddClient.IsEnabled = (
                !string.IsNullOrWhiteSpace(Nom.Text)
                && !string.IsNullOrWhiteSpace(Prenom.Text)
                && !string.IsNullOrWhiteSpace(telephone.Text)
                && !string.IsNullOrWhiteSpace(Email.Text)
                && !string.IsNullOrWhiteSpace(Adresse.Text)
                && !string.IsNullOrWhiteSpace(CodePostal.Text)
                && !string.IsNullOrWhiteSpace(Ville.Text)
                );
        }

        private void Telephone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            /// Vérifie si le texte entré ne contient que des chiffres
            if (!IsTextAllowed(e.Text))
            {
                /// Empêche la saisie de texte si elle ne contient pas que des chiffres
                e.Handled = true;
            }
        }
        private bool IsTextAllowed(string text)
        {
            /// Expression régulière pour valider uniquement les nombres
            Regex regex = new Regex("[^0-9]+"); /// Seul des nombres

            return !regex.IsMatch(text);
        }

        private void Email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Email.Text.Contains("@") || string.IsNullOrEmpty(Email.Text))
            {
                /// Forcer le caractere @ 
                EmailValide = true;
            }
            else
            {
                /// si le caractère "@" n'est pas présent dans l'email
                /// Message erreur
                EmailValide = false;
                MessageBox.Show("L'email n'est pas valide");

            }
        }

    }
}
