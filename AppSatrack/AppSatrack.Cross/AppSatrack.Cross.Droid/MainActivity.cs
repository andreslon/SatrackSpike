﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using AppSatrack.Infraestructure.Contracts;
using AppSatrack.Cross.Services;

namespace AppSatrack.Cross.Droid
{
    [Activity(Label = "AppSatrack.Cross", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
       

        protected override void OnCreate(Bundle bundle)
        {
            App.DependencyContainerService = new DependencyContainerService();
            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate(bundle);
            Forms.Init(this, bundle);
            LoadApplication(new App());
            
        }
    }
}

