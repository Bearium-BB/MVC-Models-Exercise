using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Models_Exercise.Models
{
    internal class VideoGameConsole
    {
        public string Name { get; }
        private HashSet<VideoGame> _videoGames { get; set; } = new();
        public HashSet<VideoGame> VideoGames { get { return _videoGames.ToHashSet(); } }
        public double Price { get; private set; }
        public int MaxPlayers { get; }
        public bool CanConnectToInternet { get; }

        public VideoGameConsole(string name, double price, int maxPlayers, bool connected)
        {
            Name = name;
            Price = price;
            MaxPlayers = maxPlayers;
            CanConnectToInternet = connected;
        }

        public void AddGame(VideoGame game)
        {
            _videoGames.Add(game);
        }
    }
}
