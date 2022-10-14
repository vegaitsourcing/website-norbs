using Examine;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Web;
using Norbs.Search.Services;
using Norbs.Search.Services.Implementation;

namespace Norbs.Core.Composers
{
	public class SearchComposer : IUserComposer
	{
		public void Compose(Composition composition)
		{
			composition.RegisterFor<ISearchService, SearchService>(f => new SearchService(f.GetInstance<IExamineManager>(), f.GetInstance<IUmbracoContextAccessor>()));
		}
	}
}
