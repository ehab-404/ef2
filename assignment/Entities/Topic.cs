using System.ComponentModel.DataAnnotations;

namespace assignment.Entities
{
    public class Topic
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}