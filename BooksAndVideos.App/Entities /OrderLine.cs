namespace BooksAndVideos.App.Entities
{
   public class OrderLine : Entity
    {  
        [ForeignKey]
        public int OrderId {get; set;}

        public virtual Order Order {get; set;}

        [ForeignKey]
        public int? ProductId {get; set;}

        public virtual Product Product {get; set;}

        public bool BookMembership {get; set;}

        public bool VideoMembership {get; set;}
    }
}

