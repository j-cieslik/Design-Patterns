

namespace Proxy
{
    public class YouTubeService : IYoutubeService
    {
        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"Youtube service downloading video: {videoId}");

            return new byte[videoId];
        }
    }
}