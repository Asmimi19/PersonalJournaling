using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using PersonalJournaling.Models;

namespace PersonalJournaling.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _db;

        public DatabaseService()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "journal.db3");
            _db = new SQLiteAsyncConnection(dbPath);

            _db.CreateTableAsync<User>().Wait();
            _db.CreateTableAsync<JournalEntry>().Wait();
            _db.CreateTableAsync<Mood>().Wait();
            _db.CreateTableAsync<EntryMood>().Wait();
            _db.CreateTableAsync<Category>().Wait();
            _db.CreateTableAsync<Tag>().Wait();
            _db.CreateTableAsync<EntryTag>().Wait();
        }

        // Journal Entry Methods
        public Task<int> AddJournalEntryAsync(JournalEntry entry) => _db.InsertAsync(entry);
        public Task<int> UpdateJournalEntryAsync(JournalEntry entry) => _db.UpdateAsync(entry);
        public Task<int> DeleteJournalEntryAsync(JournalEntry entry) => _db.DeleteAsync(entry);
        public Task<List<JournalEntry>> GetAllJournalEntriesAsync() => _db.Table<JournalEntry>().ToListAsync();
        public Task<JournalEntry> GetJournalEntryByDateAsync(DateTime date) =>
            _db.Table<JournalEntry>().Where(e => e.EntryDate.Date == date.Date).FirstOrDefaultAsync();
    }
}
