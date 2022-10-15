using Norbs.Models.DocumentTypes;

namespace Norbs.Core.Contexts
{
	public interface ISeoContext<out T> : ISiteContext where T : class, ISeo
	{
		T Seo { get; }
	}
}
