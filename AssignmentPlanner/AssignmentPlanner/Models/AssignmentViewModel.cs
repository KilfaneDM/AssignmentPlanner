using System.ComponentModel.DataAnnotations;

namespace AssignmentPlanner.Models
{
    public class AssignmentStepViewModel
    {
        public string Title { get; set; }
        public string Instructions { get; set; }
        public int Percentage { get; set; }
    }

    public class AssignmentViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public List<AssignmentStepViewModel> Steps { get; set; } = new List<AssignmentStepViewModel>();
    }
}
