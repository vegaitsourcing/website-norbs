﻿using System;
using Norbs.Models.Generated;
using Norbs.Models.DocumentTypes;

namespace Norbs.Core.Contexts
{
	public class SeoContext<T> : ISeoContext<T> where T : class, ISeo
	{
		private readonly ISiteContext _siteContext;

		public SeoContext(T seo, ISiteContext siteContext)
		{
			_siteContext = siteContext ?? throw new ArgumentNullException(nameof(siteContext));
			Seo = seo ?? throw new ArgumentNullException(nameof(seo));
		}

		public T Seo { get; }
		public IPage CurrentPage => _siteContext.CurrentPage;
		public Home Home => _siteContext.Home;
		public ISiteSettings SiteSettings => _siteContext.SiteSettings;
	}
}
