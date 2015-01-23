using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestackIO.Net
{
    public class RestackServiceStatus
    {
        public static string GetStatus()
        {
            try
            {
                using (var wb = new WebClient())
                {
                    var response = wb.DownloadString(Constants.BaseUrl + "status");

                    return response;
                }
            }
            catch (WebException ex)
            {
                return ex.Message.ToString();
            }
        }
    }
}
