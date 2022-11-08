using System;
using System.Web;
using Norbs.Models.Extensions;
using Umbraco.Core.Models.PublishedContent;

namespace Norbs.Core.Models
{
    public class VideoResource : BaseResource
    {
        public VideoResource(IPublishedContent node)
        {
            Title = node.GetPropertyValue<string>("title");
            VideoUrl = node.GetPropertyValue<string>("videoLink");
        }

        public string VideoUrl { get; set; }

        public string EmbedUrl
        {
            get
            {
                try
                {
                    var url = new Uri(VideoUrl);
                    var queryParams = HttpUtility.ParseQueryString(url.Query);
                    var videoId = queryParams["v"];
                    return $"https://www.youtube.com/embed/{videoId}";
                }
                catch
                {
                    return "";
                }
            }
        }
    }
}