namespace ShootingDice;
// A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
public class CreativeSmackTalkingPlayer : Player
{
    public List<string> taunts = new List<string>
    {
        "I'm smarter than you!",
        "I'm clever!",
        "I own a speedboat!"
    };

    public override int Roll()
    {
        int randomTaunt = new Random().Next(0, 3);

        string Taunt = taunts[randomTaunt];

        Console.WriteLine($"{Name} taunts '{Taunt}'");

        return new Random().Next(DiceSize) + 1;
    }
}