using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoCity.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand LoginButtonClickedCommand { get; set; }

        public string UsernameText="";
        public string PasswordText="";

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
            LoginButtonClickedCommand = new DelegateCommand(LoginButtonClicked);
            
        }

        private void LoginButtonClicked()
        {
            
        }
    }
}
