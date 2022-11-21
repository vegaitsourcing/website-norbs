using Norbs.Models.Generated;
using System.Linq;
using System.Web.Http;
using Umbraco.Web;
using System.Web.Mvc;
using Norbs.Core.ViewModels.Partials.Listing;

namespace Norbs.Core.Controllers.Surface.Partials
{
    public class ActivitiesListController : BaseSurfaceController
    {

        public ActionResult GetArticlesForTag([FromUri] string tagName)
        {
            var tags = UmbracoContext.Content.GetAtRoot("Home").FirstOrDefault()
                ?.Children<Activities>().FirstOrDefault()
                ?.Children<Tags>().FirstOrDefault()
                ?.Children<Tag>();

            var activities = tags?.FirstOrDefault(tag => tag.Name.Equals(tagName))?.Children<Activity>();


            if (activities == null)
            {
                return null;
            }


            var listViewModel = new ActivitiesListViewModel()
            {
                Items = activities.Select(activity => new ActivityItem()
                {
                    Title = activity.Name,
                    Url = activity.Url()
                }),
                Categories = tags.Select(tag => new ActivityCategory()
                {
                    Name = tag.Name,
                    IsActive = tag.Name.Equals(tagName)
                })
            };

            return PartialView("~/Views/Partials/Modules/ActivitiesListModule.cshtml", listViewModel);
        }
    }
}
