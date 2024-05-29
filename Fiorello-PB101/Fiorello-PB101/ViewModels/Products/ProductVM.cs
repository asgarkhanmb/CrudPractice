using Fiorello_PB101.Models;

namespace Fiorello_PB101.ViewModels.Products
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public string CategoryName { get; set; }
        public string MainImage { get; set; }



    }
}
