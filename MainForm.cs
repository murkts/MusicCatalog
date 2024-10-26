using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MusicCatalog.Models;

namespace MusicCatalog
{
    public partial class MainForm : Form
    {
        private Catalog catalog;
        private const string FilePath = "catalog.dat";

        public MainForm()
        {
            InitializeComponent();
            catalog = Catalog.LoadFromFile(FilePath); 
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            catalog.SaveToFile(FilePath); 
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var tracksByGenre = catalog.SearchTracksByGenre(query);
            var albumsByArtist = catalog.SearchAlbumsByArtist(query);
            var tracksByTitle = catalog.SearchTracksByTitle(query);
            string result = string.Empty;

            if (tracksByGenre.Count > 0)
            {
                result += "Трек по жанру:\n";
                foreach (var track in tracksByGenre)
                {
                    result += $"{track.Title}, Жанр: {track.Genre}\n";
                }
                result += "\n";
            }

            if (albumsByArtist.Count > 0)
            {
                result += "Альбом по исполнителю:\n";
                foreach (var album in albumsByArtist)
                {
                    result += $"{album.Title}, Исполнитель: {album.Artist.Name}\n";
                }
                result += "\n";
            }

            if (tracksByTitle.Count > 0)
            {
                result += "Трек по названию:\n";
                foreach (var track in tracksByTitle)
                {
                    result += $"{track.Title}, Исполнитель: {track.Artist.Name}, Жанр: {track.Genre}\n";
                }
                result += "\n";
            }

            if (string.IsNullOrEmpty(result))
            {
                result = "Не нашлось результатов во вашему запросу.";
            }
            MessageBox.Show(result);
        }
    }
}
