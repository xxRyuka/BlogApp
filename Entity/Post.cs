namespace BlogApp.Entity
{

    public class Post
    {
        public int PostId { get; set; }

        public string? Title { get; set; }

        public string? Content { get; set; }

        public DateTime PublishedOn { get; set; }

        public bool isActive { get; set; }


        // Relations

        // one-to many user post
        public int UserId { get; set; }
        public User User { get; set; } = null!;

       // many to many post - tag 
       public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();

       //one to many post-comment
       public ICollection<Comment> Comments { get; set; }= new List<Comment>();
    }

}