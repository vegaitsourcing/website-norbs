using Norbs.Core.Contexts;
using Norbs.Core.ViewModels.Partials.Listing;
using Norbs.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Norbs.Core.ViewModels.Pages
{
    public class ActivitiesViewModel : PageViewModel
    {
        public ActivitiesViewModel(IPageContext<Activities> context, ActivitiesListViewModel activitiesListViewModel) : base(context)
        {
            Modules = context.Page.Module.OfType<IINestedContent>();
            ActivitiesListViewModel = activitiesListViewModel;
        }

        public IEnumerable<IINestedContent> Modules { get; }

        public ActivitiesListViewModel ActivitiesListViewModel { get; set; }
    }
}
