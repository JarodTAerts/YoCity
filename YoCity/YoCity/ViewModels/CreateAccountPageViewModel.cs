using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using YoCity.Helpers;
using YoCity.Models;

namespace YoCity.ViewModels
{
	public class CreateAccountPageViewModel : ViewModelBase
    {
        public DelegateCommand CreateAccountButtonClickedCommand { get; set; }
        public DelegateCommand BackButtonClickedCommand { get; set; }

        private string _fullNameText;
        public string FullNameText
        {
            get { return _fullNameText; }
            set { SetProperty(ref _fullNameText,value); CheckValidEntries(); }
        }

        private string _usernameText;
        public string UsernameText
        {
            get { return _usernameText; }
            set { SetProperty(ref _usernameText, value); CheckValidEntries(); }

        }

        private string _emailText;
        public string EmailText
        {
            get { return _emailText; }
            set { SetProperty(ref _emailText, value); CheckEmailText(); CheckValidEntries(); }
        }

        private string _passwordText;
        public string PasswordText
        {
            get { return _passwordText; }
            set { SetProperty(ref _passwordText, value); CheckValidEntries(); }
        }

        private string _passwordText1;
        public string PasswordText1
        {
            get { return _passwordText1; }
            set { SetProperty(ref _passwordText1, value); CheckPasswordMatch(); CheckValidEntries(); }
        }

        private string _errorText;
        public string ErrorText
        {
            get { return _errorText; }
            set { SetProperty(ref _errorText, value); }
        }

        private bool _showError;
        public bool ShowError
        {
            get { return _showError; }
            set { SetProperty(ref _showError, value); }
        }

        private bool _buttonEnabled;
        public bool ButtonEnabled
        {
            get { return _buttonEnabled; }
            set { SetProperty(ref _buttonEnabled, value); }
        }


        public CreateAccountPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            CreateAccountButtonClickedCommand = new DelegateCommand(CreateAccountButtonClicked);
            BackButtonClickedCommand = new DelegateCommand(BackButtonClicked);
            ErrorText = "Invalid Entry.";
            ShowError = false;
            ButtonEnabled = false;
        }

        private void BackButtonClicked()
        {
            NavigationService.GoBackAsync();
        }

        private void CreateAccountButtonClicked()
        {
            if (FullNameText == null || UsernameText == null || EmailText == null
                || PasswordText == null || PasswordText1 == null)
            {
               ShowError = true;
            }
            if (!ShowError)
            {
                User newUser=APIHelper.CreateUser(new User() { UserName = UsernameText, FullName=FullNameText, Email = EmailText, Points = 0, Rank=0 });
                if (newUser != null)
                {
                    NavigationService.GoBackAsync();
                }
                else
                {
                    ShowError = true;
                    ErrorText = "Problem creating account. Please try again later.";
                }
            }
        }

        private void CheckPasswordMatch()
        {
            if (PasswordText.Equals(PasswordText1))
            {
                ShowError = false;
            }
            else
            {
                ErrorText = "Passwords do not match.";
                ShowError = true;
            }
        }

        private void CheckEmailText()
        {
            if (!HelperFunctions.IsValidEmail(EmailText))
            {
                ShowError = true;
                ErrorText = "Not a valid email. Please fix.";
            }
            else
            {
                ShowError = false;
            }
        }

        private void CheckValidEntries()
        {
            Console.WriteLine("Checking entries: {0}", ButtonEnabled);
            if (FullNameText == null || UsernameText == null || EmailText == null
                || PasswordText == null || PasswordText1 == null)
            {
                ButtonEnabled = false;
            }
            else
            {
                ButtonEnabled = true;
            }
        }


    }
}
