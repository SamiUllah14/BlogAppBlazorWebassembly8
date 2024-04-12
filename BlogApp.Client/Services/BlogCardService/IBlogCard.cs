using BlogApp.Client.Models;

namespace BlogApp.Client.Services.BlogCardService
{
    public interface IBlogCard
    {
        Task<List<Card>> GetCardsAsync();

    }
}
