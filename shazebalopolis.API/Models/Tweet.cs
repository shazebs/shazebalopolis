using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shazebs.api.Models
{
    [Table("Tweets")]
    public class Tweet
    {
        [Key]
        public long TweetId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public string Content { get; set; }

        public List<User> Likes { get; set; }

        public Dictionary<User, string> Comments { get; set; }

        public List<string> HashTags { get; set; }

        public List<User> Mentions { get; set; }

        public string Datetime { get; set; }

        public List<User> Dislikes { get; set; }

        public string BackgroundImage { get; set; }

        public List<string> PhotoAttachments { get; set; }

        public List<string> HttpLinks { get; set; }

        public List<string> YoutubeEmbeds { get; set; }

        public string TextFontId { get; set; }
    }
}
