using SQLite;

namespace PersonalJournaling.Models
{
    public class EntryMood
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int EntryId { get; set; }
        public int MoodId { get; set; }
        public bool IsPrimary { get; set; }

        public EntryMood()
        {
            EntryId = 0;
            MoodId = 0;
            IsPrimary = false;
        }
    }
}
