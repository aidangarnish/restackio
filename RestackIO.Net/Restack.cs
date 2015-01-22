using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestackIO.Net
{
    public class Restack
    {
        private string _UUID { get; set; }
        private string _Token { get; set; }

        private string Url = "https://alpha.restack.io/data/";
        private string data = "?";

        public Restack(string UUID, string Token)
        {
            _UUID = UUID;
            _Token = Token;
        }
        public void AddData(string key, string value)
        {
            data = data == "?" ? data + key + "=" + value : data + "&" + key + "=" + value;
        }

        public void SaveData()
        {
            if (data != "?")
            {
                using (var wb = new WebClient())
                {
                    var fullUrl = Url + _UUID + data;

                    wb.Headers.Add("restack_auth_uuid", _UUID);
                    wb.Headers.Add("restack_auth_token", _Token);
                    var response = wb.UploadString(fullUrl, "POST");
                }

                data = "?";
            }
        }
     
    }
}
