using Norbs.Core.Contexts;
using Norbs.Models.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbs.Core.ViewModels.Pages
{
    public class PsychologicalHelpViewModel : PageViewModel
    {
        public PsychologicalHelpViewModel(IPageContext<PsychologicalHelp> context) : base(context)
        {
            Modules = context.Page.Module.OfType<IINestedContent>();
        }

        public IEnumerable<IINestedContent> Modules { get; }
    }
}

