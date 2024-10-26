using System;

namespace MusicCatalog.Models
{
    public class Track
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public string Genre { get; set; }

        public Track(string title, TimeSpan duration, string genre)
        {
            Title = title;
            Duration = duration;
            Genre = genre;
        }
    }
}
