namespace ClassExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StopWatch();
            StackOverflowPost();
        }


        // Exercise 1
        public static void StopWatch()
        {
            var stopWatch = new StopWatch();
            stopWatch.Start();
            Task.Delay(15000).Wait();
            try
            {
                stopWatch.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            stopWatch.Stop();
            Console.WriteLine("Stop watch ran for {0} total seconds", stopWatch.Duration());

            stopWatch.Start();
            Task.Delay(5000).Wait();
            stopWatch.Stop();
            Console.WriteLine("Stop watch ran for {0} total seconds", stopWatch.Duration());

            stopWatch.Reset();
            stopWatch.Start();
            Task.Delay(7000).Wait();
            stopWatch.Stop();
            Console.WriteLine("Stop watch ran for {0} total seconds", stopWatch.Duration());

        }

        public static void StackOverflowPost()
        {
            Console.Write("Enter your post title: ");
            string postTitle = Console.ReadLine();
            Console.Write("Enter your post description: ");
            string postBody = Console.ReadLine();

            var post = new StackOverflowPost(postTitle, postBody);
            post.DisplayPost();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.DisplayPost();
        }
    }


}
