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
            lstAlarms.ItemsSource = ((MainViewModel)this.BindingContext).Alarms;

           // lstAlarms.ItemSelected += LstAlarms_ItemSelected;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
        





        async private void LstAlarms_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {


            //if (e.SelectedItem == null) return;
            //((AlarmsViewModel)e.SelectedItem).SelectAlarmCommand.Execute(null);
            //lstAlarms.SelectedItem = null;
 

         
        }
    }
}
