using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VirtualWhiteboardAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }

        [ForeignKey("PostedBy_Id")] 
        public virtual User PostedBy { get; set; }

        [ForeignKey("PostedOn_Id")]
        public virtual Whiteboard PostedOn { get; set; }
    }
}
