using System.ComponentModel.DataAnnotations.Schema;

namespace assignment.Entities
{
    public class Course
    {
                
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [InverseProperty(nameof(Topic.ID))]
        public int Top_ID { get; set; }
        public Topic Topic { get; set; }    
    }
}