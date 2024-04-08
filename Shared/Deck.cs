using System.Collections.Generic;

namespace PlanningPoker.Shared
{
    public class Deck
    {
        public IEnumerable<Card> Cards { get; set; } = new List<Card>();
    }
}
