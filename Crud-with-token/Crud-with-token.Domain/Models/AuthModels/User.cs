﻿namespace Crud_with_token.Domain.Models.AuthModels
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
