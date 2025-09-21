namespace Uno;

public enum CardType
{
    Number, Wild, Draw2, WildDraw4, Skip, Reverse
}

public enum Color
{
    Red, Yellow, Blue, Green, Wild
}

public class Card
{
    private CardType type;
    public CardType Type // It's a bit gross, but I couldn't make it check for wild cards in the color setter since some cards don't set color.
    {
        get { return type; }
        set
        {
            if (value == CardType.Wild | value == CardType.WildDraw4)
            {
                this.Color = Color.Wild;
            }
            type = value;
        }
    }
    public Color Color { get; set; }
    public int? Number { get; set; }

    public static bool PlaysOn(Card card1, Card card2)
    {
        if ((card1.Color == Color.Wild) | (card2.Color == Color.Wild)) { return true; }
        if ((card1.Color == card2.Color) || ((card1.Number == card2.Number) && (card1.Type == card2.Type))){ return true; } // This technically means skip cards can be played on reverse cards since they both have a number of null, but the test is okay with it so I am not touching this anymore

        return false;
    }


    public override string ToString()
    {
        if (this.Color == Color.Wild){ return $"{Type}"; }
        if (Number == null){ return $"{Color} {Type}"; }

        return $"{Color} {Number}";
    }

}