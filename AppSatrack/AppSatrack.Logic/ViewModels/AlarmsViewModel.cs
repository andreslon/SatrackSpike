using AppSatrack.Infrastructure;
using AppSatrack.Infrastructure.Contracts;
using AppSatrack.Infrastructure.Enumerations;
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
        public INavigationService navigationService;
        public AlarmsViewModel()
        {
           // navigationService = GetInstance<INavigationService>();
        }



        public string Evento { get; set; }
        public string Placa { get; set; }
        public DateTime Fecha { get; set; }
        public bool _Atendida { get; set; }

        public bool Permiso { get; set; }

        public string Atendida
        {
            get
            {
                return _Atendida ? "Atendida" : "No atendida";
            }
        }



        public ICommand SelectAlarmCommand { get { return new RelayCommand(Select); } }

        private void Select()
        {
            navigationService = GetInstance<INavigationService>();
            navigationService.NavigateTo(PageTypes.AlarmDetail);

        }
    }
}
