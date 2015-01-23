using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RestackIO.Net
{
    public class Restack
    {
        private string _UUID { get; set; }
        private string _Token { get; set; }
        private string baseUrl = Constants.BaseUrl;

        private string data = "?";

        public Restack(string UUID, string Token)
        {
            _UUID = UUID;
            _Token = Token;
        }
       
        public string GetStatus()
        {
            string url = baseUrl;

            using (var wb = new WebClient())
            {
                var response = wb.DownloadString(url);

                return response;
            }
        }      

        public string PostData(string key, object value)
        {
            try
            {
                string url = baseUrl + "data/";

                if (!String.IsNullOrEmpty(key) && value != null)
                {
                    data = data + key + "=" + value;

                    using (var wb = new WebClient())
                    {
                        var fullUrl = url + _UUID + data;

                        wb.Headers.Add("restack_auth_uuid", _UUID);
                        wb.Headers.Add("restack_auth_token", _Token);
                        var response = wb.UploadString(fullUrl, "POST");
                        data = "?";
                        return response;
                    }
                }
                else
                {
                    return "Key and Value cannot be empty";
                }
            }
            catch (WebException ex)
            {
                return ex.Message.ToString();
            }
        }

        public string PostData(NameValueCollection nameValueCollection)
        {
            try
            {
                string data = "?";
                string url = baseUrl + "data/";

                if (nameValueCollection.Count >= 1)
                {
                    foreach(string name in nameValueCollection)
                    {
                        foreach(string value in nameValueCollection.GetValues(name))
                        {
                            data = data == "?" ? data + name + "=" + value : data + "&" + name + "=" + value;
                        }
                    }

                    using (var wb = new WebClient())
                    {
                        var fullUrl = url + _UUID + data;

                        wb.Headers.Add("restack_auth_uuid", _UUID);
                        wb.Headers.Add("restack_auth_token", _Token);
                        var response = wb.UploadString(fullUrl, "POST");
                        nameValueCollection.Clear();
                        return response;
                    }
                }
                else
                {
                    return "Name value collection cannot be empty";
                }
            }
            catch (WebException ex)
            {
                return ex.Message.ToString();
            }
        }  
    }
}
