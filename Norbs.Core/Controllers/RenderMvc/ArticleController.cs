using System.Web.Mvc;
using Norbs.Core.ViewModels.Pages;
using Norbs.Models.Generated;

namespace Norbs.Core.Controllers.RenderMvc
{
	public class ArticleController : BasePageController<Article>
	{
		public ActionResult Index(Article model) 
			=> CurrentTemplate(new ArticleViewModel(CreatePageContext(model)));
	}
}
