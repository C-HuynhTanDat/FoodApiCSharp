﻿namespace FoodBlazorC.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsAdmin { get; set; }
    }
}
