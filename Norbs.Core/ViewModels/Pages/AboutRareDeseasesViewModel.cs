using Norbs.Core.Contexts;
using Norbs.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Norbs.Core.ViewModels.Pages
{
	public class AboutRareDeseasesViewModel : PageViewModel
	{
		public AboutRareDeseasesViewModel(IPageContext<AboutRareDeseases> context) : base(context)
		{
			Modules = context.Page.Module.OfType<IINestedContent>();
		}

		public IEnumerable<IINestedContent> Modules { get; }
	}
}
