using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efproject.Models
{
    public class TaskModel
    {
        [Key]
        public Guid taskId { get; set; }

        [ForeignKey("categoryId")]
        public Guid categoryId { get; set; }
        
        [Required, MaxLength(150)]
        public string title { get; set; }

        public string description { get; set; }

        public Priority priorityLevel { get; set; }

        public DateTime creationDate { get; set; }

        public virtual Category category { get; set; }

        [NotMapped]
        public string summary { get; set; }
    }
}


public enum Priority {
    Low,
    Medium,
    High
}