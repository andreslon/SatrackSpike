using AppSatrack.Infrastructure;
using AppSatrack.Infrastructure.Enums;
using AppSatrack.Infrastructure.Interfaces;
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
    public class AlarmaViewModel : BindableBase
    {
        public INavigationService navigationService;
        public string TipoEvento { get; set; }
        public string Placa { get; set; }
        public DateTime Fecha { get; set; }
        public bool Atendida { get; set; }
        public string TextoAtendida
        {
            get
            {
                return Atendida ? "Atendida" : "No Atendida";
            }
        }

        public AlarmaViewModel()
        {
            navigationService = GetInstance<INavigationService>();
        }

        //Metodo que se ejecuta en cuando se toca un Item de la lista. Este comando se debe adicionar al item de la lista
        public ICommand SelectAlarmCommand { get { return new RelayCommand(Select); } }

        private void Select()
        {
            //Aqui iría toda la logica que realiza la accion. Por ejemplo: Ir al detalle de la alarma.
            navigationService.Navegar(PageTypes.AlarmasDetail);
        }
    }
}
