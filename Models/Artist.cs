using System.Collections.Generic;

namespace MusicCatalog.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
        public List<Track> Tracks { get; set; }

        public Artist(string name)
        {
            Name = name;
            Albums = new List<Album>();
            Tracks = new List<Track>();
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }
    }
}
