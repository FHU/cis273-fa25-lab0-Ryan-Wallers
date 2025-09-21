namespace Uno;

public class Player
{
    public string Name { get; set; } = "";

    public List<Card> Hand { get; set; } = new List<Card>();


    public bool HasPlayableCard(Card card)
    {
        foreach (var CheckCard in this.Hand)
        {
            if (Card.PlaysOn(card, CheckCard)) { return true; }
        }
        return false;
    }

    public Card GetFirstPlayableCard(Card card)
    {
        foreach (var CheckCard in this.Hand)
        {
            if (Card.PlaysOn(card, CheckCard)) { return CheckCard; }
        }
        return null;
    }


    public Color MostCommonColor()
    {
        var counts = new Dictionary<Color, int>(); // I'm pretty sure this wasn't taught in class, but it seemed like the simplest way to find the counts of the items in a list
        foreach (var card in Hand)
        {
            if (counts.ContainsKey(card.Color)) counts[card.Color]++;
            else counts[card.Color] = 1;
        }
        return counts.OrderByDescending(x => x.Value).First().Key;
    }

}