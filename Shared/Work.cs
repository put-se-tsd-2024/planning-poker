using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace PlanningPoker.Shared
{
    public class Work
    {
        [Key]
        public int Id { get; set; }
        public int UserStoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Estimation { get; set; }
    }
}
