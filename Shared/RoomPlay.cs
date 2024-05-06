namespace PlanningPoker.Shared
{
    public class RoomPlay
    {
        public string HubConnectionId { get; set; }
        public Room Room { get; set; }
        public Player Player { get; set; }
        public Card CardPlayed { get; set; }
        public bool HasPlayed => string.IsNullOrWhiteSpace(CardPlayed.Value) == false;
    }
}
