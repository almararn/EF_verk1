using System.ComponentModel.DataAnnotations;

namespace EF_verkefni1.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }
        
        [MaxLength(255)]
        public string LastName { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }

    }
}
