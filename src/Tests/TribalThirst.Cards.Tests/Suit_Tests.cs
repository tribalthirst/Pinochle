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
        Suit suit = new Suit(name, symbol, Color.FromName(color));
    }

    [DataRow("Diamonds", "♦️", "Red")]
    [DataRow("Hearts", "♥️", "Red")]
    [DataRow("Spades", "♠️", "Black")]
    [DataRow("Clubs", "♣️", "Black")]
    [TestMethod]
    public void Suit_Name_Symbol_Color_With_Value(string name, string symbol, string color)
    {
        Suit suit = new Suit(name, symbol, Color.FromName(color));
        Assert.AreEqual(name, suit.Name);
        Assert.AreEqual(symbol, suit.Symbol);
        Assert.AreEqual(Color.FromName(color).Name, suit.Color.Name);
    }

}