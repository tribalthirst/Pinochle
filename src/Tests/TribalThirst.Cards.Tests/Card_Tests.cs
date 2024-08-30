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
}
