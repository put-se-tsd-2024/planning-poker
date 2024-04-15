using Microsoft.AspNetCore.Components;
using PlanningPoker.Shared;

namespace PlanningPoker.Client.Services
{
    public class RoomStatusManager
    {
        public Player Player { get; set; } = new Player();
        public Room Room { get; set; } = new Room();
        public bool IsStatusReady => !(string.IsNullOrWhiteSpace(Player.Name) || string.IsNullOrWhiteSpace(Room.Id));
        public string GetRoomUrl(NavigationManager navigationManager)
        {
            return navigationManager.ToAbsoluteUri($"/Room/{Room.Id}").ToString();
        }
    }
}