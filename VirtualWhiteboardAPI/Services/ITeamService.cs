using System.Collections.Generic;
using VirtualWhiteboardAPI.Models;
using VirtualWhiteboardAPI.Models.DTO.Team;

namespace VirtualWhiteboardAPI.Services
{
    public interface ITeamService
    {
        bool Create(CreateTeamDTO teamDTO);
        Team Get(int id);
    }
}
