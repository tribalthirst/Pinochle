using System.Drawing;

namespace TribalThirst.Cards.Tests;

[TestClass]
public class Suit_Tests
{
    [TestMethod]
    [DataRow("Hearts", "", "RED")]
    [DataRow("", "S", "Black")]
    [DataRow("", "♣️", "Red")]
    [ExpectedException(typeof(ArgumentException))]
    public void Suit_Empty_Required_Value_Throws_Exception(string name, string symbol, string color)
    {
        Suit suit = Suit.Create(name, symbol, Color.FromName(color));
    }

    [DataRow("Diamonds", "♦️", "Red")]
    [DataRow("Hearts", "♥️", "Red")]
    [DataRow("Spades", "♠️", "Black")]
    [DataRow("Clubs", "♣️", "Black")]
    [TestMethod]
    public void Suit_Name_Symbol_Color_With_Value(string name, string symbol, string color)
    {
        Suit suit = Suit.Create(name, symbol, Color.FromName(color));
        Assert.AreEqual(name, suit.Name);
        Assert.AreEqual(symbol, suit.Symbol);
        Assert.AreEqual(Color.FromName(color).Name, suit.Color.Name);
    }
    [TestMethod]
    public void Suit_Equality()
    {
        Suit suit1 = Suit.Create("Diamonds", "♦️", Color.Red);
        Suit suit2 = Suit.Create("Diamonds", "♦️", Color.Red);
        Assert.AreEqual(suit1, suit2);
    }

    [DataRow("Diamonds", "♦️", "Red")]
    [DataRow("Hearts", "♥️", "Green")]
    [DataRow("Spades", "♥️", "Red")]
    [TestMethod]
    public void Suit_Inequality(string name, string symbol, string color)
    {
        Suit suit1 = Suit.Create(name, symbol, Color.FromName(color));
        Suit suit2 = Suit.Create("Hearts", "♥️", Color.Red);
        Assert.AreNotEqual(suit1, suit2);
    }

}