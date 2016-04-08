using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSatrack.Logic.ViewModels;

using Xamarin.Forms;

namespace AppSatrack.Cross.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
            //listView.ItemSelected += ListView_ItemSelected;
        }

        async private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            AlarmDetailPage page = new AlarmDetailPage();
            NavigationPage.SetBackButtonTitle(page, "Atras");
            await App.navigationPage.PushAsync(page);

        }

        //on resume
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        //pause 
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
