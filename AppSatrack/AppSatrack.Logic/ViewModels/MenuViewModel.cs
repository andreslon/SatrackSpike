﻿using AppSatrack.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSatrack.Logic.ViewModels
{
    public class MenuViewModel : BindableBase
    {
        public MenuViewModel()
        {

        }

        public string title { get; set; }

        public string image { get; set; }


    }
}
