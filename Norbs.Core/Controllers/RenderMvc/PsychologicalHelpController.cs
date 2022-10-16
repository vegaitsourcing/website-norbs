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
    public class PsychologicalHelpController : BasePageController<PsychologicalHelp>
    {
        public ActionResult Index(PsychologicalHelp model)
            => CurrentTemplate(new PsychologicalHelpViewModel(CreatePageContext(model)));
    }
}
