﻿using System.ComponentModel.DataAnnotations;

namespace TutorEase.Core.DTO.Request
{
    public class AuthenticationRequest
    {
        [DataType(DataType.Text)]
        [Required]
        public string Username { get; set; }
        [DataType(DataType.Text)]
        [Required]
        public string Password { get; set; }
    }
}
