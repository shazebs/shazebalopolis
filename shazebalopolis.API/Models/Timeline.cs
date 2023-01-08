using System.ComponentModel.DataAnnotations;

namespace shazebs.api.Models
{
    public class Timeline
    {
        [Key]
        public long TimelineId { get; set; }

        [Required]
        public long PersonId { get; set; }
        public Person? Person { get; set; }


        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }
}
