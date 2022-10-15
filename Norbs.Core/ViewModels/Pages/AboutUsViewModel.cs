using Norbs.Core.Contexts;
using Norbs.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Norbs.Core.ViewModels.Pages
{
	public class AboutUsViewModel : PageViewModel
	{
		public AboutUsViewModel(IPageContext<AboutUs> context) : base(context)
		{
			Modules = context.Page.Modules.OfType<IINestedContent>();
		}

		public IEnumerable<IINestedContent> Modules { get; }
	}
}
