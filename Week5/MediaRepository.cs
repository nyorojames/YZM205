using System.Reflection;

namespace Week5
{
    public class MediaRepository
    {
        private List<Media> medias;
        public MediaRepository()
        {
            this.medias = new List<Media>();
        }
        public void Add(Media media)
        {
            this.medias.Add(media);
        }
        public List<Media> ListAll() => medias;
        public void SortByDuration()
        {
            medias.Sort();
        }
        public void SortByTitle()
        {
            medias = medias.OrderBy(m => m.Title).ToList();
        }
        public Media Find(string title)
        {
            foreach (var media in medias)
            {
                if (media.Title == title)
                {
                    return media;
                }
            }
            throw new Exception("Media not found");
        }
        public void Remove(int id)
        {
            foreach (var media in medias)
            {
                if (media.Id == id)
                {
                    medias.Remove(media);
                    return;
                }
            }
        }

        public void Update(int id, Media media)
        {
            if (medias.Count == 0)
            {
                throw new Exception("No media found");
            }
            foreach (var m in medias)
            {
                if (m.Id == id)
                {
                    m.Title = media.Title;
                    m.Duration = media.Duration;
                    return;
                }
            }
        }
    }

