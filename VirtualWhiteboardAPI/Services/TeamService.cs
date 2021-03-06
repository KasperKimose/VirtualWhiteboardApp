﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using VirtualWhiteboardAPI.Helpers;
using VirtualWhiteboardAPI.Models;
using VirtualWhiteboardAPI.Models.DataAccess;
using VirtualWhiteboardAPI.Models.DTO.Team;

namespace VirtualWhiteboardAPI.Services
{
    public class TeamService : ITeamService
    {
        private readonly VirtualWhiteboardContext _context;

        public TeamService(VirtualWhiteboardContext context)
        {
            _context = context;
        }

        public bool Create(CreateTeamDTO teamDTO)
        {
            var team = _context.Teams.FirstOrDefault(t => t.Name.Equals(teamDTO.Name));
            if (team != null)
            {
                return false;
            }
            var whiteboard = new Whiteboard
            {
                Posts = new List<Post>()
            };
            team = new Team
            {
                Name = teamDTO.Name,
                Members = new List<User>(),
                Whiteboard = whiteboard
            };
            _context.Teams.Add(team);
            if(_context.SaveChanges() == 0)
            {
                return false;
            }

            return true;
        }

        public Team Get(int id)
        {
            var team =  _context.Teams
                .Include(t => t.Whiteboard)
                .FirstOrDefault(t => t.Id == id);
            if(team == null)
            {
                throw new MyAPIException(HttpStatusCode.BadRequest, "The team could not be found");
            }
            return team;
        }
    }
}
