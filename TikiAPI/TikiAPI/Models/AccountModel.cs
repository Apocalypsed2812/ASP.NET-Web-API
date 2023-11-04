﻿using System.ComponentModel.DataAnnotations;
using TikiAPI.Data;

namespace TikiAPI.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //public string Role { get; set; }
        //public UserCart UserCart { get; set; }
    }
}
