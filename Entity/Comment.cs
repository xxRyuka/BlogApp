namespace BlogApp.Entity
{

    public class Comment
    {
        public int CommentId { get; set; }

        public string? Text { get; set; }

        public DateTime PublishedOn { get; set; }

        //Relations

        //one to many post - comment
        public int PostId { get; set; }
        public Post Post { get; set; } = null!;

        //one to many post - user
        public int UserId { get; set; }
        public User User { get; set; } = null!;

    }

}