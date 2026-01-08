using SQLite;
using System;

namespace PersonalJournaling.Models
{
    public class JournalEntry
    {
        [PrimaryKey, AutoIncrement]
        public int EntryId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? CategoryId { get; set; }

        public JournalEntry()
        {
            UserId = 0;
            Title = string.Empty;
            Content = string.Empty;
            EntryDate = DateTime.Now;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            CategoryId = null;
        }
    }
}
