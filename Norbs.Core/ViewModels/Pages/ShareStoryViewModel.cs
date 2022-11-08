using Norbs.Core.Contexts;
using Norbs.Models.Generated;

namespace Norbs.Core.ViewModels.Pages
{
    public class ShareStoryViewModel : PageViewModel
    {
        public ShareStoryViewModel(IPageContext<ShareStory> context) : base(context)
        {
            this.Title = context.Page.PageTitle;
        }

        public string Title { get; set; }
    }
}