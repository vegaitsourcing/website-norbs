using Norbs.Models.Generated;

namespace Norbs.Core.Contexts
{
	public interface IPageContext<out T> : ISiteContext where T : class, IPage
	{
		T Page { get; }
	}
}
