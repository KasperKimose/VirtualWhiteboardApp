using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtualWhiteboardAPI.Models.DTO;
using VirtualWhiteboardAPI.Services;

namespace VirtualWhiteboardAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WhiteboardController : ControllerBase
    {
        private readonly IWhiteboardService _whiteboardService;


        public WhiteboardController(
            IWhiteboardService whiteboardService
            )
        {
            _whiteboardService = whiteboardService;
        }

        [HttpPost]
        public IActionResult Post(PostDTO postDTO)
        {
            _whiteboardService.CreatePost(User.Claims, postDTO);
            return Ok();
        }
    }
}