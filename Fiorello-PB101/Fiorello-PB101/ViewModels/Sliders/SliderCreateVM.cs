using System.ComponentModel.DataAnnotations;

namespace Fiorello_PB101.ViewModels.Sliders
{
    public class SliderCreateVM
    {
        [Required]
        public List<IFormFile> Images { get; set; }
    }
}
