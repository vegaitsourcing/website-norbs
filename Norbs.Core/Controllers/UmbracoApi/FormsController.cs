using Norbs.Core.Models.Api;
using System.Web.Http;
using Norbs.Core.Services;
using Umbraco.Web.WebApi;

namespace Norbs.Core.Controllers.UmbracoApi
{
    public class FormsController : UmbracoApiController
    {
        [HttpPost]
        [Route("forms/sharestory")]
        public bool ShareStory([FromBody] ShareStoryDTO shareStoryDto)
        {
            var templateMessage = $@"Ime: {shareStoryDto.FirstName} \n Prezime: {shareStoryDto.LastName} \n Telefon: {shareStoryDto.Telephone} \n Email: {shareStoryDto.Email} \n Priča: {shareStoryDto.Story}";
            EmailService.SendEmail(shareStoryDto.Email, "Nova podeljena priča sa web sajta", templateMessage);
            return true;
        }
    }
}