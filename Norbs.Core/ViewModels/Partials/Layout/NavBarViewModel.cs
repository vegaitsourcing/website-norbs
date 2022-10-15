using Norbs.Core.Extensions;
using Norbs.Core.ViewModels.Shared;
using Norbs.Models.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbs.Core.ViewModels.Partials.Layout
{
    public class NavBarViewModel
    {
        public NavBarViewModel(NavBar model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            LogoNorbs = model.LogoNorbs?.ToViewModel();
        }

        public ImageViewModel LogoNorbs { get; set; }
    }
}
