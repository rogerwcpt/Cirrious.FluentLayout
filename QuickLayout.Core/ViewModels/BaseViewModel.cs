using System;
using MvvmCross;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;
using System.Threading.Tasks;

namespace QuickLayout.Core.ViewModels
{
    public class BaseViewModel: MvxViewModel
    {
        public BaseViewModel()
        {
            NavigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();
        }

        public IMvxNavigationService NavigationService { get; }

        protected Task ShowViewModel<T>() where T: MvxViewModel
        {
            return NavigationService.Navigate<T>();
        }
    }
}
