using System.Collections.Generic;

namespace Norbs.Core.ViewModels.Partials.Listing
{
    public class ActivitiesListViewModel
    {
        public IEnumerable<ActivityCategory> Categories { get; set; }

        public IEnumerable<ActivityItem> Items { get; set; }
    }

    public class ActivityItem
    {
        public string Title { get; set; }

        public string Url { get; set;
        }
    }

    public class ActivityCategory
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
