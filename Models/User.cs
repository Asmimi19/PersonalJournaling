using SQLite;
using System;

namespace PersonalJournaling.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
        public string PinHash { get; set; }
        public DateTime CreatedAt { get; set; }

        public User()
        {
            PasswordHash = string.Empty;
            PinHash = string.Empty;
            CreatedAt = DateTime.Now;
        }
    }
}
