﻿using System.ComponentModel.DataAnnotations;

namespace BlogApp.Client.Models.Authentication
{
    public class UserLogin
    {

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
