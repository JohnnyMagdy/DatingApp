using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] public string UserName { get; set; }
        [Required] public string NickName {get; set; }
        [Required] public string Gender {get; set; }
        [Required] public DateTime DateOfBirth {get; set; }
        [Required] public string City {get; set; }
        [Required] public string Country {get; set; }
        
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}