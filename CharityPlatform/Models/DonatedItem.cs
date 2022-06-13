using System.ComponentModel.DataAnnotations.Schema;

namespace CharityPlatform.Models
{
    public class DonatedItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        [ForeignKey(nameof(Target))]
        public int? TargetId { get; set; }
        [ForeignKey(nameof(Donation))]
        public int? DonationId { get; set; }
        public virtual Target Target { get; set; }
        public virtual Donation Donation { get; set; }
    }
}
