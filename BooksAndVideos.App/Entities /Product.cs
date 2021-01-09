namespace BooksAndVideos.App.Entities
{
    public class Product : Entity
    {
        public string Title {get; set;}

        public boolean IsBook {get; set;}

        public boolean IsVideo {get; set;}

        public double Price {get; set;}

    }
}
