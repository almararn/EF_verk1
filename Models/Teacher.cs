
using System.ComponentModel.DataAnnotations;

namespace EF_verkefni1.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
