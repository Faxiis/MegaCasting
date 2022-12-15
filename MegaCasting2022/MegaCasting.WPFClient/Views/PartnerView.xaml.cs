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

        public PartnerView()
        {
            InitializeComponent();
        }

        private void SaveDiffusionPartner_Click(object sender, RoutedEventArgs e)
        {
            ((PartnerViewModel)this.DataContext).Save();
        }

        private void AddDiffusionPartner_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MegaCastingCsharpContext())
            {

                // créez un nouvel objet offer à partir des informations saisies par l'utilisateur
                var diffusionPartner = new DiffusionPartner
                {
                     Name = Nom.Text,
                     Phone = telephone.Text,
                     Email = email.Text,    

                };

                // ajoutez l'objet offer à la base de données et actualisation datagrid
                context.DiffusionPartners.Add(diffusionPartner);
                DatagridDiffusionPartner.Items.Refresh();
                context.SaveChanges();
                DatagridDiffusionPartner.Items.Refresh();
                var diffusionpartners = context.DiffusionPartners;
                DatagridDiffusionPartner.ItemsSource = diffusionpartners.ToList();
            }
        }

        private void DeleteDiffusionPartner_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MegaCastingCsharpContext())
            {
                DiffusionPartner selectedDiffusionPartner = (DiffusionPartner)DatagridDiffusionPartner.SelectedItem;
                DiffusionPartner diffusionPartnerToDelete = context.DiffusionPartners.Where(e => e.Identifier == selectedDiffusionPartner.Identifier).FirstOrDefault();
                context.DiffusionPartners.Remove(diffusionPartnerToDelete);
                DatagridDiffusionPartner.Items.Refresh();
                context.SaveChanges();
                DatagridDiffusionPartner.Items.Refresh();
                var diffusionPartner = context.DiffusionPartners;
                DatagridDiffusionPartner.ItemsSource = diffusionPartner.ToList();
            }

        }
    }
}
