using Norbs.Core.Contexts;
using Norbs.Models.Generated;

namespace Norbs.Core.ViewModels.Pages
{
    public class NavAboutRareDiseasesViewModel : PageViewModel
    {

        public NavAboutRareDiseasesViewModel(IPageContext<NavAboutRareDiseases> context) : base(context)
        {
            this.Title = context.Page.PageTitle;
        }

        public string Title { get; set; }
    }
}
