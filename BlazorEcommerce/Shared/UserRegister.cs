﻿

using System.ComponentModel.DataAnnotations;

namespace BlazorEcommerce.Shared
{
    public  class UserRegister
    {

        [Required(ErrorMessage ="El email es requerido"), EmailAddress(ErrorMessage ="El email ingresado no es valido")]
        public string Email { get; set; } = string.Empty;
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;
        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
