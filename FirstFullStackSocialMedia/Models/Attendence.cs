using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstFullStackSocialMedia.Models
{
    public class Attendence
    {
        public Gig Gig { get; set; }
        public ApplicationUser user { get; set; }

        [Key]
        [Column(Order = 1)]
        public int GigId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string AttendeeId { get; set; }
    }
}