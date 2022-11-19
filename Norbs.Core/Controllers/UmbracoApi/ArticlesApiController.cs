using Norbs.Models.Generated;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Umbraco.Web;
using Umbraco.Web.WebApi;

namespace Norbs.Core.Controllers.UmbracoApi
{
    public class ArticlesApiController : UmbracoApiController
    {
        private readonly IUmbracoContextFactory _context;

        public ArticlesApiController(IUmbracoContextFactory contextFactory)
        {
            _context = contextFactory;
        }

        [HttpGet]
        [Route("articles/getForTag")]
        public HttpResponseMessage GetArticlesForTag([System.Web.Http.FromUri] string tagName)
        {
            IEnumerable<Article> RelatedArticles = UmbracoContext.Content.GetAtRoot("Home").FirstOrDefault()
                ?.Children<Articles>().FirstOrDefault()
                ?.Children<Tags>().FirstOrDefault()
                ?.Children<Tag>().Where(tag => tag.Name.Equals(tagName)).FirstOrDefault()
                ?.Children<Article>();

            if(RelatedArticles == null)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
            }
            HttpResponseMessage Response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            StringBuilder SB = new StringBuilder();
            foreach (Article article in RelatedArticles)
            {
                SB.Append($@"
                    <a href = '{(string)article.Url()}' class='news-card'>
                        <div class='news-card__wrap'>
                            <div class='news-card__img'>
                                <img src = '{(string)article.PreviewImage?.Url() ?? ""}' alt='Preview image' class='news-card__img-item'>
                            </div>
                            <div class='news-card__content'>
                                <h3 class='h3 news-card__title'>{(string)article.PageTitle}</h3>
                                <span class='link link-small news-card__readmore'>Pročitaj više</span>
                            </div>
                        </div>
                    </a>
                ");
            }
            Response.Content = new StringContent(SB.ToString());
            Response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/html");
            return Response;
            
        }
    }
}