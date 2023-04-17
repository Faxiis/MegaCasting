using MegaCasting2022.DBLib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPFClient.ViewModels
{
    public class PartnerViewModel : ViewModelBase
    {
     
       
        private ObservableCollection<DiffusionPartner> _DiffusionPartners;

        
        public ObservableCollection<DiffusionPartner> DiffusionPartners
        {
            get { return _DiffusionPartners; }
            set { _DiffusionPartners = value; }
        }

        private DiffusionPartner _SelectedDiffusionPartner;

        public DiffusionPartner SelectedDiffusionPartner
        {
            get { return _SelectedDiffusionPartner; }
            set { _SelectedDiffusionPartner = value; }
        }

        private DiffusionPartner _PartnerToAdd;

        public DiffusionPartner PartnerToAdd
        {
            get { return _PartnerToAdd; }
            set { _PartnerToAdd = value; }
        }

        public PartnerViewModel(MegaCastingCsharpContext megaCastingCsharpContext)
    : base(megaCastingCsharpContext)
        {
            this.PartnerToAdd = new DiffusionPartner();
            this.Entities.DiffusionPartners.ToList();
            this.DiffusionPartners = this.Entities.DiffusionPartners.Local.ToObservableCollection();
        }

        /// <summary>
        /// Ajout de Client
        /// </summary>
        public void Add()
        {
            //Ajout du Client
            this.Entities.DiffusionPartners.Add(this.PartnerToAdd);
            this.PartnerToAdd = new DiffusionPartner();
            this.Entities.SaveChanges();
        }

        /// <summary>
        /// Suppression du Client
        /// </summary>
        public void Delete()
        {
            //Suppression du Client
            this.Entities.DiffusionPartners.Remove(this.SelectedDiffusionPartner);
            this.Entities.SaveChanges();
        }
    }
}

