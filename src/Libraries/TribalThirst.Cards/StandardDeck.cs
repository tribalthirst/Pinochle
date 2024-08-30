namespace TribalThirst.Cards
{
    public class StandardDeck : Deck
    {
        private StandardDeck(IReadOnlyCollection<Card> cards) :
            base(cards, CreateDefaultSuits(), DeckType.Standard)
        { }

        public static StandardDeck Create()
        {
            List<Card> deck = AddCardsToDeck(GetCardNames(), Deck.CreateDefaultSuits());

            return new StandardDeck(deck);
        }

        private static IReadOnlyDictionary<string, string> GetCardNames()
        {
            Dictionary<string, string> cardNames = new Dictionary<string, string>
            {
                {"2","Two" },
                {"3","Three" },
                {"4","Four" },
                {"5","Five" },
                {"6","Six" },
                {"7","Seven" },
                {"8","Eight" },
                {"9","Nine" },
                {"10","Ten" },
                {"J","Jack" },
                {"Q","Queen" },
                {"K","King" },
                {"A","Ace" }
            };
            return cardNames;
        }
    }
}
