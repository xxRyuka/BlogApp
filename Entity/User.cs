namespace BlogApp.Entity
{

    public class User
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }


        //Relations


        // One to Many user post iliskisi 
        public ICollection<Post> Posts { get; set; } = new List<Post>();


        //one to mant comment - user iliskisi
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();


    }

}