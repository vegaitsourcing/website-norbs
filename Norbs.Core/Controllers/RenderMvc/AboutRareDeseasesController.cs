using System.Web.Mvc;
using Norbs.Core.ViewModels.Pages;
using Norbs.Models.Generated;

namespace Norbs.Core.Controllers.RenderMvc
{
	public class AboutRareDeseasesController : BasePageController<AboutRareDeseases>
	{
		public ActionResult Index(AboutRareDeseases model) 
			=> CurrentTemplate(new AboutRareDeseasesViewModel(CreatePageContext(model)));
	}
}
