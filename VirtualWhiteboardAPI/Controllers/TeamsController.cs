using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VirtualWhiteboardAPI.Models.DTO.Team;
using VirtualWhiteboardAPI.Services;

namespace VirtualWhiteboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpPost]
        public IActionResult CreateTeam(CreateTeamDTO teamDTO)
        {
            if (!_teamService.Create(teamDTO))
            {
                return BadRequest("The team could not be created");
            }
            return Ok();
        }
    }
}