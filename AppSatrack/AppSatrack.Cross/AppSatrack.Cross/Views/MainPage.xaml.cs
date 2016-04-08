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


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var bind = (MainViewModel)BindingContext;
            var lst = bind.listAlarma;

        }
    }
}
