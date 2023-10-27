using System.Threading.Tasks;
using Xamarin.Essentials;

namespace App.Services.HttpService
{
    public class VerificacionInternetSevice
    {
        public static async Task<bool> IsConnection()
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
                return true;
            else
                await App.Current.MainPage.DisplayAlert("Error", "Verifique conexión a internet.", "Aceptar");
                return false;

        }
    }
}
