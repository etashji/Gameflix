using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gameflix.Areas.Users.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        [RegularExpression(@"^\S*$", ErrorMessage = "Username may not contain spaces.")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Username must be between 6 and 30 characters.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression(@"^\S*$", ErrorMessage = "Password may not contain spaces.")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 16 characters.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "You must confirm your password.")]
        [Compare("Password", ErrorMessage = "Passwords must match")]
        [Display(Name = "Confirm Password")]
        public string confirmPassword { get; set; }
        public string salt { get; set; }
        public string hashedPassword { get; set; }
    }
}