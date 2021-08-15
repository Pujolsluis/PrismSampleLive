using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace PrismTest.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        public DelegateCommand OnLoginCommand { get; set; }
        INavigationService _navigationService;
        IPageDialogService _pageDialogService;

        public string _userName;
        public string Username
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        public string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public LoginPageViewModel(INavigationService navigationService,
               IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;

            OnLoginCommand = new DelegateCommand(async () => await GoMainPage());
        }

        private async Task GoMainPage()
        {
            if (string.IsNullOrEmpty(Username))
                await _pageDialogService.DisplayAlertAsync("Error", "Username is required", "Ok");
            else
                await _navigationService.NavigateAsync("MainPage");
            //await _navigationService.NavigateAsync(new Uri($"MainPage"));
        }
    }
}
