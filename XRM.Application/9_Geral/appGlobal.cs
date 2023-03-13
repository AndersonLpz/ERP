using System;
using System.Web;

namespace XRM.Application._9_Geral
{
    public class appGlobal
    {
        public string RetornaPath(HttpRequestBase vobjRequest)
        {
            string lstrPath = string.Empty;

            try
            {
                if (vobjRequest.Url.PathAndQuery.Trim() != "/")
                {
                    lstrPath = vobjRequest.Url.AbsoluteUri.Replace(vobjRequest.Url.PathAndQuery, "") + (vobjRequest.ApplicationPath.Trim().Length > 1 ? vobjRequest.ApplicationPath.Trim() : "") + "/";
                }
                else
                {
                    lstrPath = vobjRequest.Url.AbsoluteUri;
                }
            }
            catch (Exception)
            {
            }

            return lstrPath;
        }
    }
}
