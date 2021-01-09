namespace BooksAndVideos.App.Entities
{
   public class OrderLine : Entity
    {  
        public int OrderId {get; set;}

        public Order Order {get; set;}

        public int? ProductId {get; set;}

        public virtual Product Product {get; set;}

        public bool BookMembership {get; set;}

        public bool VideoMembership {get; set;}
    }
}

