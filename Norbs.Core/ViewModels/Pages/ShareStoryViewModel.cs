using Norbs.Core.Contexts;
using Norbs.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Norbs.Core.ViewModels.Pages
{
    public class ShareStoryViewModel : PageViewModel
    {
        public ShareStoryViewModel(IPageContext<ShareStory> context) : base(context)
        {
            Modules = context.Page.NCshareStory.OfType<IINestedContent>();
            this.Title = context.Page.PageTitle;
        }

        public string Title { get; set; }
        public IEnumerable<IINestedContent> Modules { get; }
    }
}