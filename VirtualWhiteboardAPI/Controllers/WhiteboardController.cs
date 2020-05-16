using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtualWhiteboardAPI.Services;

namespace VirtualWhiteboardAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WhiteboardController : ControllerBase
    {
        private readonly IWhiteboardService _whiteboardService;

        public WhiteboardController(IWhiteboardService whiteboardService)
        {
            _whiteboardService = whiteboardService;
        }
    }
}