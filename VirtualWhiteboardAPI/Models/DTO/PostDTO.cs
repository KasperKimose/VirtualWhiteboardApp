using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualWhiteboardAPI.Models.DTO
{
    public class PostDTO
    {
        public int WhiteboardId { get; set; }
        public string Content { get; set; }
    }
}
