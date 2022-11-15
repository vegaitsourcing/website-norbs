using Norbs.Core.Contexts;
using Norbs.Models.Generated;

namespace Norbs.Core.ViewModels.Pages
{
    public class NavAboutUsViewModel : PageViewModel
    {

        public NavAboutUsViewModel(IPageContext<NavAboutUs> context) : base(context)
        {
            this.Title = context.Page.PageTitle;
        }

        public string Title { get; set; }
    }
}
