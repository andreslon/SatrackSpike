using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSatrack.Logic.ViewModels
{
    public class MainViewModel
    {
        public List<MenuViewModel> listmenu { get; set; }
        public List<AlarmsViewModel> Alarms { get; set; }
        public MainViewModel()
        {
            listmenu = new List<MenuViewModel>();
            listmenu.Add(new MenuViewModel { title = "Ubicaciones", image = "icon.png" });
            listmenu.Add(new MenuViewModel { title = "Alarmas", image = "icon.png" });
            listmenu.Add(new MenuViewModel { title = "Noticias", image = "icon.png" });

            Alarms = new List<AlarmsViewModel>();
            GetAlarms();
        }


        public void GetAlarms()
        {
            //api
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = true });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = false });
            Alarms.Add(new AlarmsViewModel { TypeEvent = "Abandono de region", Vehicle = "FHH760", AlarmDate = DateTime.Now, _Attend = true });
        }


    }
}
