using Norbs.Core.Contexts;
using Norbs.Core.Models;
using Norbs.Models.Generated;
using System.Collections.Generic;
using PublicationResource = Norbs.Models.Generated.PublicationResource;
using VideoResource = Norbs.Models.Generated.VideoResource;

namespace Norbs.Core.ViewModels.Pages
{
    public class ResourceCenterViewModel : PageViewModel
    {
        public ResourceCenterViewModel(IPageContext<ResourceCenter> context) : base(context)
        {
            this.Title = context.Page.PageTitle;
            this.Children = new List<BaseResource>();
            foreach (var node in context.Page.Children)
            {
                if (node.ContentType.Alias == VideoResource.ModelTypeAlias)
                {
                    this.Children.Add(new Models.VideoResource(node));
                }

                if (node.ContentType.Alias == PublicationResource.ModelTypeAlias)
                {
                    this.Children.Add(new Models.PublicationResource(node));
                }
            }
        }

        public List<BaseResource> Children { get; set; }

        public string Title { get; set; }
    }
}