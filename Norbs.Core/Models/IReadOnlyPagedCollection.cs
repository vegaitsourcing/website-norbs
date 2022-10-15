using System.Collections.Generic;

namespace Norbs.Core.Models
{
	public interface IReadOnlyPagedCollection<out T>
	{
		IReadOnlyList<T> Items { get; }
		IPagination Pagination { get; }
	}
}
