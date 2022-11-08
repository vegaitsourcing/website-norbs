using Norbs.Core.ViewModels.Pages;
using Norbs.Models.Generated;
using System.Web.Mvc;

namespace Norbs.Core.Controllers.RenderMvc
{
    public class ContactPageController : BasePageController<ContactPage>
    {
        public ActionResult Index(ContactPage model)
            => CurrentTemplate(new ContactPageViewModel(CreatePageContext(model)));
    }
}