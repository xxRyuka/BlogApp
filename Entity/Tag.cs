namespace BlogApp.Entity
{

    public class Tag
    {
        public int TagId { get; set; }

        public string? Text { get; set; }

        //Relations

        //many to mant tag-posts
        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();

    }

}