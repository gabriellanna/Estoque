using Estoque.Domain.Interfaces.Gateway;
using Estoque.Domain.Models.Gateways.BrasilApi;
using Newtonsoft.Json;

namespace Estoque.Infra.Gateway
{
    public class BrasilApiGateway : IBrasilApiGateway
    {
        public async Task<ResponseBrasilApi> GetAddressByCep(string cep)
        {
            using(var client = new HttpClient())
            {
                var responseApi = await client.GetAsync($"https://brasilapi.com.br/api/cep/v1/{cep}");
                if(responseApi.IsSuccessStatusCode)
                {
                    var contentResponse = await responseApi.Content.ReadAsStringAsync();
                    var objResponse = JsonConvert.DeserializeObject<ResponseBrasilApi>(contentResponse);

                    return objResponse;
                }

                return new();
            }
        }
    }
}