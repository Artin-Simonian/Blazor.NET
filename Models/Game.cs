namespace GameStore.Client.Models;

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public String Genre { get; set; } = "";
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
}