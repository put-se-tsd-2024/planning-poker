using System.ComponentModel.DataAnnotations;

namespace PlanningPoker.Shared
{
    public class UserStory
    {
        [Key]
        public int Id { get; set; }
        public string RoomId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Other properties needed for the user story?
    }
}
