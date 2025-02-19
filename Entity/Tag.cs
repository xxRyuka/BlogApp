namespace BlogApp.Entity
{

    public class Tag
    {
        public int TagId { get; set; }

        public string? Text { get; set; }

        //Relations

        //many to mant tag-posts
        public ICollection<Post> Posts { get; set; } = new List<Post>();

    }

}