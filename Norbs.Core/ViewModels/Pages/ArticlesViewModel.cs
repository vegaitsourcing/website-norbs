using Norbs.Core.Contexts;
using Norbs.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Norbs.Core.ViewModels.Pages
{
	public class ArticlesViewModel : PageViewModel
	{
		public ArticlesViewModel(IPageContext<Articles> context) : base(context)
		{
			Modules = context.Page.Modules.OfType<IINestedContent>();
			Tabs = context.Page.Children.OfType<Tags>().FirstOrDefault()
				.Children.OfType<Tag>()
				.Select(t => t.Name);
		}

		public IEnumerable<IINestedContent> Modules { get; }
		public IEnumerable<string> Tabs { get; }
	}

}
