﻿using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models.DTOs.User
{
    public class RegisterUserRequest
    {
        [Required] public string UserName { get; set; } = string.Empty;
        [Required] public string Email { get; set; } = string.Empty;
        [Required] public string Password { get; set; } = string.Empty;
    }
}