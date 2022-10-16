using Norbs.Core.ViewModels.Pages;
using Norbs.Models.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Norbs.Core.Controllers.RenderMvc
{
    public class LegalHelpController : BasePageController<LegalHelp>
    {
        public ActionResult Index(LegalHelp model)
            => CurrentTemplate(new LegalHelpViewModel(CreatePageContext(model)));
    }
}
