namespace BooksAndVideos.App.Entities
{
    public class Order : Entity
    {
         public int CustomerId {get; set;}

         public Customer Customer {get; set;}

         public double TotalPrice {get; set;}

         public ICollection<OrderLine> OrderLines {get; set;}
    }
}
