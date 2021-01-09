namespace BooksAndVideos.App.Entities
{
    public class Order : Entity
    {
        [ForeignKey]
         public int CustomerId {get; set;}

         public virtual Customer Customer {get; set;}

         public double TotalPrice {get; set;}

         public ICollection<OrderLine> OrderLines {get; set;}
    }
}
