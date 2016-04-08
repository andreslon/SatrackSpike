using AppSatrack.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSatrack.Logic.ViewModels
{
    public class MainViewModel: BindableBase
    {
        public List<MenuViewModel> listmenu { get; set; }
        public List<AlarmsViewModel> Alarms { get; set; }

        public AlarmsViewModel SelectedAlarm { get; set; }

        public MainViewModel()
        {
            listmenu = new List<MenuViewModel>();
            listmenu.Add(new MenuViewModel { title = "Ubicaciones", image = "icon.png" });
            listmenu.Add(new MenuViewModel { title = "Alarmas", image = "icon.png" });
            listmenu.Add(new MenuViewModel { title = "Noticias", image = "icon.png" });

            Alarms = new List<AlarmsViewModel>();
            SelectedAlarm = new AlarmsViewModel();
            GetAlarms();


        }

        private void GetAlarms()
        {
            //api 

            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = true });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = false });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = true });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = false });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = true });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = true });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = false });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = false });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = true });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = false });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = true });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = true });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = true });
            Alarms.Add(new AlarmsViewModel { Evento = "Abandono de la región", Placa = "WLR426", Fecha = DateTime.Now, _Atendida = true });
        }
    }
}
