using System.ComponentModel.DataAnnotations;

namespace Fiorello_PB101.ViewModels.Blog
{
    public class BlogCreateVM
    {
        public string Description { get; set; }
        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(20)]
        public string Title { get; set; }
        [Required]
        public IFormFile Image { get; set; }
    }
}
