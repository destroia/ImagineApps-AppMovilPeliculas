using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.HttpService
{
    public interface IGetPost
    {
        Task<T> Get<T>(string url);
        Task<T> Post<T>(string url, object obj);
    }
}
