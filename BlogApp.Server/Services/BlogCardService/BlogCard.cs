using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Server.Data;
using BlogApp.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Server.Services.BlogCardService
{
    public class BlogCard : IBlogCard
    {
        private readonly DatabaseContext _databaseContext;

        public BlogCard(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

     
        public async Task<List<Card>> GetCardsAsync()
        {
            return await _databaseContext.Cards.ToListAsync();
        }
    }
}
