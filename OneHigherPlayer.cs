namespace ShootingDice;
// TODO: Complete this class

// Override the Play method to make a Player who always roles one higher than the other player
public class OneHigherPlayer : Player
{
    public override void Play(Player other)
    {
        int myRoll = Roll();
        int otherRoll = other.Roll();

        int myOneUpRoll = otherRoll + 1;

        Console.WriteLine($"{Name} rolls a {myOneUpRoll}");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");
        Console.WriteLine($"{Name} Wins!");
    }
}
