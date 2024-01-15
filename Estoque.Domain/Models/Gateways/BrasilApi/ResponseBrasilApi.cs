using Estoque.Domain.Models;

namespace Estoque.Domain.Models.Gateways.BrasilApi
{
    public class ResponseBrasilApi : BaseEntity
    {
        public string Cep { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string Service { get; set; }
    }
}