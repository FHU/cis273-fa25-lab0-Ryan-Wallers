﻿namespace Prayer;

public class Prayer
{
    public string Title { get; set; } = "";
    public string Subtitle { get; set; } = "";
    public string Body { get; set; } = "";
    
    public Author Author { get; set; } = new();
    public List<Tag> PrayerTags { get; set; } = new();
    public List<Scripture> ScriptureReferences { get; set; } = new();

    public Uri? ImageURL { get; set; }

    public DateTime CreatedAt { get; set; } = new();
    public DateTime UpdatedAt { get; set; } = new();

    public override string ToString()
    {
        return $"{Title}: {Subtitle} by {Author}";
    }
}

