using System.ComponentModel.DataAnnotations.Schema;

namespace CharityPlatform.Models
{
    public class PostImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
