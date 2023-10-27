using App.Models;
using App.ViewModels;
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
    public partial class DetallesPage : ContentPage
    {
        public DetallesPage(Film film)
        {
            InitializeComponent();
            BindingContext = new DetallesViewModels(film);
        }
    }
}