using App.Models;
using App.Services.HttpService;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Films
{
    public class FilmsServices : IFilmsServices
    {
        readonly IGetPost GetPost;
        public FilmsServices()
        {
            GetPost = App.Container.Resolve<IGetPost>();
        }
        public async Task<IEnumerable<Film>> GetAll()
        {
            return await GetPost.Get<List<Film>>(CadenasConeccion.UrlApi + "api/Films/GetAll");
        }
    }
}
