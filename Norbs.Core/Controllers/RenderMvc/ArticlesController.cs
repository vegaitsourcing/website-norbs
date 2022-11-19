using System.Web.Mvc;
using Norbs.Core.ViewModels.Pages;
using Norbs.Models.Generated;

namespace Norbs.Core.Controllers.RenderMvc
{
	public class ArticlesController : BasePageController<Articles>
	{
		public ActionResult Index(Articles model) 
			=> CurrentTemplate(new ArticlesViewModel(CreatePageContext(model)));
	}
}
