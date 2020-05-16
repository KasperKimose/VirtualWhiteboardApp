using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualWhiteboardAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
        public User PostedBy { get; set; }
    }
}
