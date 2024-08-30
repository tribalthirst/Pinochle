namespace TribalThirst.Cards
{
    public class PinochleDeck : Deck
    {
        private PinochleDeck(IReadOnlyCollection<Card> cards) :
    base(cards, CreateDefaultSuits(), DeckType.Pinochle)
        { }

        public static PinochleDeck Create()
        {
            List<Card> deck = AddCardsToDeck(GetCardNames(), CreateDefaultSuits());
            deck.AddRange(deck);

            return new PinochleDeck(deck);
        }

        private static IReadOnlyDictionary<string, string> GetCardNames()
        {
            Dictionary<string, string> cardNames = new Dictionary<string, string>
            {
                {"9","Nine" },
                {"J","Jack" },
                {"Q","Queen" },
                {"K","King" },
                {"10","Ten" },
                {"A","Ace" }
            };
            return cardNames;
        }
    }
}
