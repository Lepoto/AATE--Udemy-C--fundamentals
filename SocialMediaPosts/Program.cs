namespace SocialMediaPosts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the invitation.", true, "Alfred Masekwameng");
            Console.WriteLine(post1.ToString());

            Image image1 = new Image("Check out my new shoes", 
                "Alfred Masekwameng", "https://google.com/shoes", true);
            Console.WriteLine(image1.ToString());

            Video video1 = new Video("C# Tutorial for intermediate", "Alfred Masekwameng", "http://google.com/video/12", 5, true);
            Console.WriteLine(video1.ToString());

            video1.Play();
            Console.WriteLine("Press space key to stop the video");
              
            Console.ReadKey();
            video1.Stop();

            Console.ReadKey();


        }
    }
}
