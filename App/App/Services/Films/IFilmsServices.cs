using App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Films
{
    public interface IFilmsServices
    {
        Task<IEnumerable<Film>> GetAll();
    }
}
