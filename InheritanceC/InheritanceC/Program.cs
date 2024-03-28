namespace InheritanceC
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Faruk Furkan");
            Console.WriteLine(post1.ToString());
            
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Faruk Furkan", 
                "http://images.com/shoes", true);
            
            VideoPost videoPost1 = new VideoPost("New Videoo!", "Faruk Furkan", 
                "http://video.com/video", true, 10);

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();


            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());
            Console.ReadLine();
        }

        // CHALLENGE add a deriving class "VideoPost" with a property VideoURL, Length.

       // create the required constructors to create a VideoPost
       // adjust the ToString() method accordingly
       // create an instance of VideoPost

        // More advanced - use Timer and a Callback method here (google it :))
        // create fields as required
        // add member methods "Play" which should write the current duration of the video
        // and "Stop" which should stop the "timer" and write "stopped at {0}s" onto the console.
        // Play the video after creating the instance and pause it, when the user presses any key.
    }
}
