using Norbs.Models.Generated;

namespace Norbs.Core.Contexts
{
	public interface ISiteContext
	{
		IPage CurrentPage { get; }
		Home Home { get; }
		ISiteSettings SiteSettings { get; }
	}
}
