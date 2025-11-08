namespace Week5
{
    public class Song : Media
    {
        public Artist Artist;
        public Song(int id, string title, float duration, Artist artist)
            :base(id, title, duration)
        {
            Artist = artist;
        }
        public override void Play()
        {
            Console.WriteLine($"Playing Song: {Title} by {Artist}");
        }
    }

}
