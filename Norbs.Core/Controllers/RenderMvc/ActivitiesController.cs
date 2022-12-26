using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Norbs.Core.ViewModels.Pages;
using Norbs.Core.ViewModels.Partials.Listing;
using Norbs.Models.Generated;
using Umbraco.Web;

namespace Norbs.Core.Controllers.RenderMvc
{
    public class ActivitiesController : BasePageController<Activities>
    {
        public ActionResult Index(Activities model)
        {
            var tags = model?.Children.DescendantsOrSelfOfType(Tags.ModelTypeAlias)
                .FirstOrDefault()?.Children.DescendantsOrSelfOfType(Tag.ModelTypeAlias);

            var activities = tags?.FirstOrDefault().Children;

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
                    IsActive = tags.FirstOrDefault().Name.Equals(tag.Name)
                })

            };

            return CurrentTemplate(new ActivitiesViewModel(CreatePageContext(model), listViewModel));

        }
    }
}