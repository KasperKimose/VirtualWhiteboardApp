using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualWhiteboardAPI.Models.DTO.Post
{
    public class CreatePostDTO
    {
        [Required]
        public string Content { get; set; }
    }
}
