using System.ComponentModel.DataAnnotations;

namespace shazebs.api.Models
{
    public class Person
    {
        [Key]
        public long PersonId { get; set; }

        [Required]
        public string Name { get; set; }

        public Timeline? Timeline { get; set; }  

        public ICollection<Person> Friends { get; set; } = new HashSet<Person>(); 
    }
}
