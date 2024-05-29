namespace Fiorello_PB101.Models
{
    public class ProductImage
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    } 
}
