using System.ComponentModel.DataAnnotations.Schema;

namespace CharityPlatform.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public DateTime DonatedDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public bool IsReceived { get; set; }
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<DonatedItem> DonatedItems { get; set; }

    }
}
