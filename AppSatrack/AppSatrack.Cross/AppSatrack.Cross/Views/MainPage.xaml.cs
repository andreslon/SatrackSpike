using AppSatrack.Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppSatrack.Cross.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();
            listViewAlarma.ItemsSource = ((MainViewModel)this.BindingContext).listAlarma;

            listViewAlarma.ItemSelected += ListViewAlarma_ItemSelected;
        }

        async void ListViewAlarma_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DetailAlarmPage detailPage = new DetailAlarmPage();
            NavigationPage.SetBackButtonTitle(detailPage, "Back"); //iOS
            await App.navigationPage.PushAsync(detailPage);
        }

        //OnResume
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        //OnPause
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
