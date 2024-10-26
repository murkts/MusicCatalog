using System.Collections.Generic;

namespace MusicCatalog.Models
{
    public class Compilation
    {
        public string Title { get; set; }
        public List<Track> Tracks { get; set; }

        public Compilation(string title)
        {
            Title = title;
            Tracks = new List<Track>();
        }

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }
    }
}
