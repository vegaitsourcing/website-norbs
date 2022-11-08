using Norbs.Core.Contexts;
using Norbs.Models.Generated;

namespace Norbs.Core.ViewModels.Pages
{
    public class ContactPageViewModel : PageViewModel
    {
        public ContactPageViewModel(IPageContext<ContactPage> context) : base(context)
        {
            this.Title = context.Page.PageTitle;
            this.ContactDetails = context.Page.ContactDetails.ToHtmlString();
        }

        public string Title { get; set; }

        public string ContactDetails { get; set; }
    }
}