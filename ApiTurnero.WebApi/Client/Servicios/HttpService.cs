using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiTurnero.WebApi.Client.Servicios
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient httpClient;

        public HttpService(HttpClient http)
        {
            this.httpClient = http;
        }

        public async Task<HttpRespuesta<T>> Get<T>(string url)
        {
            var respuestaHttp = await httpClient.GetAsync(url);
            if (respuestaHttp.IsSuccessStatusCode)
            {
                var respuesta = await DeserealizarRespuesta<T>(respuestaHttp);
                return new HttpRespuesta<T>(respuesta, false, respuestaHttp);
            }
            else
            {
                return new HttpRespuesta<T>(default, true, respuestaHttp);
            }
        }

        public async Task <HttpRespuesta<object>> Post<T>(string url, T enviar) 
        {
            try
            {
                var enviarJSON = JsonSerializer.Serialize(enviar);
                var enviarContet = new StringContent(enviarJSON, Encoding.UTF8, "application/json");

                var respuestaHTTP = await httpClient.PostAsync(url, enviarContet);
                return new HttpRespuesta<object>(null, !respuestaHTTP.IsSuccessStatusCode, respuestaHTTP);
            }
            catch (System.Exception e)
            {

                throw;
            }
            
        }

        public async Task <HttpRespuesta<object>> Put <T>(string url, T enviar)
        {
            try
            {
                var enviarJSON = JsonSerializer.Serialize(enviar);
                var enviarContet = new StringContent(enviarJSON, Encoding.UTF8, "application/json");

                var respuestaHTTP = await httpClient.PutAsync(url, enviarContet);
                return new HttpRespuesta<object>(null, !respuestaHTTP.IsSuccessStatusCode, respuestaHTTP);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        public async Task <HttpRespuesta<object>> Delet(string url)
        {
            var respuestaHTTP = await httpClient.DeleteAsync(url);
            return new HttpRespuesta<object>(null, !respuestaHTTP.IsSuccessStatusCode, respuestaHTTP);
        }

        private async Task<T> DeserealizarRespuesta<T>(HttpResponseMessage httpRespuesta)
        {
            var RespuestaString = await httpRespuesta.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(RespuestaString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }

}
