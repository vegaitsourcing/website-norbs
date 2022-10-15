using System.Web.Mvc;
using Norbs.Core.ViewModels.Pages;
using Norbs.Models.Generated;

namespace Norbs.Core.Controllers.RenderMvc
{
	public class AboutUsController : BasePageController<AboutUs>
	{
		public ActionResult Index(AboutUs model) 
			=> CurrentTemplate(new AboutUsViewModel(CreatePageContext(model)));
	}
}
