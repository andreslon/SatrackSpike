using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSatrack.Logic.ViewModels
{
    public class AlarmsViewModel
    {
        public string TypeEvent { get; set; }
        public string Vehicle { get; set; }
        public DateTime AlarmDate { get; set; }
        public bool _Attend { get; set; }

        public string Attend {

            get
            {
                return _Attend ? "Atendida" : "No Atendida";
            }
           
        }



        public AlarmsViewModel()
        {

        }
    }
}
