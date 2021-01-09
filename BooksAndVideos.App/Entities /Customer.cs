namespace BooksAndVideos.App.Entities
{
    public class Customer : Entity
    {
        public string Name  {get; set;}

        public boolean HasBookClubMembership  {get; set;}

        public boolean HasVideoClubMembership  {get; set;}

        public int Points  {get; set;}
    }
}
