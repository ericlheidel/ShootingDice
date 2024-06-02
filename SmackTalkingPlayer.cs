namespace ShootingDice;
// TODO: Complete this class

// A Player who shouts a taunt every time they roll dice
public class SmackTalkingPlayer : Player
{
    public string Taunt = "You're going down!";
    public override int Roll()
    {
        Console.WriteLine($"{Name} taunts '{Taunt}'");

        return new Random().Next(DiceSize) + 1;
    }
}