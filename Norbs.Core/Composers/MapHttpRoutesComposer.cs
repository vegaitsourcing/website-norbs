using System.Web.Http;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Norbs.Core.Composers
{
    public class UmbracoComponents
    {
        [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
        public class MapHttpRoutesComposer : ComponentComposer<MapHttpRoutesComponent>
        {
        }

        public void Compose(Composition composition)
        {
            composition.Components().Insert<MapHttpRoutesComponent>();
        }

        public class MapHttpRoutesComponent : IComponent
        {
            // initialize: runs once when Umbraco starts
            public void Initialize()
            {
                GlobalConfiguration.Configuration.MapHttpAttributeRoutes();
                GlobalConfiguration.Configuration.Initializer(GlobalConfiguration.Configuration);
                GlobalConfiguration.Configuration.EnsureInitialized();
            }

            public void Terminate()
            {
            }
        }
    }
}