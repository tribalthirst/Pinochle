
namespace TribalThirst.Cards
{
    public class Deck : ValueObject
    {
        public IReadOnlyCollection<Card> Cards { get; protected set; }
        public IReadOnlyCollection<Suit> Suits { get; protected set; }
        public DeckType DeckType { get; protected set; }

        protected Deck(IReadOnlyCollection<Card> card, IReadOnlyCollection<Suit> suits, DeckType type)
        {
            Cards = card;
            Suits = suits;
            DeckType = type;
        }

        protected static IReadOnlyCollection<Suit> CreateDefaultSuits()
        {
            List<Suit> suits = new List<Suit>();
            suits.Add(Suit.Create("Diamonds", "♦️", Color.Red));
            suits.Add(Suit.Create("Hearts", "♥️", Color.Red));
            suits.Add(Suit.Create("Clubs", "♣️", Color.Black));
            suits.Add(Suit.Create("Spades", "♠️", Color.Black));
            return suits;
        }

        protected override IEnumerable<IComparable> GetEqualityComponents()
        {
            foreach (var card in Cards)
            {
                yield return card;
            }
        }

        protected static List<Card> AddCardsToDeck(IReadOnlyDictionary<string, string> cardNames, IReadOnlyCollection<Suit> suits)
        {
            List<Card> deck = new List<Card>();

            suits.ToList().ForEach(suit =>
            {
                cardNames.ToList().ForEach(card =>
                {
                    deck.Add(Card.Create(card.Value, card.Key, suit));
                });
            });


            return deck;
        }
    }
}
