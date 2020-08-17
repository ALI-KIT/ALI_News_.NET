using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ALI_News_BE.Models
{
    public class User : BaseModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public UserRole Role { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
