namespace Estoque.Domain.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Valor { get; set; }
    }
}