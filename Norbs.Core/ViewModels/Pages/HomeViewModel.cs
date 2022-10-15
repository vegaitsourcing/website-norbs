using Norbs.Core.Contexts;
using Norbs.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Norbs.Core.ViewModels.Pages
{
	public class HomeViewModel : PageViewModel
	{
		public HomeViewModel(IPageContext<Home> context) : base(context)
		{
			Modules = context.Page.Modules.OfType<IINestedContent>();
		}

		public IEnumerable<IINestedContent> Modules { get; }
	}
}
