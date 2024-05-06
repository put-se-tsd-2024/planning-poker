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

        public string Tasks { get; set; }
        public string AsignedTo { get; set; }
        public string IsCompleted { get; set; }

    }
}
