using System.Web.Mvc;
using Norbs.Core.ViewModels.Pages;
using Norbs.Models.Generated;

namespace Norbs.Core.Controllers.RenderMvc
{
    public class SocialProtectionController : BasePageController<SocialProtection>
    {
        public ActionResult Index(HealthProtection model)
            => CurrentTemplate(new HealthProtectionViewModel(CreatePageContext(model)));
    }
}
