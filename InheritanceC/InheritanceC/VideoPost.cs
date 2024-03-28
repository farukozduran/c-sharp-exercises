using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class VideoPost : Post
    {

        //member fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;


        public string VideoURL { get; set; }

        public int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // Property ImageURL is a member of ImagePost, but not of post
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
        }

        private void TimerCallback(Object o)
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
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currentDuration);
                currentDuration = 0;
                timer.Dispose();
            }
            
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} -- by {3} -- {4}", 
                this.ID, this.Title, this.Length, this.SendByUsername, this.VideoURL);
        }
    }
}
