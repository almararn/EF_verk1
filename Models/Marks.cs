
namespace EF_verkefni1.Models
{
    public class Marks
    {
        public int MarksId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public int Mark { get; set; }

    }
}
