using System.Net.Http;
using System.Threading.Tasks;
using BlogApp.Client.Models;
using BlogApp.Client.Services.BlogCardDetailService;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json; // Add this line


namespace BlogApp.Client.Services
{
    public class BlogCardDetail : IBlogCardDetail
    {
        private readonly HttpClient _httpClient;

        public BlogCardDetail(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CardDetail> GetCardDetailAsync(int cardId)
        {
            return await _httpClient.GetFromJsonAsync<CardDetail>($"api/CardDetail/{cardId}");
        }

    }
}