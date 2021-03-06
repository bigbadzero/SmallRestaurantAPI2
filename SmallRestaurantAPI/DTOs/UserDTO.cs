using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class LoginUserDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to {1} characters", MinimumLength = 1)]
        public string Password { get; set; }
    }

    public class UserDTO : LoginUserDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Question1 { get; set; }
        public int? Question2 { get; set; }
        public int? Question3 { get; set; }
        public string Token { get; set; }
        public int? Timeout { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public ICollection<string> Roles { get; set; }
    }


    public class RegistrationDTO : LoginUserDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime? Birthday { get; set; }
        public ICollection<string> Roles { get; set; }
    }

   public class UserDataDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Question1 { get; set; }
        public int? Question2 { get; set; }
        public int? Question3 { get; set; }
        public string Token { get; set; }
        public int? Timeout { get; set; }
        public string Email { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}
