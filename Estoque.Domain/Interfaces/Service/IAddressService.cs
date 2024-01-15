using Estoque.Domain.Dtos.Address;

namespace Estoque.Domain.Interfaces.Service
{
    public interface IAddressService
    {
        public Task<AddressResponseDto> GetAddress(string cep);
    }
}