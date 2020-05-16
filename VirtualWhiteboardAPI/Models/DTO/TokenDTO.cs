

namespace VirtualWhiteboardAPI.Models.DTO
{
    public class TokenDTO
    {
        public string AccessToken { get; set; }
        public int Valid { get; set; } = 24 * 60 * 60 * 1000; // 1 day in ms
    }
}
