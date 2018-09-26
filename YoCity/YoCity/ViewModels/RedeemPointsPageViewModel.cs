using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using YoCity.Helpers;
using YoCity.Models;

namespace YoCity.ViewModels
{
	public class RedeemPointsPageViewModel : BindableBase
	{
        private ObservableCollection<Sawg> _itemList;
        public ObservableCollection<Sawg> ItemList
        {
            get { return _itemList; }
            set { SetProperty(ref _itemList,value); }
        }

        public RedeemPointsPageViewModel()
        {
            ItemList = APIHelper.GetSwag();
        }
	}
}
