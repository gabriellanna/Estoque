namespace Estoque.Domain.Dtos.Address
{
    public class AddressResponseDto
    {
        public AddressResponseDto(string cep, string state, string city, string neighborhood, string street)
        {
            Cep = cep;
            State = state;
            City = city;
            Neighborhood = neighborhood;
            Street = street;
        }

        public string Cep { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
    }
}