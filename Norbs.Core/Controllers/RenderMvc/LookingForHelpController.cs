using System.Web.Mvc;
using Norbs.Core.ViewModels.Pages;
using Norbs.Models.Generated;

namespace Norbs.Core.Controllers.RenderMvc
{
	public class LookingForHelpV2Controller : BasePageController<LookingForHelpV2>
	{
		public ActionResult Index(LookingForHelpV2 model) 
			=> CurrentTemplate(new LookingForHelpV2ViewModel(CreatePageContext(model)));
	}
}
