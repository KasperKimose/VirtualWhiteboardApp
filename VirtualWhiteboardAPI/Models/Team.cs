
using System.Collections.Generic;

namespace VirtualWhiteboardAPI.Models
{
    public class Team
    {
        public int Id { get; set; }
        public IEnumerable<Person> Members { get; set; }
        public Whiteboard Whiteboard { get; set; }
    }
}
