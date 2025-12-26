# 🎵 Audio Player

> A modern, feature-rich command-line audio player built with C# and .NET 8

[![Language](https://img.shields.io/badge/Language-C%23-239120?logo=csharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Framework](https://img.shields.io/badge/Framework-.NET%208-512BD4?logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![GitHub Stars](https://img.shields.io/github/stars/Sarvardev035/Audioplayer?style=social)](https://github.com/Sarvardev035/Audioplayer)

## ✨ Features

- 🎼 **Multi-Format Support** - MP3, WAV, FLAC, OGG, AAC
- 📂 **Playlist Management** - Load and organize audio files
- ⏯️ **Playback Controls** - Play, next, previous, navigation
- 📊 **Statistics** - View playlist info and file sizes
- 🎨 **Beautiful UI** - Formatted console with emojis and borders
- 💻 **Cross-Platform** - Works on Windows, macOS, and Linux
- ⚡ **Performance** - Lightweight and responsive

## 🚀 Quick Start

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Linux, macOS, or Windows

### Installation

```bash
# Clone the repository
git clone https://github.com/Sarvardev035/Audioplayer.git
cd AudioPlayer

# Install dependencies (automatic)
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run
```

## 📖 Usage

### Main Menu
```
╔═══════════════════════════════╗
║      Audio Player v1.0        ║
╚═══════════════════════════════╝

┌─────────────────────────────┐
│ [1] Load Audio Files        │
│ [2] Play Current Track      │
│ [3] View Playlist           │
│ [4] Next Track              │
│ [5] Previous Track          │
│ [6] Playlist Stats          │
│ [7] Exit                    │
└─────────────────────────────┘
```

### Example Workflow

1️⃣ **Load Audio Files**
```
Enter directory path with audio files: /home/user/Music
✅ Loaded 15 audio files!
```

2️⃣ **View Playlist**
```
📋 PLAYLIST:
──────────────────────────────────────────────────
▶️  [1]  song1.mp3                         3.45 MB
   [2]  song2.wav                         5.20 MB
   [3]  song3.flac                        8.10 MB
──────────────────────────────────────────────────
```

3️⃣ **Play Tracks**
```
▶️  Now Playing: song1.mp3
   Duration: 0:00
   File: /home/user/Music/song1.mp3
   Size: 3.45 MB
```

4️⃣ **View Statistics**
```
📊 PLAYLIST STATISTICS:
──────────────────────────────────────────────────
Total Tracks: 15
Total Size: 120.50 MB
Formats: mp3, wav, flac, ogg, aac
Current Track: 1 / 15
──────────────────────────────────────────────────
```

## 🏗️ Project Structure

```
AudioPlayer/
├── Program.cs              # Main application logic
├── AudioPlayer.csproj      # Project configuration
├── README.md              # Documentation
├── bin/                   # Compiled binaries
├── obj/                   # Build artifacts
└── .gitignore            # Git ignore rules
```

## 💡 Code Highlights

### OOP Design
- **AudioPlayer Class** - Core application logic and menu management
- **AudioFile Class** - Encapsulates audio file metadata

### Key Technologies Used
```csharp
// Collections & LINQ
List<AudioFile> playlist
playlist.Sum(f => f.Size)

// File System Operations
Directory.GetFiles()
FileInfo

// String Formatting
FormatFileSize(long bytes)
String interpolation

// Error Handling
try-catch blocks
Input validation
```

## 🎯 Skills Demonstrated

| Skill | Description |
|-------|-------------|
| 🔷 **C# Programming** | Clean, modern C# with best practices |
| 🏗️ **OOP Principles** | Classes, encapsulation, separation of concerns |
| 📦 **Collections & LINQ** | List, LINQ queries, enumeration |
| 📂 **File I/O** | Directory/file operations, metadata |
| 🎨 **UI/UX** | Formatted console output, user experience |
| 🚀 **Performance** | Efficient algorithms, proper resource management |
| 🧪 **Testing** | Validation, error handling |

## 🔮 Future Enhancements

- [ ] 🔊 Actual audio playback support
- [ ] 🔍 Search and filter functionality
- [ ] 🎲 Shuffle and repeat modes
- [ ] 💾 Save/load playlists
- [ ] 🎨 GUI interface using WPF/WinForms
- [ ] 📱 Mobile companion app
- [ ] ☁️ Cloud storage integration
- [ ] 🎧 Visualization support

## 🤝 Contributing

Contributions are welcome! Here's how to help:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit changes (`git commit -m 'Add AmazingFeature'`)
4. Push to branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see [LICENSE](LICENSE) file for details.

## 👨‍💻 Author

**Sarvardev035** ([GitHub](https://github.com/Sarvardev035))

## 📞 Support

- 📧 Email: sarvarbek@example.com
- 💬 Issues: [GitHub Issues](https://github.com/Sarvardev035/Audioplayer/issues)
- 🐛 Bug Reports: Please create an issue with detailed description

## 📊 Stats

![GitHub Repo Size](https://img.shields.io/github/repo-size/Sarvardev035/Audioplayer)
![GitHub Last Commit](https://img.shields.io/github/last-commit/Sarvardev035/Audioplayer)
![GitHub Top Language](https://img.shields.io/github/languages/top/Sarvardev035/Audioplayer)

---

<div align="center">

**⭐ If you found this helpful, please star the repository! ⭐**

[↑ Back to top](#-audio-player)

</div>
