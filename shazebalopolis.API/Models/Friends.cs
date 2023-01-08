using System.ComponentModel.DataAnnotations;

namespace shazebs.api.Models
{
    public class Friends
    {
        [Key]
        public long FriendsId { get; set; }


        [Required]
        public long PersonId1 { get; set; }
        public Person? Person1 { get; set; }


        [Required]
        public long PersonId2 { get; set; }
        public Person? Person2 { get; set; }
    }
}
