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
    public class AlarmsViewModel : ViewModelBase
    {
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

        public AlarmsViewModel()
        {

        }

        public ICommand SelectAlarmCommand { get { return new RelayCommand(Select); } }

        private void Select()
        {


            //


            //Progress




        }
    }
}
