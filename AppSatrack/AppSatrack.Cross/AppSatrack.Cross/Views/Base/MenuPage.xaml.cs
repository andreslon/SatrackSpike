using AppSatrack.Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppSatrack.Cross.Views.Base
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();
            listView.ItemsSource = ((MainViewModel)this.BindingContext).listmenu;
        }
    }
}
