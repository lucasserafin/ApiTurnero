using System.Threading.Tasks;

namespace ApiTurnero.WebApi.Client.Servicios
{
    public interface IHttpService
    {
        Task<HttpRespuesta<object>> Delet(string url);
        Task<HttpRespuesta<T>> Get<T>(string url);
        Task<HttpRespuesta<object>> Post<T>(string url, T enviar);
        Task<HttpRespuesta<object>> Put<T>(string url, T enviar);
    }
}