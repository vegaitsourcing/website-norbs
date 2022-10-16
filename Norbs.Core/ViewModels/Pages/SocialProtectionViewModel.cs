using Norbs.Core.Contexts;
using Norbs.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Norbs.Core.ViewModels.Pages
{
    public class SocialProtectionViewModel : PageViewModel
    {
        public SocialProtectionViewModel(IPageContext<SocialProtection> context) : base(context)
        {
            Modules = context.Page.Module.OfType<IINestedContent>();
        }

        public IEnumerable<IINestedContent> Modules { get; }
    }
}