using Estoque.Domain.Dtos.Address;
using Estoque.Domain.Interfaces.Gateway;
using Estoque.Domain.Interfaces.Service;
using Estoque.Domain.Models.Gateways.BrasilApi;

namespace Estoque.Service.Service
{
    public class AddressService : IAddressService
    {
        private readonly IBrasilApiGateway _gateway;

        public AddressService(IBrasilApiGateway gateway)
        {
            _gateway = gateway;
        }

        public async Task<AddressResponseDto> GetAddress(string cep)
        {
            var addressGateway = await _gateway.GetAddressByCep(cep);

            return new AddressResponseDto(
                addressGateway.Cep,
                addressGateway.State,
                addressGateway.City,
                addressGateway.Neighborhood,
                addressGateway.Street
            );
        }
    }
}