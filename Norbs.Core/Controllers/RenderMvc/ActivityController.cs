using Norbs.Core.ViewModels.Pages;
using Norbs.Models.Generated;
using System.Web.Mvc;

namespace Norbs.Core.Controllers.RenderMvc
{
    public class ActivityController : BasePageController<Activity>
    {
        public ActionResult Index(Activity model)
            => CurrentTemplate(new ActivityViewModel(CreatePageContext(model)));
    }
}
