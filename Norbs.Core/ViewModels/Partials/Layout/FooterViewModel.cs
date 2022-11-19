using System;
using Norbs.Core.ViewModels.Shared;
using System.Collections.Generic;
using Norbs.Models.Generated;
using Umbraco.Web.Models;
using Norbs.Core.Extensions;
using System.Linq;

namespace Norbs.Core.ViewModels.Partials.Layout
{
	public class FooterViewModel
	{
		public FooterViewModel(IFooter footer)
		{
			if (footer == null) throw new ArgumentNullException(nameof(footer));

            FooterLogo = footer.FooterLogo.TryCreateImageViewModel();
            FooterDescription = footer.FooterDescription;
            FooterPhoneText = footer.FooterPhoneText;
            FooterPhoneNumber = footer.FooterPhoneNumber;
            FooterSocialLinksText = footer.FooterSocialLinksText;
            FooterFacebookLink = footer.FooterFacebookLink;
            FooterTwitterLink = footer.FooterTwitterLink;
            FooterYoutubeLink = footer.FooterYoutubeLink;
            FooterLinksBlocks = footer.LinksBlock.OfType<FooterLinksBlock>().ToList();
            FooterImagesBlocks = footer.ImagesBlock.OfType<FooterImagesBlock>().ToList();

        }

        public ImageViewModel FooterLogo { get; }
        public string FooterDescription { get; }
        public string FooterPhoneText { get;  }
        public string FooterPhoneNumber { get; }
        public string FooterSocialLinksText { get; }
        public Link FooterFacebookLink { get; }
        public Link FooterTwitterLink { get; }
        public Link FooterYoutubeLink { get; }
        public List<FooterLinksBlock> FooterLinksBlocks { get; }
        public List<FooterImagesBlock> FooterImagesBlocks { get; }

    }
}
