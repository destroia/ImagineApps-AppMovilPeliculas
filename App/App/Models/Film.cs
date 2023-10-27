using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string Imagen { get; set; }
        public int Ano { get; set; }
    }
}
