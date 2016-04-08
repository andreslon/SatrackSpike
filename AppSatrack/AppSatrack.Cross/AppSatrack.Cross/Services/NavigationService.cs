using AppSatrack.Cross.Views;
using AppSatrack.Infrastructure.Enums;
using AppSatrack.Infrastructure.Interfaces;
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
        async public void Navegar(PageTypes Page)
        {
            switch (Page)
            {
                case PageTypes.AlarmasDetail:
                    DetailAlarmPage detailPage = new DetailAlarmPage();
                    NavigationPage.SetBackButtonTitle(detailPage, "Back"); //iOS
                    await App.navigationPage.PushAsync(detailPage);
                    break;
                default: break;
            }
        }
    }
}
