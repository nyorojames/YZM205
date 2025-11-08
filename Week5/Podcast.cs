using System.Reflection;

namespace Week5
{
    public class  Podcast : Media
    {
        public Host Host;
        public Podcast(string title, float duration, Host host)
            :base(title, duration)
        {   
            Host = host; 
        }
        public override void Play()
        {
            Console.WriteLine($"Playing Podcast {Title} hosted by {Host}");
        }
    }
}

