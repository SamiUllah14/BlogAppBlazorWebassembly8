﻿namespace BlogApp.Server.Models.Authentication
{
    public class UserRegister
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
