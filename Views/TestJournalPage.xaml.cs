using System;
using Microsoft.Maui.Controls;
using PersonalJournaling.Models;
using PersonalJournaling.Services;

namespace PersonalJournaling.Views;

public partial class TestJournalPage : ContentPage
{
    private readonly DatabaseService _dbService;

    public TestJournalPage()
    {
        InitializeComponent();
        _dbService = new DatabaseService();
    }

    private async void OnSaveEntryClicked(object sender, EventArgs e)
    {
        var existing = await _dbService.GetJournalEntryByDateAsync(DateTime.Now);

        if (existing != null)
        {
            existing.Title = TitleEntry.Text ?? "";
            existing.Content = ContentEditor.Text ?? "";
            existing.UpdatedAt = DateTime.Now;
            await _dbService.UpdateJournalEntryAsync(existing);
            OutputLabel.Text = "Entry updated successfully!";
        }
        else
        {
            var newEntry = new JournalEntry
            {
                Title = TitleEntry.Text ?? "",
                Content = ContentEditor.Text ?? "",
                EntryDate = DateTime.Now,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            await _dbService.AddJournalEntryAsync(newEntry);
            OutputLabel.Text = "Entry created successfully!";
        }
    }

    private async void OnLoadEntryClicked(object sender, EventArgs e)
    {
        var entry = await _dbService.GetJournalEntryByDateAsync(DateTime.Now);
        if (entry != null)
        {
            TitleEntry.Text = entry.Title;
            ContentEditor.Text = entry.Content;
            OutputLabel.Text = "Entry loaded!";
        }
        else
        {
            OutputLabel.Text = "No entry for today.";
        }
    }

    private async void OnDeleteEntryClicked(object sender, EventArgs e)
    {
        var entry = await _dbService.GetJournalEntryByDateAsync(DateTime.Now);
        if (entry != null)
        {
            await _dbService.DeleteJournalEntryAsync(entry);
            TitleEntry.Text = "";
            ContentEditor.Text = "";
            OutputLabel.Text = "Entry deleted!";
        }
        else
        {
            OutputLabel.Text = "No entry to delete for today.";
        }
    }
}
