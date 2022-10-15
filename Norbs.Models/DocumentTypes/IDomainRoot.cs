﻿using Umbraco.Core.Models.PublishedContent;

namespace Norbs.Models.DocumentTypes
{
	/// <summary>
	///	Marks document type model class that Site domain will be associated with.
	/// </summary>
	public interface IDomainRoot : IPublishedContent
	{
	}
}
