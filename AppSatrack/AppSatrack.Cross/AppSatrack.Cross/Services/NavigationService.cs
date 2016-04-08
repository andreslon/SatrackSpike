using AppSatrack.Cross.Views;
using AppSatrack.Infrastructure.Contracts;
using AppSatrack.Infrastructure.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSatrack.Cross.Services
{
    public class NavigationService : INavigationService
    {

        async public void NavigateTo(PageTypes pagetype)
        {
            Page page;
            switch (pagetype)
            {
                case PageTypes.Login:
                    break;
                case PageTypes.Main:
                    break;
                case PageTypes.AlarmDetail:
                    page = new AlarmDetailPage();
                    NavigationPage.SetBackButtonTitle(page, "Atrás");
                    await App.navigationPage.PushAsync(page);
                    break;
                default:
                    break;
            }

        }
    }
}
