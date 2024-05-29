using System.ComponentModel.DataAnnotations;

namespace Fiorello_PB101.ViewModels.Blog
{
    public class BlogEditVM
    {
        public string Description { get; set; }
        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(20)]
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }
        public IFormFile NewImage { get; set; }
    }
}
