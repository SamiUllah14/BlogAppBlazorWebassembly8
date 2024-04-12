
namespace BlogApp.Client.Services.BlogCardDetailService
{
    public interface IBlogCardDetail
    {
        Task<CardDetail> GetCardDetailAsync(int cardId);

    }
}
