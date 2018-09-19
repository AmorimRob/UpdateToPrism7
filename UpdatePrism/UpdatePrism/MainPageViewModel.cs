using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using UpdatePrism.ApplicationServices.Interfaces;
using Xamarin.Forms;

namespace UpdatePrism
{
    public class MainPageViewModel : BindableBase, INavigatedAware
    {
        private readonly ICurrentDateService _currentDateService;
        public string CurrentDate { get; set; }
        public ICommand GetCurrentDateCommand { get; set; }

        public MainPageViewModel(ICurrentDateService currentDateService)
        {
            _currentDateService = currentDateService;

            GetCurrentDateCommand = new Command(() =>
            {
                CurrentDate = _currentDateService.GetCurrentDate();
                RaisePropertyChanged(nameof(CurrentDate));
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
