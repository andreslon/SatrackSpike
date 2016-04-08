using AppSatrack.Infraestructure.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSatrack.Infraestructure.Contracts
{
    public interface INavigationsService
    {
        void NavigateTo(PageTypes pages);
       

    }
}
