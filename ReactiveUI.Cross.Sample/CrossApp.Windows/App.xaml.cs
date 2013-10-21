using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reactive.Concurrency;
using System.Threading.Tasks;
using System.Windows;
using CrossApp.Contracts.Data.Repositories;
using CrossApp.Services.Repositories;
using CrossApp.UI.ViewModels;
using CrossApp.UI.WPF;
using ReactiveUI;
using ReactiveUI.Mobile;

namespace CrossApp.Windows
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            RxApp.MutableResolver.InitializeResolver();


            RxApp.MutableResolver.Register(() => new IdeaRepository(), typeof(IIdeaRepository));

        }

        protected override void OnStartup(StartupEventArgs e)
        {

            base.OnStartup(e);
        }
    }
}
