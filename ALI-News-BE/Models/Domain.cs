using System.ComponentModel.DataAnnotations;

namespace ALI_News_BE.Models
{
    public class Domain:BaseModel
    {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        public string BaseUrl { get; set; }
        [Required]
        public string Url { get; set; }
    }
}