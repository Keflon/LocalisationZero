﻿using FunctionZero.Maui.MvvmZero;
using LocalisationZero.Localisation;
using LocalisationZeroTestbed.Localisation;
using LocalisationZeroTestbed.Mvvm.Pages;
using LocalisationZeroTestbed.Mvvm.PageViewModels;

namespace LocalisationZeroTestbed
{
    public partial class App : Application
    {
        public App(NavigationPage navPage, IPageServiceZero pageService, LocalisationService langService)
        {
            InitializeComponent();

            pageService.Init(this);
            langService.Init(this.Resources, "english");

            MainPage = pageService.GetMvvmPage<HomePage, HomePageVm>().page;

            //MainPage = navPage;
            //pageService.PushVmAsync<HomePageVm>(vm => vm.Init("Hello"));
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
