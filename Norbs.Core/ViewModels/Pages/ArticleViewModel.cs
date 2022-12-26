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
			Modules = context.Page.Modules.OfType<IINestedContent>();
			Url = context.Page.Url;
			PreviewImageUrl = context.Page.PreviewImage.Url;
			Title = context.Page.PageTitle;
		}

		public IEnumerable<IINestedContent> Modules { get; }
		public string Url { get; }
		public string PreviewImageUrl { get; }
		public string Title { get; }	
	}
}