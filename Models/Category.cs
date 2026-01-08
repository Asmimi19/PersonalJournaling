using SQLite;

namespace PersonalJournaling.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public Category()
        {
            Name = string.Empty;
        }
    }
}
