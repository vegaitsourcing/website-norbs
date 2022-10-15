using System;
using Norbs.Models.Generated;

namespace Norbs.Core.ViewModels.Partials.Layout
{
	public class FooterViewModel
	{
		public FooterViewModel(IFooter footer)
		{
			if (footer == null) throw new ArgumentNullException(nameof(footer));

			CopyrightText = footer.CopyrightText;
		}

		public string CopyrightText { get; }
	}
}
