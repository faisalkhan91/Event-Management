using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.Models
{
    public class User
    {
        int _userId;
        string _fullName;
        string _email;
        string _password;
        string _confirmPassword;

        [Key]
        public int UserId { get => _userId; set => _userId = value; }
        [Required]
        public string FullName { get => _fullName; set => _fullName = value; }
        [Required]
        public string Email { get => _email; set => _email = value; }
        [Required]
        public string Password { get => _password; set => _password = value; }
        [Required]
        public string ConfirmPassword { get => _confirmPassword; set => _confirmPassword = value; }
    }
}
