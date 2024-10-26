using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System;

namespace MusicCatalog.Models
{
    public class Catalog
    {
        public List<Artist> Artists { get; set; }
        public List<Album> Albums { get; set; }
        public List<Compilation> Compilations { get; set; }
        public List<Playlist> Playlists { get; set; }

        public Catalog()
        {
            Artists = new List<Artist>();
            Albums = new List<Album>();
            Compilations = new List<Compilation>();
            Playlists = new List<Playlist>();
        }

        public void AddArtist(Artist artist)
        {
            Artists.Add(artist);
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        public void AddPlaylist(Playlist playlist)
        {
            Playlists.Add(playlist);
        }

        public Artist FindArtistByName(string name)
        {
            return Artists.FirstOrDefault(a => a.Name == name);
        }

        public Album FindAlbumByTitle(string title)
        {
            return Albums.FirstOrDefault(a => a.Title == title);
        }

        public List<Track> SearchTracksByGenre(string genre)
        {
            return Albums.SelectMany(album => album.Tracks)
                         .Where(track => track.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                         .ToList();
        }

        public List<Album> SearchAlbumsByArtist(string artistName)
        {
            return Albums.Where(album => album.Artist.Name.Equals(artistName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Track> SearchTracksByTitle(string title)
        {
            return Albums.SelectMany(album => album.Tracks)
                         .Where(track => track.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                         .ToList();
        }
        public void SaveToFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, this);
            }
        }
        public static Catalog LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return new Catalog();

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Catalog)formatter.Deserialize(fs);
            }
        }
    }
}
