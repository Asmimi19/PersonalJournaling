using SQLite;

namespace PersonalJournaling.Models
{
    public class EntryTag
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int EntryId { get; set; }
        public int TagId { get; set; }

        public EntryTag()
        {
            EntryId = 0;
            TagId = 0;
        }
    }
}
