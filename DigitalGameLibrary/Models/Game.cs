using System;

namespace DigitalGameLibrary.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Developer { get; set; }
        public string? ESRBRating { get; set; }
    }
}
