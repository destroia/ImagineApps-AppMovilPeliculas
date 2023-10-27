
using App.Models;
using App.Services.Films;
using App.Views;
using Autofac;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class InicioViewModel : BaseViewModel
    {
        private IFilmsServices FilmsServices;
        ObservableCollection<Film> films;
        //INavigation Navigation;
        public ICommand TapCommand { get; set;  }
        public ObservableCollection<Film> Films { get => films; set { films = value; OnPropertyChanged(); } }
        public InicioViewModel()
        {
            TapCommand = new Command(Tab);
            FilmsServices = App.Container.Resolve<IFilmsServices>();
            
        }

        internal async void OnPageAppearing()
        {
            var result = await FilmsServices.GetAll();
            Films = new ObservableCollection<Film>(result);
        }

        async Task<List<Film>> GetFilms()
        {
            var newFil = new List<Film>() { new Film() { Id = 1,Titulo = "El Aro",Sinopsis = "The Ring (titulada: La señal en España, El aro en Hispanoamérica y La llamada en Argentina) es una película estadounidense de terror psicológico sobrenatural, estrenada en 2002, dirigida por Gore Verbinski a partir de un guion de Ehren Kruger y protagonizada por Naomi Watts, Martin Henderson, Brian Cox, David Dorfman y Daveigh Chase. Se trata de un remake occidentalizado de la película de terror japonesa de 1998, Ringu de Hideo Nakata, que a su vez se basó en la novela del mismo nombre de Kōji Suzuki (que también ayudó a coescribir las dos versiones de la película). La trama de la película se centra en Rachel Keller, una periodista que debe encontrar una manera de escapar de la muerte después de ver una cinta maldita que aparentemente mata al espectador siete días después de verla." +
                                                            "The Ring se estrenó en cines el 18 de octubre de 2002 y recibió críticas en su mayoría positivas; los críticos elogiaron la atmósfera y las imágenes, la cinematografía de Bojan Bazelli, la dirección de Verbinski y la actuación de Watts. La película se convirtió en un éxito de taquilla.Recaudó más de $249 millones en todo el mundo con un presupuesto de producción de $48 millones, lo que la convierte en uno de los remakes de terror más taquilleros.",
                Imagen = "https://static.wikia.nocookie.net/doblaje/images/d/de/El_aro_capitulo_final.jpg/revision/latest/scale-to-width-down/1200?cb=20191102054641&path-prefix=es",Ano = 2002} };

            return null;
        }


        private  async void Tab(object obj)
        {        
            Film film = obj as Film;
            await App.Current.MainPage.Navigation.PushAsync(new DetallesPage(film));
        }
    }
}
