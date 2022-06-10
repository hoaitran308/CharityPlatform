namespace CharityPlatform.Models
{
    public class Target
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<DonatedItem> DonatedItems { get; set; }
    }
}
