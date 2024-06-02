namespace ShootingDice;

// TODO: Complete this class

// A player that prompts the user to enter a number for a roll
public class HumanPlayer : Player
{
    public override void Play(Player other)
    {
        Console.WriteLine($"{Name}, enter a number 1-6...");
        int myRoll = int.Parse(Console.ReadLine().Trim());
        int otherRoll = other.Roll();

        Console.WriteLine($"{Name} rolls a {myRoll}");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");

        if (myRoll > otherRoll)
        {
            Console.WriteLine($"{Name} Wins!");
        }
        else if (myRoll < otherRoll)
        {
            Console.WriteLine($"{other.Name} Wins!");
        }
        else
        {
            Console.WriteLine("It's a tie");
        }
    }
}