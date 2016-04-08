
using AppSatrack.Infrastructure.Contracts;
using AppSatrack.Logic.ViewModels;
using GalaSoft.MvvmLight.Ioc;

namespace AppSatrack.Cross.Services
{
    public class DependencyContainerService: IDependencyContainerService
    {
         
        public DependencyContainerService()
        {
            Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IDependencyContainerService, DependencyContainerService>();
            //Cross Services
            SimpleIoc.Default.Register<IDialogService, DialogService>();
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
          

            SimpleIoc.Default.Register<MainViewModel>();
        }
        public T Resolve<T>() where T : class
        {
            return SimpleIoc.Default.GetInstance<T>();
        }
    }
}