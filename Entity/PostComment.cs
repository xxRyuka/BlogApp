namespace BlogApp.Entity
{

    public class PostComment
    {
        public int CommentId { get; set; }

        public Comment Comment { get; set; } = null!;


        public Post Post { get; set; }= null!;
        public int PostId { get; set; }


   


    }

}