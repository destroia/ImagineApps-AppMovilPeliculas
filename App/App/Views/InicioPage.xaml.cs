using App.Services.Films;
using App.ViewModels;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioPage : ContentPage
    {
        readonly IFilmsServices FilmsServices;
        public InicioPage()
        {
            InitializeComponent();
            this.Appearing += OnPageAppearing;
            FilmsServices = App.Container.Resolve<IFilmsServices>();
            BindingContext = new InicioViewModel();
        }
        private void OnPageAppearing(object sender, EventArgs e)
        {
            if (BindingContext is InicioViewModel viewModel)
            {
                viewModel.OnPageAppearing(); // Llama a un método en el ViewModel para realizar acciones específicas.
            }
        }
    }
}