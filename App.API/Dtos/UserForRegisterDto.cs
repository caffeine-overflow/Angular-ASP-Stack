using System.ComponentModel.DataAnnotations;

namespace App.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string username { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "You must specify a passoerd between 5-15 characters")]
        public string password { get; set; }

    }
}