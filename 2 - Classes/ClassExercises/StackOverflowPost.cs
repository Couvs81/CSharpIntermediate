namespace ClassExercises
{
    public class StackOverflowPost
    {
        public string PostTitle { get; set; }
        public string PostBody { get; set; }

        public DateTime PostDate { get; private set; }

        public int Votes { get; private set; }

        public StackOverflowPost(string postTitle, string postBody)
        {
            PostTitle = postTitle;
            PostBody = postBody;
            Votes = 0;
            PostDate = DateTime.Now;
        }

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            Votes--;
        }
        
        public void DisplayPost()
        {
            Console.WriteLine("\nTitle: {0}", PostTitle);
            Console.WriteLine("{0}", PostBody);
            Console.WriteLine("Created: {0}", PostDate);
            Console.WriteLine("Votes: {0}", Votes);
        }
    }


}
