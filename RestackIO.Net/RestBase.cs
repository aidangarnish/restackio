using Newtonsoft.Json;
using RestackIO.Net.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestackIO.Net
{
    public abstract class RestBase
    {
        private readonly string baseurl;

        public RestBase(string BaseUrl)
        {
            baseurl = BaseUrl;
        }
        private T CallRestService<T>(string path, HttpVerbs verb, string data, string key)
        {
            string url = baseurl + path;

            var response = string.Empty;

            using (var wb = new WebClient())
            {
                wb.Headers[HttpRequestHeader.ContentType] = "application/json";
                wb.Headers.Add("X-RSTCK-KEY", key);

                if (verb == HttpVerbs.Get)
                {
                    response = wb.DownloadString(url + data);
                }
                else if (verb == HttpVerbs.Post)
                {
                    response = wb.UploadString(url, data ?? string.Empty);
                }

            }

            return JsonConvert.DeserializeObject<T>(response);

        }

        private string CallRestService(string path, HttpVerbs verb, string data, string key)
        {
            string url = baseurl + path;

            var response = string.Empty;

            using (var wb = new WebClient())
            {
                wb.Headers[HttpRequestHeader.ContentType] = "application/json";
                wb.Headers.Add("X-RSTCK-KEY", key);

                if (verb == HttpVerbs.Get)
                {
                    response = wb.DownloadString(url + data);
                }
                else if (verb == HttpVerbs.Post)
                {
                    response = wb.UploadString(url, data ?? string.Empty);
                }
                else if(verb == HttpVerbs.Put)
                {
                    response = wb.UploadString(url, "PUT", data ?? string.Empty);
                }
                else if(verb == HttpVerbs.Delete)
                {
                    response = wb.UploadString(url, "DELETE", data ?? string.Empty);
                }

            }

            return response;

        }

        protected T CallGetRestService<T>(string path, string data, string key)
        {
            return CallRestService<T>(path, HttpVerbs.Get, data, key);
        }

        protected T CallPostRestService<T>(string path, string data, string key)
        {
            return CallRestService<T>(path, HttpVerbs.Post, data, key);
        }

        protected string CallGetRestService(string path, string data, string key)
        {
            return CallRestService(path, HttpVerbs.Get, data, key);
        }

        protected string CallPostRestService(string path, string data, string key)
        {
            return CallRestService(path, HttpVerbs.Post, data, key);
        }

        protected string CallPutRestService(string path, string data, string key)
        {
            return CallRestService(path, HttpVerbs.Put, data, key);
        }

        protected string CallDeleteRestService(string path, string data, string key)
        {
            return CallRestService(path, HttpVerbs.Delete, data, key);
        }
    }
}
