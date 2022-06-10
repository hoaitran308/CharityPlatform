using System.ComponentModel.DataAnnotations.Schema;

namespace CharityPlatform.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Banner { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Contact { get; set; }
        [ForeignKey(nameof(Target))]
        public int TargetId { get; set; }
        public int Quantity { get; set; }
        public bool IsApproved { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual ICollection<PostImage> PostImages { get; set; }
        public virtual User User { get; set; }
        public virtual Target Target { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }


    }
}
