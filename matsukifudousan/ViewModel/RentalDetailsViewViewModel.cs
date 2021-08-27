﻿using matsukifudousan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matsukifudousan.ViewModel
{
    public class RentalDetailsViewViewModel : BaseViewModel
    {
        private ObservableCollection<RentalManagementDB> _RentalDetailsView;
        public ObservableCollection<RentalManagementDB> RentalDetailsView { get => _RentalDetailsView; set { _RentalDetailsView = value; OnPropertyChanged(); } }

        private ObservableCollection<ImageDB> _NameIMG;
        public ObservableCollection<ImageDB> NameIMG { get => _NameIMG; set { _NameIMG = value; OnPropertyChanged(); } }
        public RentalDetailsViewViewModel()
        {
            RentalDetailsView = new ObservableCollection<RentalManagementDB>(DataProvider.Ins.DB.RentalManagementDB.Where(v => v.HouseNo == "6"));

            NameIMG = new ObservableCollection<ImageDB>(DataProvider.Ins.DB.ImageDB.Where(v => v.HouseNo == "6"));


        }
    }
}
