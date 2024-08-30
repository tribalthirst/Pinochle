namespace TribalThirst.Cards.Tests
{
    [TestClass]
    public class Deck_Tests
    {
        [TestMethod]
        public void Standard_Deck_Contains_Correct_Cards()
        {
            Deck deck = StandardDeck.Create();
            Assert.AreEqual(52, deck.Cards.Count);
            Assert.AreEqual(4, deck.Suits.Count);
            Assert.AreEqual(DeckType.Standard, deck.DeckType);
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit.Name == "Diamonds"));
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit.Name == "Hearts"));
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit.Name == "Clubs"));
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit.Name == "Spades"));
        }

        [TestMethod]
        public void Standard_Decks_Are_Equal()
        {
            Deck deck1 = StandardDeck.Create();
            Deck deck2 = StandardDeck.Create();
            Assert.AreEqual(deck1, deck2);
        }

        [TestMethod]
        public void Pinochle_Deck_Contains_Correct_Cards()
        {
            Deck deck = PinochleDeck.Create();
            Assert.AreEqual(48, deck.Cards.Count);
            Assert.AreEqual(4, deck.Suits.Count);
            Assert.AreEqual(DeckType.Pinochle, deck.DeckType);
            Assert.AreEqual(12, deck.Cards.Count(c => c.Suit.Name == "Diamonds"));
            Assert.AreEqual(12, deck.Cards.Count(c => c.Suit.Name == "Hearts"));
            Assert.AreEqual(12, deck.Cards.Count(c => c.Suit.Name == "Clubs"));
            Assert.AreEqual(12, deck.Cards.Count(c => c.Suit.Name == "Spades"));
            Assert.AreEqual(8, deck.Cards.Count(c => c.Name == "Nine"));
            Assert.AreEqual(8, deck.Cards.Count(c => c.Name == "Jack"));
            Assert.AreEqual(8, deck.Cards.Count(c => c.Name == "Queen"));
            Assert.AreEqual(8, deck.Cards.Count(c => c.Name == "King"));
            Assert.AreEqual(8, deck.Cards.Count(c => c.Name == "Ten"));
            Assert.AreEqual(8, deck.Cards.Count(c => c.Name == "Ace"));
        }

    }
}
