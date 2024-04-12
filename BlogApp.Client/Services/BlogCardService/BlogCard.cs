using BlogApp.Client.Models;
using System.Net.Http.Json;

namespace BlogApp.Client.Services.BlogCardService
{
    public class BlogCard : IBlogCard
    {
        private readonly HttpClient _httpClient;

        public BlogCard(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Card>> GetCardsAsync()
        {
            var BlogCardResponse = await _httpClient.GetFromJsonAsync<List<Card>>("api/blog/all");
            return BlogCardResponse ?? new List<Card>();

        }
    }
}
