
namespace TribalThirst.Cards;

public class Card : ValueObject
{

    public string Name { get; private set; }
    public Suit Suit { get; private set; }
    public string ShortName { get; private set; }
    private Card(string name, string shortName, Suit suit)
    {
        Name = name;
        ShortName = shortName;
        Suit = suit;
    }

    public static Card Create(string name, string shortName, Suit suit)
    {
        return string.IsNullOrWhiteSpace(name)
            ? throw new ArgumentException("Card name cannot be empty", nameof(name))
            : string.IsNullOrWhiteSpace(shortName)
            ? throw new ArgumentException("Card short name cannot be empty", nameof(shortName))
            : suit is null
            ? throw new ArgumentException("Card suit cannot be null", nameof(suit))
            : new Card(name, shortName, suit);
    }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Name;
        yield return ShortName;
        yield return Suit;
    }
}
