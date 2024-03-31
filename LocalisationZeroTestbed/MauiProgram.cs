using FunctionZero.Maui.MvvmZero;
using LocalisationZero.Localisation;
using LocalisationZeroTestbed.Localisation;
using LocalisationZeroTestbed.Mvvm.Pages;
using LocalisationZeroTestbed.Mvvm.PageViewModels;
using LocalisationZeroTestbed.SampleData;
using Microsoft.Extensions.Logging;

namespace LocalisationZeroTestbed
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMvvmZero(config=>
                    {
                        config.MapVmToView<HomePageVm, HomePage>();
                    }
                )
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services
                .AddSingleton<HomePage>()
                .AddSingleton<HomePageVm>()
                .AddSingleton<LocalisationService>(GetConfiguredLanguageService)
                ;
            return builder.Build();
        }

        private static LocalisationService GetConfiguredLanguageService(IServiceProvider provider)
        {
            var localisationService = new LocalisationService();
            localisationService.RegisterLanguage("english", new LocalisationProvider(GetEnglish, "English"));

            return localisationService;
        }

        private static LocalisationPack GetEnglish()
        {
            return LanguageEN.GetLocalisationPack();
        }
    }
}
