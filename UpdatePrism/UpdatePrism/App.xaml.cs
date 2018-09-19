using Microsoft.Practices.Unity;
using Prism.Unity;
using UpdatePrism.ApplicationServices;
using UpdatePrism.ApplicationServices.Interfaces;
using Xamarin.Forms;

namespace UpdatePrism
{
    public partial class App : PrismApplication
    {
        public static IUnityContainer _unityContainer { get; set; }

        public App(IPlatformInitializer initializer) : base(initializer) { }
        
        protected override void OnInitialized()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void RegisterTypes()
        {
            //Register Types
            Container.RegisterType(typeof(ICurrentDateService), typeof(CurrentDateService));

            //Register Pages
            Container.RegisterTypeForNavigation<MainPage, MainPageViewModel>();

            //Set Container to Unity Container for use out of App class
            _unityContainer = Container;
        }
    }
}
