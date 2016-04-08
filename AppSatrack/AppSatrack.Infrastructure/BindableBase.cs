using AppSatrack.Infrastructure.Contracts;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSatrack.Infrastructure
{
    public class BindableBase : ViewModelBase
    {
        public static IDependencyContainerService Container { get; set; }

        protected T GetInstance<T>() where T : class
        {
            return Container.Resolve<T>();
        }



    }
}
