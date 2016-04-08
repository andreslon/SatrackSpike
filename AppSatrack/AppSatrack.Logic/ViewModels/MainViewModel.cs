using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSatrack.Logic.ViewModels
{
    public class MainViewModel
    {
        public List<MenuViewModel> listmenu;
        public List<AlarmaViewModel> listAlarma;

        public MainViewModel()
        {
            listmenu = new List<MenuViewModel>();
            listmenu.Add(new MenuViewModel { title="Ubicaciones", image="icon.png"});
            listmenu.Add(new MenuViewModel { title = "Alarmas", image = "icon.png" });
            listmenu.Add(new MenuViewModel { title = "Noticias", image = "icon.png" });

            //Alarmas view model
            listAlarma = new List<AlarmaViewModel>();
            ObtenerAlarmas();
        }

        private void ObtenerAlarmas()
        {
            ///TODO: Consumo al API
            listAlarma.Add(new AlarmaViewModel {Atendida = true, Fecha = DateTime.Now, Placa = "PLACA1", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = false, Fecha = DateTime.Now, Placa = "PLACA2", TipoEvento = "Abandono de Región" });
            listAlarma.Add(new AlarmaViewModel { Atendida = true, Fecha = DateTime.Now, Placa = "PLACA3", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = false, Fecha = DateTime.Now, Placa = "PLACA4", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = true, Fecha = DateTime.Now, Placa = "PLACA5", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = true, Fecha = DateTime.Now, Placa = "PLACA6", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = true, Fecha = DateTime.Now, Placa = "PLACA7", TipoEvento = "Ingreso a Región" });
            listAlarma.Add(new AlarmaViewModel { Atendida = false, Fecha = DateTime.Now, Placa = "PLACA8", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = true, Fecha = DateTime.Now, Placa = "PLACA9", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = false, Fecha = DateTime.Now, Placa = "PLACA10", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = false, Fecha = DateTime.Now, Placa = "PLACA11", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = false, Fecha = DateTime.Now, Placa = "PLACA12", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = true, Fecha = DateTime.Now, Placa = "PLACA13", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = false, Fecha = DateTime.Now, Placa = "PLACA14", TipoEvento = "Botón de Pánico" });
            listAlarma.Add(new AlarmaViewModel { Atendida = true, Fecha = DateTime.Now, Placa = "PLACA15", TipoEvento = "Botón de Pánico" });
        }
    }
}
