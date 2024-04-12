using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogCard _IBlogCard;

        public BlogController(IBlogCard IBlogCard)
        {
            _IBlogCard = IBlogCard;
        }


        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetBlogCards()
        {
            var result = await _IBlogCard.GetCardsAsync();
            return Ok(result);
        }



    }
}
