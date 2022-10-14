using Norbs.Models.Generated;

namespace Norbs.Models.Extensions
{
	public static class PageExtensions
	{
		public static string PageTitle(this IPage page)
		{
			return page.GetPropertyWithDefaultValue(page.Name);
		}

		public static bool IsHome(this IPage page)
		{
			return false;
			//return page.ContentType.Alias == Home.ModelTypeAlias;
		}
	}
}
