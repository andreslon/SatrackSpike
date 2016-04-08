using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSatrack.Infrastructure.Contracts
{
    public interface IDialogService
    {
        void ShowMessage(string message, string title);
        bool ShowConfirm(string message, string title);

    }
}
