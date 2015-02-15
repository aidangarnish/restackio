using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestackIO.Net;
using System.Collections.Specialized;

namespace RestackTests
{
    [TestClass]
    public class PostDataTests
    {
        [TestMethod]
        public void Post_Data_String()
        {
            //string UUID = "2348ce01-a2e2-11e4-903e-c1e2ccd2ffa5";
            //string token = "082gtf8e0e9afw295khrmsixvwqdj9k9";

            //Restack restack = new Restack(UUID, token);

            //string strTemp = "16";
            //string response = restack.PostData("temperature", strTemp);

            //Assert.AreNotEqual(string.Empty, response);
            //Assert.IsTrue(response.Contains(UUID));
            //Assert.IsTrue(response.Contains(strTemp));
        }

        [TestMethod]
        public void Post_Data_Int()
        {
            //string UUID = "2348ce01-a2e2-11e4-903e-c1e2ccd2ffa5";
            //string token = "082gtf8e0e9afw295khrmsixvwqdj9k9";

            //Restack restack = new Restack(UUID, token);

            //double intTemp = 17;
            //string response = restack.PostData("temperature", intTemp);

            //Assert.AreNotEqual(string.Empty, response);
            //Assert.IsTrue(response.Contains(UUID));
            //Assert.IsTrue(response.Contains(intTemp.ToString()));
        }

        [TestMethod]
        public void Post_Data_Double()
        {
            //string UUID = "2348ce01-a2e2-11e4-903e-c1e2ccd2ffa5";
            //string token = "082gtf8e0e9afw295khrmsixvwqdj9k9";

            //Restack restack = new Restack(UUID, token);
           
            //double dblTemp = 19.7;
            //string response = restack.PostData("temperature", dblTemp);

            //Assert.AreNotEqual(string.Empty, response);
            //Assert.IsTrue(response.Contains(UUID));
            //Assert.IsTrue(response.Contains(dblTemp.ToString()));
        }

        [TestMethod]
        public void Post_Data_UnauthorizedAccessException()
        {
            //string UUID = "2348ce01-a2e2-11e4-903e-c1e2ccd2ffa5";
            //string token = "082gtf8e0e9afw295khrmsixvwqdj9";

            //Restack restack = new Restack(UUID, token);
            //string response = restack.PostData("temperature", "12");

            //Assert.AreEqual("The remote server returned an error: (401) Unauthorized.", response);
        }

        [TestMethod]
        public void Post_Data_NameValueCollection()
        {
            //string UUID = "2348ce01-a2e2-11e4-903e-c1e2ccd2ffa5";
            //string token = "082gtf8e0e9afw295khrmsixvwqdj9k9";

            //Restack restack = new Restack(UUID, token);

            //string strTemp = "19";
            //string strHumidity = "63";

            //NameValueCollection nvc = new NameValueCollection();
            //nvc.Add("temperature", strTemp);
            //nvc.Add("humidity", strHumidity);


            //string response = restack.PostData(nvc);

            //Assert.AreNotEqual(string.Empty, response);
            //Assert.IsTrue(response.Contains(UUID));
            //Assert.IsTrue(response.Contains(strTemp));
            //Assert.IsTrue(response.Contains(strHumidity));
        }
    }
}
