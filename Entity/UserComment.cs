namespace BlogApp.Entity
{

    public class UserComment
    {
        public int UserId { get; set; }

        public User User { get; set; } = null!;


        public Comment Comment { get; set; }= null!;
        public int CommentId { get; set; }


   


    }

}