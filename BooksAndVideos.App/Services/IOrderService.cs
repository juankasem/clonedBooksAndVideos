using BooksAndVideos.App.Entities;

namespace BooksAndVideos.App.Services
{
    public interface IOrderService
    {
        void Process(Order order);
    }
}
