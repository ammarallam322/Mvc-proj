﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModel
{
    public class RegisterViewModel
    {

        public int Id { get; set; }


        public string Name { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password not match Confirm")]
        public string ConfirmPassword { get; set; }

        public string Address { get; set; }





    }
}
