using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossApp.Contracts.Data.Repositories;
using CrossApp.UI.ViewModels;
using ReactiveUI;
using ReactiveUI.Mobile;

namespace CrossApp.Windows
{
    public class AppBootrap : IApplicationRootState
    {
        public IRoutingState Router { get; private set; }

        public AppBootrap()
        {
            Router = new RoutingState();

            RxApp.MutableResolver.RegisterConstant(this, typeof(IScreen));
        }
    }
}
