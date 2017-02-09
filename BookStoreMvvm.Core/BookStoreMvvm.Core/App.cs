using Acr.UserDialogs;
using BookStoreMvvm.Core.Services;
using BookStoreMvvm.Core.Services.Contracts;
using BookStoreMvvm.Core.ViewModel;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreMvvm.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculatorService, CalculatorService>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<CalculatorViewModel>());
            Mvx.RegisterSingleton<IUserDialogs>(UserDialogs.Instance);
        }
    }
}
