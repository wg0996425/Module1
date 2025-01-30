namespace Module1;

class Program
{
    static void Main(string[] args)
    {
        Player player = new("", 0);
        player.AccessPlayer();
        Console.WriteLine($"Player Initials: {player.Initials}.\nPlayer Score: {player.Score}.");
    }
}