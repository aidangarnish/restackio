﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestackIO.Net
{
    public class RestackServiceStatus
    {
        //private string baseUrl = Constants.BaseUrl;

        public static string GetStatus()
        {
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString(Constants.BaseUrl + "status");

                return response;
            }
        }
    }
}