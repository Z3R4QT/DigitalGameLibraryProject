using System;

namespace DigitalGameLibrary.Models
{
    public class UserGameLibrary
    {
        public int LibraryEntryID { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }
        public string? Platform { get; set; }
        public DateTime? DateAcquired { get; set; }
        public double PlaytimeHours { get; set; }
    }
}
