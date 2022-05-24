

namespace Proxy
{
    public class ProxyYouTubeService : IYoutubeService
    {
        private YouTubeService _youTubeService;

        private Dictionary<int, byte[]> _cache = new Dictionary<int, byte[]>();

        public ProxyYouTubeService(YouTubeService youTubeService)
        {
            _youTubeService = youTubeService;
        }

        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"ProxyYouTubeService getting {videoId}");

            byte[] cachedVideo;
            if (_cache.TryGetValue(videoId, out cachedVideo))
            {
                Console.WriteLine($"Getting from cache {videoId}");
                return cachedVideo;
            }

            var video = _youTubeService.GetVideo(videoId);
            _cache.Add(videoId, video);

            return video;
        }
    }
}