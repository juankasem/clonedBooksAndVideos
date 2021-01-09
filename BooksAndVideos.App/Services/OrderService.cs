using BooksAndVideos.App.Entities;
using System;

namespace BooksAndVideos.App.Services
{
    public class OrderService : IOrderService
    {
        var dbContext = new BooksAndVideosDbContext();

        public void Process(Order order)
        {
            var customer = dbContext.Customers.FirstOrDefault(c => c.Id == order.CustomerId);
            
            //OR1
            if (order.OrderLines.Any(orderLine => orderLine.BookMembership == true)){
                 customer.HasBookClubMembership = true;
            }

             if (order.OrderLines.Any(orderLine => orderLine.VideoMembership == true)){
                 customer.HasVideoClubMembership = true;
            }

            //OR2 
              if (order.OrderLines.Any(orderLine => orderLine.ProductId != null)){
                 GenerateShippingSlip(order);
            }

            //OR3
              if (order.OrderLines.Any(orderLine => orderLine.Product.Title == "“Mission Impossible 3")){
                 var product = dbContext.Products.FirstOrDefault(p => p.Title == "Mission Impossible 2");
                 
                 if(product){                   
                   var orderLine = new OrderLine(){
                      OrderId= order.Id,
                      ProductId = product.Id
                   }

                   order.OrderLines.Add(orderLine);

                   dbContext.OrderLines.Add(orderLine);
                   dbContext.SaveChanges();
                 }      
            }

            //OR4
              if (customer.HasBookClubMembership || orderLine.BookMembership)
              {
                   foreach (var orderLine in orderLines)
                   {
                       if (orderLine.ProductId != null && orderLine.Product.IsBook){
                           customer.Points += 5;
                       }
                   }  
              }

            //OR5
                if (customer.HasVideoClubMembership || orderLine.VideoMembership)
                {
                    foreach (var orderLine in orderLines)
                    {
                        if (orderLine.ProductId != null && orderLine.Product.IsVideo){
                            customer.Points += 5;
                        }
                    }  
                }
        }

        private void GenerateShippingSlip(Order order)
        {

        }
    }
}
