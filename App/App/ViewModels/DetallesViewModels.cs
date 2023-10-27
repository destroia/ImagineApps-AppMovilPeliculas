using App.Models;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.ViewModels
{
    public class DetallesViewModels : BaseViewModel
    {
        Film film;
        public Film Film { get => film; set { film = value; OnPropertyChanged(); } }

        public DetallesViewModels(Film film)
        {
            this.film = film;
        }
    }
}
