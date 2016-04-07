using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSatrack.Logic.ViewModels
{
    public class MainViewModel
    {
        List<MenuViewModel> listmenu;
        public MainViewModel()
        {
            listmenu = new List<MenuViewModel>();
            listmenu.Add(new MenuViewModel { title="Ubicaciones", image="icon.png"});
            listmenu.Add(new MenuViewModel { title = "Alarmas", image = "icon.png" });
            listmenu.Add(new MenuViewModel { title = "Noticias", image = "icon.png" });
        }

    }
}
