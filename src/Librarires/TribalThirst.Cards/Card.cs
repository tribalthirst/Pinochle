namespace TribalThirst.Cards;

public class Card
{
    public Card(string name, string shortName, Suit suit)
    {
        Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentException("Card name cannot be empty", nameof(name));
        ShortName = !string.IsNullOrWhiteSpace(shortName) ? shortName : throw new ArgumentException("Card short name cannot be empty", nameof(shortName));
        Suit = suit ?? throw new ArgumentException("Card suit cannot be null", nameof(suit));
    }

    public string Name { get; }
    public Suit Suit { get; }
    public string ShortName { get; }

}
