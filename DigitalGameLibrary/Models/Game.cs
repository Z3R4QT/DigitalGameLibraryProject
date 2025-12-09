using SQLite;

public class Game
{
    [PrimaryKey, AutoIncrement]

    public string Title { get; set; }
    public string Genre { get; set; }
    public string Platform { get; set; }
}
