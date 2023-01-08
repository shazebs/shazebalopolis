using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace shazebs.api.Models
{
    [Table("Tweets")]
    public class Tweet
    {
        [Key]
        public long TweetId { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string Username { get; set; }
    }
}
