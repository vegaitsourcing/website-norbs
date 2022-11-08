using Norbs.Core.ViewModels.Shared;
using Norbs.Models.Extensions;
using Umbraco.Core.Models.PublishedContent;

namespace Norbs.Core.Models
{
    public class PublicationResource : BaseResource
    {
        public PublicationResource(IPublishedContent node)
        {

            Title = node.GetPropertyValue<string>("title");
            PublicationUrl = node.GetPropertyValue<IPublishedContent>("publicationDocument").Url;
            ThumbnailUrl = node.GetPropertyValue<IPublishedContent>("publicationImage").Url;
        }
        public string PublicationUrl { get; set; }

        public string ThumbnailUrl { get; set; }
    }
}