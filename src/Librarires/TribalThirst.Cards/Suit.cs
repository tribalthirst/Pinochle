using System.Drawing;
using static System.Char;
using static System.String;

namespace TribalThirst.Cards;


public class Suit
{
    public string Name { get; private set; }
    public string Symbol { get; private set; }
    public Color Color { get; private set; }

    private Suit(string name, string symbol, Color color)
    {
        Name = name;
        Symbol = symbol;
        Color = color;
    }

    public static Suit Create(string name, string symbol, Color color)
    {
        return IsNullOrWhiteSpace(name)
            ? throw new ArgumentException("Suit name cannot be empty", nameof(name))
            : !IsValidSymbol(symbol)
            ? throw new ArgumentException("Suit Symbol is not valid")
            : new(name, symbol, color);
    }

    private static bool IsValidSymbol(string symbol) =>
        !IsNullOrWhiteSpace(symbol) &&
        (symbol.Length == 1 || (symbol.Length == 2 && IsSymbol(symbol[0])));
}
