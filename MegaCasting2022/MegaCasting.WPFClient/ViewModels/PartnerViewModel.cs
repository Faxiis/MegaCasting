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
        public PartnerViewModel(MegaCastingCsharpContext megaCastingCsharpContext)
            : base(megaCastingCsharpContext)
        {
            this.Entities.DiffusionPartners.ToList();
            this.DiffusionPartners = this.Entities.DiffusionPartners.Local.ToObservableCollection();
        }
                    
       
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
    }
}

