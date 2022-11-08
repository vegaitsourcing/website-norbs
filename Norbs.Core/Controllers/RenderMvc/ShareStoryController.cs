using Norbs.Core.ViewModels.Pages;
using Norbs.Models.Generated;
using System.Web.Mvc;

namespace Norbs.Core.Controllers.RenderMvc
{
    public class ShareStoryController : BasePageController<ShareStory>
    {
        public ActionResult Index(ShareStory model)
            => CurrentTemplate(new ShareStoryViewModel(CreatePageContext(model)));
    }
}