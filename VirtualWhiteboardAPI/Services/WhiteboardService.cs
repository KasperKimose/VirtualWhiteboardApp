using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VirtualWhiteboardAPI.Models;
using VirtualWhiteboardAPI.Models.DataAccess;
using VirtualWhiteboardAPI.Models.DTO.Post;

namespace VirtualWhiteboardAPI.Services
{
    public class WhiteboardService : IWhiteboardService
    {
        private readonly VirtualWhiteboardContext _context;

        private readonly IAccountService _accountService;
        private readonly ITeamService _teamService;

        public WhiteboardService(
            VirtualWhiteboardContext context,
            IAccountService accountService,
            ITeamService teamService
            )
        {
            _context = context;
            _accountService = accountService;
            _teamService = teamService;
        }

        public IEnumerable<Post> Get(IEnumerable<Claim> claims)
        {
            var user = _accountService.GetUserByClaims(claims);
            var team = _teamService.Get(user.MemberOf.Id);
            return Get(team.Whiteboard.Id).Posts;
        }

        public Whiteboard Get(int id)
        {
            return _context.Whiteboards
                .Include(w => w.Posts)
                .FirstOrDefault(w => w.Id == id);
        }

        public Post CreatePost(IEnumerable<Claim> claims, CreatePostDTO postDTO)
        {
            var user = _accountService.GetUserByClaims(claims);
            var team = _teamService.Get(user.MemberOf.Id);
            var whiteboard = team.Whiteboard;
            var post = new Post
            {
                PostedBy = user,
                Content = postDTO.Content,
                Created = DateTime.Now,
                PostedOn = whiteboard
            };

            _context.Posts.Add(post);
            _context.SaveChanges();
            return post;
        }
    }
}
