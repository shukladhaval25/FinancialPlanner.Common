using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FinancialPlanner.Common
{
    public class RestAPIExecutor 
    {
        const string API_DELIMETER = "api/";
        const string CLIENT_Token = "CLIENTToken";
        public static CookieCollection _cookiesCollection = new CookieCollection();
        private string _url;
        private object _objectType;
        private string _method;

        public object Execute<T>(string url, T objectType, string method)
        {
            _url = url;
            _objectType = objectType;
            _method = method;

            JSONSerialization  jsonSerialization = new JSONSerialization();
            HttpWebRequest request = setWebRequest();

            string responseString = string.Empty;
            
            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                 responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                if (_cookiesCollection.Count == 0)
                    _cookiesCollection = response.Cookies;                
            }

            var result = jsonSerialization.DeserializeFromString<Common.Model.Result<object>>(responseString);
            if (result.IsSuccess)
                return result.Value;
            else
                throw result.ExceptionInfo;
        }
        private HttpWebRequest setCookies(HttpWebRequest request, CookieCollection cookiesCollection)
        {
            foreach (Cookie responseCookie in cookiesCollection)
            {
                if (responseCookie.Name == CLIENT_Token)
                {
                    request.Headers.Add(responseCookie.Name, responseCookie.Value);
                }
                request.CookieContainer.Add(responseCookie);
            }
            return request;
        }

        private HttpWebRequest setWebRequest()
        {
            JSONSerialization  jsonSerialization = new JSONSerialization();
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(_url);

            string DATA = (_objectType == null) ? string.Empty : jsonSerialization.SerializeToString<object>(_objectType);
            var data = Encoding.ASCII.GetBytes(DATA);
            request.Method = _method;
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            request.Referer = _url.Substring(0, _url.IndexOf(API_DELIMETER));
            request.KeepAlive = true;
            //request.Credentials = new NetworkCredential(txtUserName.Text, txtPass.Text);
            if (request.Method != "GET")
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            if (request.CookieContainer == null)
                request.CookieContainer = new CookieContainer();

            request = setCookies(request, _cookiesCollection);

            return request;
        }

      
    }
}
