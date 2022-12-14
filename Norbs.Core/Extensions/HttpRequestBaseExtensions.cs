using System.Web;
using Norbs.Common;

namespace Norbs.Core.Extensions
{
	public static class HttpRequestBaseExtensions
	{
		public static string GetQueryParameter(this HttpRequestBase request)
		{
			if (request == null) return string.Empty;

			return request[Constants.RequestParameters.Query];
		}

		public static int GetPageParameter(this HttpRequestBase request)
		{
			const int defaultValue = 1;
			if (request == null) return defaultValue;

			return int.TryParse(request[Constants.RequestParameters.Page], out int page) ? page : defaultValue;
		}
	}
}
