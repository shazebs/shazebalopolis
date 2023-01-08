using System.ComponentModel.DataAnnotations;

namespace shazebs.api.Models
{
    public class Post
    {
        [Key]
        public long PostId { get; set; }

        [Required]
        public string Caption { get; set; }


        [Required]
        public long PersonId { get; set; }
        public Person? Person { get; set; }


        [Required]
        public long TimelineId { get; set; }
        public Timeline? Timeline { get; set; }
    }
}
