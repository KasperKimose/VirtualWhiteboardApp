using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VirtualWhiteboardAPI.Models.DTO.Post;
using VirtualWhiteboardAPI.Services;

namespace VirtualWhiteboardAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WhiteboardController : ControllerBase
    {
        private readonly IWhiteboardService _whiteboardService;
        private readonly IMapperService _mapperService;

        public WhiteboardController(IWhiteboardService whiteboardService, IMapperService mapperService)
        {
            _whiteboardService = whiteboardService;
            _mapperService = mapperService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var posts = _whiteboardService.Get(User.Claims);
            return Ok(_mapperService.Map(posts));
        }

        [HttpPost]
        public IActionResult Post(CreatePostDTO postDTO)
        {
            var post = _whiteboardService.CreatePost(User.Claims, postDTO);
            return Ok(post.Id);
        }
    }
}