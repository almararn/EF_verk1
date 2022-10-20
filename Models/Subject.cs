using System.ComponentModel.DataAnnotations;

namespace EF_verkefni1.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        
        [MaxLength(255)]
        public string Title { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Marks> Marks { get; set; }
    }
}
