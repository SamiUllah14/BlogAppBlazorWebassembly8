namespace BlogApp.Server.Services.BlogCardDetailService
{
    public interface IBlogCardDetail
    {
        Task<CardDetail> GetCardDetailAsync(int cardId);

    }
}
