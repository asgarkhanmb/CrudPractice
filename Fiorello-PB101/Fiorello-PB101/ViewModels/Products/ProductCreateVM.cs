using System.ComponentModel.DataAnnotations;

namespace Fiorello_PB101.ViewModels.Products
{
    public class ProductCreateVM
    {
        [Required] 
        public  string Name { get; set; }
        [Required]
        public  string  Description { get; set; }
        [Required]
        public  string Price { get; set; }
        public  int CategoryId { get; set; }
        [Required]
        public List<IFormFile> Images { get; set; }

    }
}
