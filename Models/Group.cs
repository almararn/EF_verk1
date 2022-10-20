using System.ComponentModel.DataAnnotations;

namespace EF_verkefni1.Models
{
    public class Group
    {
        public int GroupId { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
    }
}
