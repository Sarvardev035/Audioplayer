using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class AudioPlayer
{
    private List<AudioFile> playlist = new List<AudioFile>();
    private int currentIndex = 0;

    static void Main()
    {
        var player = new AudioPlayer();
        player.Run();
    }

    private void Run()
    {
        Console.WriteLine("╔═══════════════════════════════╗");
        Console.WriteLine("║      Audio Player v1.0        ║");
        Console.WriteLine("╚═══════════════════════════════╝\n");

        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine()?.ToLower() ?? "";

            switch (choice)
            {
                case "1":
                    LoadPlaylist();
                    break;
                case "2":
                    PlayAudio();
                    break;
                case "3":
                    ListPlaylist();
                    break;
                case "4":
                    NextTrack();
                    break;
                case "5":
                    PreviousTrack();
                    break;
                case "6":
                    GetStats();
                    break;
                case "7":
                    Console.WriteLine("Exiting... Goodbye!");
                    return;
                default:
                    Console.WriteLine("❌ Invalid option. Try again.\n");
                    break;
            }
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("┌─────────────────────────────┐");
        Console.WriteLine("│ [1] Load Audio Files        │");
        Console.WriteLine("│ [2] Play Current Track      │");
        Console.WriteLine("│ [3] View Playlist           │");
        Console.WriteLine("│ [4] Next Track              │");
        Console.WriteLine("│ [5] Previous Track          │");
        Console.WriteLine("│ [6] Playlist Stats          │");
        Console.WriteLine("│ [7] Exit                    │");
        Console.WriteLine("└─────────────────────────────┘");
        Console.Write("Choose an option: ");
    }

    private void LoadPlaylist()
    {
        Console.Write("Enter directory path with audio files: ");
        string path = Console.ReadLine() ?? "";

        if (!Directory.Exists(path))
        {
            Console.WriteLine("❌ Directory not found!\n");
            return;
        }

        try
        {
            var audioExtensions = new[] { "*.mp3", "*.wav", "*.flac", "*.ogg", "*.aac" };
            var files = new List<string>();

            foreach (var ext in audioExtensions)
            {
                files.AddRange(Directory.GetFiles(path, ext, SearchOption.TopDirectoryOnly));
            }

            if (files.Count == 0)
            {
                Console.WriteLine("⚠️  No audio files found.\n");
                return;
            }

            playlist.Clear();
            foreach (var file in files.OrderBy(f => f))
            {
                playlist.Add(new AudioFile(file));
            }

            currentIndex = 0;
            Console.WriteLine($"✅ Loaded {playlist.Count} audio files!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error: {ex.Message}\n");
        }
    }

    private void PlayAudio()
    {
        if (playlist.Count == 0)
        {
            Console.WriteLine("⚠️  Playlist is empty. Load files first!\n");
            return;
        }

        AudioFile current = playlist[currentIndex];
        Console.WriteLine($"\n▶️  Now Playing: {current.Name}");
        Console.WriteLine($"   Duration: {current.Duration}");
        Console.WriteLine($"   File: {current.Path}");
        Console.WriteLine($"   Size: {FormatFileSize(current.Size)}");
        Console.WriteLine("   (Simulated playback - press Enter to continue)\n");
        Console.ReadLine();
    }

    private void ListPlaylist()
    {
        if (playlist.Count == 0)
        {
            Console.WriteLine("Playlist is empty.\n");
            return;
        }

        Console.WriteLine("\n📋 PLAYLIST:");
        Console.WriteLine(new string('─', 50));
        for (int i = 0; i < playlist.Count; i++)
        {
            string marker = i == currentIndex ? "▶️ " : "  ";
            string name = playlist[i].Name.Length > 35 ? playlist[i].Name.Substring(0, 32) + "..." : playlist[i].Name;
            Console.WriteLine($"{marker}[{i + 1,2}] {name,-35} {FormatFileSize(playlist[i].Size),8}");
        }
        Console.WriteLine(new string('─', 50) + "\n");
    }

    private void NextTrack()
    {
        if (playlist.Count == 0)
        {
            Console.WriteLine("⚠️  Playlist is empty.\n");
            return;
        }

        currentIndex = (currentIndex + 1) % playlist.Count;
        Console.WriteLine($"⏭️  Next: {playlist[currentIndex].Name}\n");
    }

    private void PreviousTrack()
    {
        if (playlist.Count == 0)
        {
            Console.WriteLine("⚠️  Playlist is empty.\n");
            return;
        }

        currentIndex = (currentIndex - 1 + playlist.Count) % playlist.Count;
        Console.WriteLine($"⏮️  Previous: {playlist[currentIndex].Name}\n");
    }

    private void GetStats()
    {
        if (playlist.Count == 0)
        {
            Console.WriteLine("⚠️  Playlist is empty.\n");
            return;
        }

        long totalSize = playlist.Sum(f => f.Size);
        Console.WriteLine("\n📊 PLAYLIST STATISTICS:");
        Console.WriteLine(new string('─', 50));
        Console.WriteLine($"Total Tracks: {playlist.Count}");
        Console.WriteLine($"Total Size: {FormatFileSize(totalSize)}");
        Console.WriteLine($"Formats: {string.Join(", ", playlist.Select(f => f.Extension).Distinct())}");
        Console.WriteLine($"Current Track: {currentIndex + 1} / {playlist.Count}");
        Console.WriteLine(new string('─', 50) + "\n");
    }

    private string FormatFileSize(long bytes)
    {
        string[] sizes = { "B", "KB", "MB", "GB" };
        double len = bytes;
        int order = 0;
        while (len >= 1024 && order < sizes.Length - 1)
        {
            order++;
            len = len / 1024;
        }
        return $"{len:0.##} {sizes[order]}";
    }
}

class AudioFile
{
    public string Path { get; set; }
    public string Name { get; set; }
    public string Extension { get; set; }
    public long Size { get; set; }
    public string Duration { get; set; }

    public AudioFile(string path)
    {
        Path = path;
        Name = System.IO.Path.GetFileName(path);
        Extension = System.IO.Path.GetExtension(path).TrimStart('.');
        
        try
        {
            var fileInfo = new FileInfo(path);
            Size = fileInfo.Length;
        }
        catch
        {
            Size = 0;
        }

        Duration = "0:00";
    }
}
