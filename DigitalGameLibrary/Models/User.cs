using System;

namespace DigitalGameLibrary.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateTime? CreationDate { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
