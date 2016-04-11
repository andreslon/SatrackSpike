using AppSatrack.Cross.Views;
using AppSatrack.Cross.Views.Base;
using AppSatrack.Infrastructure.Contracts;
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
        public static NavigationPage navigationPage;
        public static IDependencyContainerService DependencyContainerService { get; set; }

        internal static void SetUbicacionesPage()
        {
            throw new NotImplementedException();
        }

        public App()
        {
            InitializeComponent();
            //MainPage = new LoginPage();



            masterDetailPage = new MasterDetailPage();
            var page = new MainPage();

            navigationPage = new NavigationPage(page)
            {
                BarBackgroundColor= (Color)App.Current.Resources["PrimaryColor"],
                BarTextColor = (Color)App.Current.Resources["LightColor"],

            };
            NavigationPage.SetBackButtonTitle(page, "Atrás");
            //NavigationPage.SetTitleIcon(page, "icon.png");

            masterDetailPage.Master = new MenuPage();
            masterDetailPage.Detail = navigationPage;
            MainPage = masterDetailPage;


        }
    }
}
