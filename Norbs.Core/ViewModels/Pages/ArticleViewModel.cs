using Norbs.Core.Contexts;
using Norbs.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Norbs.Core.ViewModels.Pages
{
	public class ArticleViewModel : PageViewModel
	{
		public ArticleViewModel(IPageContext<Article> context) : base(context)
		{
		}

		public IEnumerable<IINestedContent> Modules { get; }
	}
}
