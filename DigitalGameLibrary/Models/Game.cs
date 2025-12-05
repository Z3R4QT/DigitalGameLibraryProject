public class Game
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Platform { get; set; }
    public DateTime ReleaseDate { get; set; }

    // New property: controls whether the game appears in ComboBox/DataGridView
    public bool VisibleInList { get; set; } = false;
}
