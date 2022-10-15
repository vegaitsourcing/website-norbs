﻿using System.Text;
using Umbraco.Core;
using Norbs.Common.Extensions;

namespace Norbs.Search.Models
{
	internal class NestedContentIndexData
	{
		public string Title { get; set; }

		public string Text { get; set; }

		public string GetSearchableContent()
		{
			StringBuilder builder = new StringBuilder();

			builder.TryAppendLine(Title);
			builder.TryAppendLine(Text?.StripHtml());
			
			return builder.ToString();
		}
	}
}
