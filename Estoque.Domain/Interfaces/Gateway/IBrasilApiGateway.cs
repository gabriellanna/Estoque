using Estoque.Domain.Models.Gateways.BrasilApi;

namespace Estoque.Domain.Interfaces.Gateway
{
    public interface IBrasilApiGateway
    {
        public Task<ResponseBrasilApi> GetAddressByCep(string cep);
    }
}