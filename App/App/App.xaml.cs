using App.Services;
using App.Services.Films;
using App.Services.HttpService;
using App.Views;
using Autofac;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
    public partial class App : Application
    {
        public static IContainer Container { get; set; }

        public App()
        {
            InitializeComponent();

            InitializeDependencyContainer();
            //MainPage = new AppShell();
            MainPage = new SplahsPage();

        }
        private void InitializeDependencyContainer()
        {
            var builder = new ContainerBuilder();

            // Registra las dependencias aquí
            builder.RegisterType<FilmsServices>().As<IFilmsServices>();
            builder.RegisterType<GetPost>().As<IGetPost>();
            
            Container = builder.Build();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
