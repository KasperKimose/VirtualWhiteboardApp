using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWhiteboardAPI.Models.DataAccess;

namespace VirtualWhiteboardAPI.Services
{
    public class WhiteboardService : IWhiteboardService
    {
        private readonly VirtualWhiteboardContext _context;

        public WhiteboardService(VirtualWhiteboardContext context)
        {
            _context = context;
        }
    }
}
