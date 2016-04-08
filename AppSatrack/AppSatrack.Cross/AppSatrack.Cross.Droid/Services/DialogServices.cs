using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppSatrack.Infraestructure.Contracts;

namespace AppSatrack.Cross.Services
{
    public class DialogServices : IDialogService
    {
        public void ShowMessage(string title, string text)
        {
            App.navigationPage.DisplayAlert(title, text, "ok");
        }

    }
}