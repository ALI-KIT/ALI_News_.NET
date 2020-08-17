using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ALI_News_BE.Models
{
    public class News: BaseModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime BublicationDate { get; set; } = DateTime.Now;
        public Domain Aggregator { get; set; }
        public Domain Source { get; set; }
        public string[] Keywords { get; set; }
        public virtual Local[] Locals { get; set; }
        public string[] Categories { get; set; }
    }
}
