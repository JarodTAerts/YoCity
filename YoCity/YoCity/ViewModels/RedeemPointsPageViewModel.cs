using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using YoCity.Helpers;
using YoCity.Models;

namespace YoCity.ViewModels
{
	public class RedeemPointsPageViewModel : ViewModelBase
	{
        #region Delegates and Bindable Properties
        public static double Heading = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 1.2;

        private ObservableCollection<Sawg> _itemList;
        public ObservableCollection<Sawg> ItemList
        {
            get { return _itemList; }
            set { SetProperty(ref _itemList,value); }
        }

        private Sawg _selectedSwag;
        public Sawg SelectedSwag
        {
            get => _selectedSwag;
            set
            {
                SetProperty(ref _selectedSwag, value);
                ShowSwag();
            }
        }
        #endregion

        #region Constructor
        public RedeemPointsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            ItemList = APIHelper.GetSwag();
        }
        #endregion

        private async void ShowSwag()
        {
            if (SelectedSwag != null)
            {
                Sawg sendSwag = SelectedSwag;
                SelectedSwag = null;
                NavigationParameters navParams = new NavigationParameters();
                navParams.Add("SWAG", sendSwag);
                await NavigationService.NavigateAsync("DisplayItemPage", navParams);
                SelectedSwag = null;
            }
        }
    }
}
