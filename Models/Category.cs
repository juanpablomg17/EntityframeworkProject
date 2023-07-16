using System.ComponentModel.DataAnnotations;

namespace efproject.Models
{
    public class Category
    {
        [Key]
        public Guid categoryId { get; set; }
        
        [Required, MaxLength(150)]
        public string name { get; set; }

        public string description { get; set; }

        public virtual ICollection<TaskModel> tasks { get; set; }
    }
}