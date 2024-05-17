using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    class Video: Post
    {
        // member fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;

        // To call timer
        Timer timer;

        protected string VideoUrl { get; set; }
        protected int Length { get; set; }

       

        // Default Constructor
        public Video() { }
        
        // Parameter Constructor
        public Video(string title, string sendByUsername, string videoUrl, int length, bool isPublic)
        {
            // Inherited properties
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // Member properties
            this.VideoUrl = videoUrl;
            this.Length = length;

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} minutes  by  {4}", this.ID, this.Title, this.VideoUrl, this.Length, this.SendByUsername);
        }

        

        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");

                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            

        }

        private void TimerCallback(object sender)
        {
            if(currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine("Video at {0}s", currentDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(isPlaying)
            {
                isPlaying= false;
                Console.WriteLine("Stopped at {0}s", currentDuration);
                currentDuration = 0;
                timer.Dispose();
            }

        }
    }
}
