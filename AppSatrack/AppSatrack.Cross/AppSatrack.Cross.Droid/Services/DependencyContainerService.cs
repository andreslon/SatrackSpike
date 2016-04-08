

using System;
using AppSatrack.Infraestructure.Contracts;
using GalaSoft.MvvmLight.Ioc;
using AppSatrack.Logic.ViewModels;

namespace AppSatrack.Cross.Services
{
    public class DependencyContainerService : IDependencyContainerService
    {
       
            public DependencyContainerService()
            {
                Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
                SimpleIoc.Default.Register<IDependencyContainerService, DependencyContainerService>();
                //Cross Services
                SimpleIoc.Default.Register<IDialogService, DialogServices>();
                SimpleIoc.Default.Register<INavigationsService, NavigationsServices>();
                SimpleIoc.Default.Register<MainViewModel>();

            }
            public T Resolve<T>() where T : class
            {
                return SimpleIoc.Default.GetInstance<T>();
            }
        }
}