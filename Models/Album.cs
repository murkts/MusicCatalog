using System.Collections.Generic;

namespace MusicCatalog.Models
{
    public class Album
    {
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public List<Track> Tracks { get; set; }

        public Album(string title, Artist artist)
        {
            Title = title;
            Artist = artist;
            Tracks = new List<Track>();
        }

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }
    }
}
