// CardDetailController.cs
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Server.Models;
using BlogApp.Server.Services.BlogCardService;

namespace BlogApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardDetailController : ControllerBase
    {
        private readonly IBlogCardDetail _blogCardDetailService;

        public CardDetailController(IBlogCardDetail blogCardDetailService)
        {
            _blogCardDetailService = blogCardDetailService;
        }

        [HttpGet("{cardId}")]
        public async Task<ActionResult<CardDetail>> GetCardDetail(int cardId)
        {
            var cardDetail = await _blogCardDetailService.GetCardDetailAsync(cardId);
            if (cardDetail == null)
            {
                return NotFound();
            }
            return cardDetail;
        }
    }
}
