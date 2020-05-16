using System.Collections.Generic;
using VirtualWhiteboardAPI.Models.DTO.Team;

namespace VirtualWhiteboardAPI.Services
{
    public interface ITeamService
    {
        bool Create(CreateTeamDTO teamDTO);
    }
}
