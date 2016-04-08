using AppSatrack.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSatrack.Logic.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public List<MenuViewModel> listmenu { get; set; }
        public List<AlarmsViewModel> Alarms { get; set; }
        public AlarmsViewModel selectAlarm { get; set; }

        public MainViewModel()
        {
            listmenu = new List<MenuViewModel>();
            listmenu.Add(new MenuViewModel { title = "Ubicaciones", image = "icon.png" });
            listmenu.Add(new MenuViewModel { title = "Alarmas", image = "icon.png" });
            listmenu.Add(new MenuViewModel { title = "Noticias", image = "icon.png" });
            selectAlarm = new AlarmsViewModel();
            Alarms = new List<AlarmsViewModel>();
            GetAlarms();
        }


        public void GetAlarms()
        {
            //api
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Boton de panico", Vehicle = "FHH761", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH762", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Ingreso de region", Vehicle = "FHH763", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH764", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Boton de panico", Vehicle = "FHH765", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH766", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH767", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Boton de panico", Vehicle = "FHH768", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH769", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH711", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Ingreso de region", Vehicle = "FHH712", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH713", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Boton de panico", Vehicle = "FHH714", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH715", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH716", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Boton de panico", Vehicle = "FHH717", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Ingreso de region", Vehicle = "FHH718", AlarmDate = DateTime.Now, _Attend = true });
        }


    }
}
