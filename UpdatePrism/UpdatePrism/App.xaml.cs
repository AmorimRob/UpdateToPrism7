using Prism;
using Prism.Ioc;
using Prism.Unity;
using Unity;
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

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //Register Types
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

            //Register Pages
            containerRegistry.GetContainer().RegisterType(typeof(ICurrentDateService), typeof(CurrentDateService));

            //Set Container to Unity Container for use out of App class
            _unityContainer = containerRegistry.GetContainer() as UnityContainer;
        }
    }
}
