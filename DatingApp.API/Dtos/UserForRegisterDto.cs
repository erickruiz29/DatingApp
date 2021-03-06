using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "You must specify password of 8 to 16 characters")]
        public string Password { get; set; }
    }
}