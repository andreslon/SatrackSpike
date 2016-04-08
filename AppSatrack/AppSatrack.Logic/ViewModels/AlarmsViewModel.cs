using AppSatrack.Infraestructure;
using AppSatrack.Infraestructure.Contracts;
using AppSatrack.Infraestructure.Enumerations;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppSatrack.Logic.ViewModels
{
    public class AlarmsViewModel : BindableBase
    {
        public INavigationsService navigationsService;
        public IDialogService DialogService;

        public AlarmsViewModel()
        {
            //navigationsService = GetInstance<INavigationsService>();
            DialogService = GetInstance<IDialogService>();
        }

        public string TypeEvent { get; set; }
        public string Vehicle { get; set; }
        public DateTime AlarmDate { get; set; }
        public bool _Attend { get; set; }

        public string Attend
        {

            get
            {
                return _Attend ? "Atendida" : "No Atendida";
            }

        }




        public ICommand SelectAlarmCommand { get { return new RelayCommand(Select); } }

        private void Select()
        {
            var main = GetInstance<MainViewModel>();
            main.selectAlarm = this;
            navigationsService = GetInstance<INavigationsService>();
            navigationsService.NavigateTo(PageTypes.AlarmDetail);
        }



        public ICommand SelectAttendCommand { get { return new RelayCommand(SelectAttendEvent); } }

        private void SelectAttendEvent()
        {
          
            DialogService.ShowMessage("Artender alarma", "Atemdiendo alarma");
        }

    }
}
