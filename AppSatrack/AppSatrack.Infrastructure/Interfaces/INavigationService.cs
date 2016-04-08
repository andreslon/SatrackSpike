using AppSatrack.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSatrack.Infrastructure.Interfaces
{
    public interface INavigationService
    {
        void Navegar(PageTypes Page);
    }
}
