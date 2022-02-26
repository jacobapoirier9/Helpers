using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Helpers
{
    public static class UriHelpers
    {
        public static string BuildUri(this string uri, object queryParams)
        {
            if (!uri.Contains('?'))
                uri += '?';

            foreach (var queryParam in queryParams.GetType().GetProperties())
            {
                Console.WriteLine(uri);
                if (uri.Contains(queryParam.Name + '='))
                {
                    uri = Regex.Replace(uri, queryParam.Name + "=\\w*", queryParam.Name + '=' + queryParam.GetValue(queryParams));
                }
                else
                {
                    uri += '&' + queryParam.Name + '=' + queryParam.GetValue(queryParams);
                }
            }

            return uri;
        }

    }
}
