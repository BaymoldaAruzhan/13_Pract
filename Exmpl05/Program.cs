using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmpl05
{
    class MusicCatalog
    {
        private Hashtable catalog = new Hashtable();

        public void AddDisk(string diskName)
        {
            if (!catalog.ContainsKey(diskName))
            {
                catalog[diskName] = new List<string>();
            }
        }

        public void RemoveDisk(string diskName)
        {
            if (catalog.ContainsKey(diskName))
            {
                catalog.Remove(diskName);
            }
        }

        public void AddSong(string diskName, string artist, string songTitle)
        {
            if (catalog.ContainsKey(diskName))
            {
                var songs = (List<string>)catalog[diskName];
                songs.Add($"{artist} - {songTitle}");
            }
        }

        public void RemoveSong(string diskName, string artist, string songTitle)
        {
            if (catalog.ContainsKey(diskName))
            {
                var songs = (List<string>)catalog[diskName];
                songs.Remove($"{artist} - {songTitle}");
            }
        }

        public void ShowCatalog()
        {
            Console.WriteLine("Каталог музыкальных компакт-дисков:");

            foreach (DictionaryEntry entry in catalog)
            {
                Console.WriteLine($"Диск: {entry.Key}");

                var songs = (List<string>)entry.Value;
                foreach (var song in songs)
                {
                    Console.WriteLine($"  - {song}");
                }
            }
        }

        public void ShowSongsByArtist(string artist)
        {
            Console.WriteLine($"Поиск записей исполнителя {artist}:");

            foreach (DictionaryEntry entry in catalog)
            {
                var songs = (List<string>)entry.Value;
                var artistSongs = songs.Where(s => s.StartsWith($"{artist} - "));

                foreach (var song in artistSongs)
                {
                    Console.WriteLine($"  - {song}");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MusicCatalog catalog = new MusicCatalog();

            catalog.AddDisk("Disk 1");
            catalog.AddSong("Disk 1", "Artist 1", "Song 1");
            catalog.AddSong("Disk 1", "Artist 2", "Song 2");

            catalog.AddDisk("Disk 2");
            catalog.AddSong("Disk 2", "Artist 1", "Song 3");

            catalog.ShowCatalog();

            catalog.RemoveDisk("Disk 1");

            catalog.ShowCatalog();

            catalog.ShowSongsByArtist("Artist 1");
        }
    }
}
