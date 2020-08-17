using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ALI_News_BE.Models
{
    public abstract class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
        public DateTime Deleted { get; set; } = default(DateTime);


    }
}
