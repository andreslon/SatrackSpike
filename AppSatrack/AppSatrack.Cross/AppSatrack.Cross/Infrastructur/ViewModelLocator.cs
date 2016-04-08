using AppSatrack.Infraestructure;
using AppSatrack.Infraestructure.Contracts;
using AppSatrack.Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSatrack.Cross.Infrastructur
{
    public class ViewModelLocator
    {
        private static IDependencyContainerService _dependencyContainerService;
        public ViewModelLocator()
        {
            _dependencyContainerService = App.DependencyContainerService;
            BindableBase.Container = _dependencyContainerService;
        }

        public MainViewModel Main
        {
            get
            {
                return _dependencyContainerService.Resolve<MainViewModel>();
            }
        }

    }
}
