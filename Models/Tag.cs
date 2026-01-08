using SQLite;

namespace PersonalJournaling.Models
{
    public class Tag
    {
        [PrimaryKey, AutoIncrement]
        public int TagId { get; set; }
        public string Name { get; set; }

        public Tag()
        {
            Name = string.Empty;
        }
    }
}
