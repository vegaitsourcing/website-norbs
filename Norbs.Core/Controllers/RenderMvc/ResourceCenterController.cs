using System.Web.Mvc;
using Norbs.Core.ViewModels.Pages;
using Norbs.Models.Generated;

namespace Norbs.Core.Controllers.RenderMvc
{
    public class ResourceCenterController : BasePageController<ResourceCenter>
    {
        public ActionResult Index(ResourceCenter model)
            => CurrentTemplate(new ResourceCenterViewModel(CreatePageContext(model)));
    }
}
