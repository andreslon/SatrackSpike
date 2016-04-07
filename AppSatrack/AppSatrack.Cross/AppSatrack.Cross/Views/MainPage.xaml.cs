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
            btn1.Clicked += Btn1_Clicked;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            //Llmar un progress
        }
    }
}
