using System.Security.Cryptography.X509Certificates;

public class Player
{
    private string? initials;
    private int? score;

    public string? Initials { get{ return initials; } set{ initials = value; } }
    public int? Score { get{ return score; } set{ score = value; } }

    public Player(string initials, int score)
    {
        this.Initials = initials;
        this.Score = score;
    }

    public void AccessPlayer()
    {
        Initials = "WVG";
        Score = 303000;
    }
}