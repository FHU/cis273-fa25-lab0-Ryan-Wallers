namespace Uno;

public class Program
{
    public static void Main(string[] args)
    {
        var wild = new Card() { Type = CardType.Wild };
        var blueReverse = new Card() { Type = CardType.Reverse, Color = Color.Blue };

        Console.WriteLine(Card.PlaysOn(wild, blueReverse));
        
        
    }
}
