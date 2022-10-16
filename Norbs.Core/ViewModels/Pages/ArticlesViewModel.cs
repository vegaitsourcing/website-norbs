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
		}
	}
}
