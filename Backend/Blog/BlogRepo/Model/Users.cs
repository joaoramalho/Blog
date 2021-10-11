using System;
namespace BlogRepo.Model
{
    public class Users
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime LastLogin { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserChange { get; set; }
        public DateTime DateChange { get; set; }
    }
}
