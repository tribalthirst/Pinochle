using System.Drawing;
using static System.String;
using static System.Char;

namespace TribalThirst.Cards;


public class Suit
{

    public Suit(string name, string symbol, Color color)
    {
        Name = !IsNullOrWhiteSpace(name) ? name : throw new ArgumentException("Suit name cannot be empty", nameof(name));
        Symbol = IsValidSymbol(symbol) ? symbol : throw new ArgumentException("Suit Symbol is not valid");
        Color = color;
    }


    private bool IsValidSymbol(string symbol) => !IsNullOrWhiteSpace(symbol) &&
            (symbol.Length == 1 || (symbol.Length == 2 && IsSymbol(symbol[0])));

    public string Name { get; }
    public string Symbol { get; }

    public Color Color { get; }
}
