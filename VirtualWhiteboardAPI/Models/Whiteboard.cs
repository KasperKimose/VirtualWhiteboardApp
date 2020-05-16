﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualWhiteboardAPI.Models
{
    public class Whiteboard
    {
        public int Id { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
