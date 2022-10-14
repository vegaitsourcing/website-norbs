using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Norbs.Core.ViewModels.Pages;
using Norbs.Models.DocumentTypes;

namespace Norbs.Core.Controllers.RenderMvc
{
	public class XMLSitemapController : RenderMvcController
	{
		public ActionResult XMLSitemap(IDomainRoot model)
			=> CurrentTemplate(new XMLSitemapViewModel(model));
	}
}
