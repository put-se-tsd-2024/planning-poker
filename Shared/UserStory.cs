using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanningPoker.Shared
{
    public class UserStory
    {
        [Key]
        public int Id { get; set; }
        public string RoomId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string AssignedTo { get; set; }
        public string IsCompleted { get; set; }

        public ICollection<Work> Works { get; set; }
    }
}
