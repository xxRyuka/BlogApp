namespace BlogApp.Entity
{

    public class PostTag
    {
        public int TagId { get; set; }

        public Tag Tag { get; set; } = null!;


        public Post Post { get; set; }= null!;
        public int PostId { get; set; }


   


    }

}