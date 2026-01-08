using SQLite;

namespace PersonalJournaling.Models
{
    public class Mood
    {
        [PrimaryKey, AutoIncrement]
        public int MoodId { get; set; }
        public string Name { get; set; }
        public string MoodType { get; set; } // Positive, Neutral, Negative

        public Mood()
        {
            Name = string.Empty;
            MoodType = string.Empty;
        }
    }
}
