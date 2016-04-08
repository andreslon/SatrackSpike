using AppSatrack.Infraestructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSatrack.Infraestructure.Enumerations;
using Xamarin.Forms;
using AppSatrack.Cross.Views;
using AppSatrack.Cross.Services;

namespace AppSatrack.Cross.Services
{
    public class NavigationsServices : INavigationsService
    {
        public NavigationsServices() {

        }
        public async void NavigateTo(PageTypes pages)
        {
            Page page;
            switch (pages)
            {               
                case PageTypes.Login:
                    App.Current.MainPage = new LoginPage();
                    break;
                case PageTypes.Main:                   
                    break;
                case PageTypes.AlarmDetail:
                    page = new AlarmDetailPage();
                    NavigationPage.SetBackButtonTitle(page, "Atras");
                    await App.navigationPage.PushAsync(page);
                    break;
                default:
                    App.Current.MainPage = new LoginPage();
                    break;
            }            
        }
    }
}
