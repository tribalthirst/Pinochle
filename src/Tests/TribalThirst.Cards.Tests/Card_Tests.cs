using System.Drawing;

namespace TribalThirst.Cards.Tests;

[TestClass]
public class Card_Tests
{
    [DataRow("8", "")]
    [DataRow("", "8")]
    [DataRow("", "")]
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Card_Missing_Required_Fields_Throws_Exception(string name, string shortName)
    {
        Suit diamonds = Suit.Create("Diamonds", "♦️", Color.Red);

        Card card = Card.Create(name, shortName, diamonds);
    }

    [TestMethod]
    public void Card_Name_ShortName_Suit_With_Value()
    {
        Suit diamonds = Suit.Create("Diamonds", "♦️", Color.Red);

        Card card = Card.Create("Eight", "8", diamonds);

        Assert.AreEqual("Eight", card.Name);
        Assert.AreEqual("8", card.ShortName);
        Assert.AreEqual(diamonds, card.Suit);
    }
    [TestMethod]
    public void Card_Equality()
    {
        Card card1 = Card.Create("Eight", "8", Suit.Create("Diamonds", "♦️", Color.Red));
        Card card2 = Card.Create("Eight", "8", Suit.Create("Diamonds", "♦️", Color.Red));
        Assert.AreEqual(card1, card2);
    }

    [DataRow("Eight", "7", "♦️")]
    [DataRow("Seven", "8", "♦️")]
    [DataRow("Eight", "8", "♣️")]
    [TestMethod]
    public void Card_Inequality(string name, string shortName, string symbol)
    {
        Card card1 = Card.Create(name, shortName, Suit.Create("Diamonds", symbol, Color.Red));
        Card card2 = Card.Create("Eight", "8", Suit.Create("Diamonds", "♦️", Color.Red));
        Assert.AreNotEqual(card1, card2);
    }
}
