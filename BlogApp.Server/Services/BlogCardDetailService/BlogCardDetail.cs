namespace BlogApp.Server.Services.BlogCardDetailService
{
    public class BlogCardDetail : IBlogCardDetail
    {
        private readonly DatabaseContext _databaseContext;

        public BlogCardDetail(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<CardDetail> GetCardDetailAsync(int cardId)
        {
            return await _databaseContext.CardDetails.FindAsync(cardId);
        }
    }
}
