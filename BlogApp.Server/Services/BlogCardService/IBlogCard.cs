namespace BlogApp.Server.Services.BlogCardService
{
    public interface IBlogCard
    {
        Task<List<Card>> GetCardsAsync();
    }
}
