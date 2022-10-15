using Umbraco.Web.Mvc;
using Norbs.Core.Contexts;
using Norbs.Core.Extensions;
using Norbs.Models.Generated;

namespace Norbs.Core.Controllers.RenderMvc
{
	public abstract class BasePageController<T> : RenderMvcController where T : class, IPage
	{
		protected IPageContext<T> CreatePageContext(T page) => Umbraco.CreatePageContext(page);
	}
}
