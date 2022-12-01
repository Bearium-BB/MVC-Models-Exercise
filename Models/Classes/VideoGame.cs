using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Models_Exercise.Models
{
    internal class VideoGame
    {
        private static int _nextId { get; set; } = 1;
        public int Id { get; } = _nextId++;
        public string Title { get; }
        public string Category { get; }
        public int Year { get; }
        public int PlayerCount { get; }
        public float Price { get; }
        public Studio Studio { get; }
        private HashSet<VideoGameConsole> _consoles { get; set; } = new();
        public HashSet<VideoGameConsole> Consoles { get { return _consoles.ToHashSet(); } }
        public Publisher Publisher { get; }
        public int AgeRating { get; }

        public VideoGame(string title, string category, int year, int playerCount, float price, Studio studio, HashSet<VideoGameConsole> consoles, Publisher publisher, int ageRating)
        {
            Title = title;
            Category = category;
            Year = year;
            PlayerCount = playerCount;
            Price = price;
            Studio = studio;
            _consoles = consoles;
            Publisher = publisher;
            AgeRating = ageRating;
        }

        public void AddConsole(VideoGameConsole console)
        {
            _consoles.Add(console);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
