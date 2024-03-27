using FunctionZero.Maui.MvvmZero;
using LocalisationZero.Localisation;
using LocalisationZeroTestbed.Mvvm.PageViewModels;
using SampleApp.Translations;

namespace LocalisationZeroTestbed
{
    public partial class App : Application
    {
        public App(NavigationPage navPage, IPageServiceZero pageService, LangService langService)
        {
            InitializeComponent();

            pageService.Init(this);
            langService.Init(this.Resources, "english");

            MainPage = navPage;
            pageService.PushVmAsync<HomePageVm>(vm => vm.Init("Hello"));
        }
#if WINDOWS
        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 800;
            window.Height = 600;

            return window;
        }
#endif
    }
}
