namespace BlogApp.Entity
{

    public class UserPost
    {
        public int UserId { get; set; }

        public User User { get; set; } = null!;


        public Post Post { get; set; }= null!;
        public int PostId { get; set; }


   


    }

}