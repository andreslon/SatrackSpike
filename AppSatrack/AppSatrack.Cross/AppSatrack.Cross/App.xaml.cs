using AppSatrack.Cross.Views;
using AppSatrack.Cross.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppSatrack.Cross
{
    public partial class App : Application
    {
        MasterDetailPage master = new MasterPage();
        private MasterDetailPage masterDetailPage;
        private NavigationPage navigationPage;

        public App()
        {
            InitializeComponent();
            //MainPage = new LoginPage();



            masterDetailPage = new MasterDetailPage()
            {
                Title = "Master"
            };
            var page = new MainPage();

            navigationPage = new NavigationPage(page)
            {
                BarTextColor = Color.Green,
                Icon = "icon.png",
                BarBackgroundColor = (Color)App.Current.Resources["PrimaryColor"]
            };
            //NavigationPage.SetBackButtonTitle(page, "Atrás");
            NavigationPage.SetTitleIcon(page, "icon.png");

            masterDetailPage.Master = new MenuPage();
            masterDetailPage.Detail = navigationPage;
            MainPage = masterDetailPage;


        }
    }
}
