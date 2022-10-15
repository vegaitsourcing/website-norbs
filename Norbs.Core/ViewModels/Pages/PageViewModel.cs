﻿using System;
using Norbs.Core.Contexts;
using Norbs.Core.Extensions;
using Norbs.Core.ViewModels.Partials.Layout;
using Norbs.Models.Generated;

namespace Norbs.Core.ViewModels.Pages
{
	public class PageViewModel
	{
		public PageViewModel(IPageContext<IPage> context)
		{
			if (context == null) throw new ArgumentNullException(nameof(context));

			MetaTagsLazy = new Lazy<MetaTagsViewModel>(() => new MetaTagsViewModel(context.CreateSeoContext(context.Page)));
			OpenGraphLazy = new Lazy<OpenGraphViewModel>(() => new OpenGraphViewModel(context, context.Page));
			HeaderLazy = new Lazy<HeaderViewModel>(() => new HeaderViewModel(context.Home));
			FooterLazy = new Lazy<FooterViewModel>(() => new FooterViewModel(context.Home));
			CookieScriptLazy = new Lazy<string>(() => context.Home.CookieScript);
			GoogleTagManagerScriptCodeLazy = new Lazy<string>(() => context.Home.GoogleTagManagerScriptCode);
			GoogleTagManagerNonScriptCodeLazy = new Lazy<string>(() => context.Home.GoogleTagManagerNonScriptCode);
			GoogleAnalyticsCodeLazy = new Lazy<string>(() => context.Home.GoogleAnalyticsScriptCode);
		}

		public MetaTagsViewModel MetaTags => MetaTagsLazy.Value;
		public OpenGraphViewModel OpenGraph => OpenGraphLazy.Value;
		public HeaderViewModel Header => HeaderLazy.Value;
		public FooterViewModel Footer => FooterLazy.Value;

		public string CookieScript => CookieScriptLazy.Value;
		public string GoogleTagManagerScriptCode => GoogleTagManagerScriptCodeLazy.Value;
		public string GoogleTagManagerNonScriptCode => GoogleTagManagerNonScriptCodeLazy.Value;
		public string GoogleAnalyticsCode => GoogleAnalyticsCodeLazy.Value;

		private Lazy<MetaTagsViewModel> MetaTagsLazy { get; }
		private Lazy<OpenGraphViewModel> OpenGraphLazy { get; }
		private Lazy<HeaderViewModel> HeaderLazy { get; }
		private Lazy<FooterViewModel> FooterLazy { get; }
		
		private Lazy<string> CookieScriptLazy { get; }
		private Lazy<string> GoogleTagManagerScriptCodeLazy { get; }
		private Lazy<string> GoogleTagManagerNonScriptCodeLazy { get; }
		private Lazy<string> GoogleAnalyticsCodeLazy { get; }
	}
}
