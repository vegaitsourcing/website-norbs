using System;
using Umbraco.Web;
using Norbs.Core.Extensions;
using Norbs.Core.ViewModels.Shared;
using Norbs.Models.Generated;
using System.Linq;
using System.Collections.Generic;

namespace Norbs.Core.ViewModels.Partials.Layout
{
	public class HeaderViewModel
	{
		public HeaderViewModel(IHeader header)
		{
			if (header == null) throw new ArgumentNullException(nameof(header));

			HeaderTitle = header.HeaderTitle;
			HeaderPhoneNumber = header.HeaderPhoneNumber;
			Facebookurl = header.FacebookUrl;
			TwitterUrl = header.TwitterUrl;
			YoutubeUrl = header.YoutubeUrl;

			Logo = header.Logo.TryCreateImageViewModel();
            NavigationItems = header.Children.OfType<IPage>()
			.Where(x => !x.UmbracoNaviHide)
			.Select(x => new NavigationPageViewModel(x))
			.ToList();

		}

		public ImageViewModel Logo { get; }
		public List<NavigationPageViewModel> NavigationItems { get; }
		public string HeaderTitle { get; }

        public string HeaderPhoneNumber { get; }
		public string Facebookurl { get; }
		public string TwitterUrl { get; }
		public string YoutubeUrl { get; }
    }

	public class NavigationPageViewModel
	{
		public NavigationPageViewModel(IPage x)
		{
			this.Title = x.Name;
			this.Url = x.Url();
			this.IsActive = true; //TODO: CHECK INDIAN TUTORIAL;
			this.Children = x.Children
				.OfType<IPage>()
				.ToList();
		}

		public string Url { get; }
		public string Title { get; }
		public bool IsActive { get; }
		public IEnumerable<IPage> Children { get; }
	}
}
