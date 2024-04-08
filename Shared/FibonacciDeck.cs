using System.Collections.Generic;

namespace PlanningPoker.Shared
{
    public static class FibonacciDeck
    {
        public static Deck Deck = new Deck
        {
            Cards = new List<Card>
            {
                new Card{ Text="1", Value="1", SortOrder=0 },
                new Card{ Text="2", Value="2", SortOrder=1 },
                new Card{ Text="3", Value="3", SortOrder=2 },
                new Card{ Text="5", Value="5", SortOrder=3 },
                new Card{ Text="8", Value="8", SortOrder=4 },
                new Card{ Text="13", Value="13", SortOrder=5 },
                new Card{ Text="21", Value="21", SortOrder=6 }
            }
        };
    }
}
