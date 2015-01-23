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
        public void Post_Data()
        {
            string UUID = "2348ce01-a2e2-11e4-903e-c1e2ccd2ffa5";
            string token = "082gtf8e0e9afw295khrmsixvwqdj9k9";

            Restack restack = new Restack(UUID, token);
            string response = restack.PostData("temperature", "16");

            Assert.AreNotEqual(string.Empty, response);
            Assert.IsTrue(response.Contains(UUID));

        }

        [TestMethod]
        public void Post_Data_Object()
        {
            string UUID = "2348ce01-a2e2-11e4-903e-c1e2ccd2ffa5";
            string token = "082gtf8e0e9afw295khrmsixvwqdj9k9";

            Restack restack = new Restack(UUID, token);
            int temp = 17;
            string strTemp = "21";
            double dblTemp = 19.7;
            string response = restack.PostData("temperature", dblTemp);

            Assert.AreNotEqual(string.Empty, response);
            Assert.IsTrue(response.Contains(UUID));

        }

        [TestMethod]
        public void Post_Data_UnauthorizedAccessException()
        {
            string UUID = "2348ce01-a2e2-11e4-903e-c1e2ccd2ffa5";
            string token = "082gtf8e0e9afw295khrmsixvwqdj9";

            Restack restack = new Restack(UUID, token);
            string response = restack.PostData("temperature", "12");

            Assert.AreEqual("The remote server returned an error: (401) Unauthorized.", response);
        }

        [TestMethod]
        public void Post_Data_NameValueCollection()
        {
            string UUID = "2348ce01-a2e2-11e4-903e-c1e2ccd2ffa5";
            string token = "082gtf8e0e9afw295khrmsixvwqdj9k9";

            Restack restack = new Restack(UUID, token);

            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("temperature", "19");
            nvc.Add("humidity", "58");


            string response = restack.PostData(nvc);

            Assert.AreNotEqual(string.Empty, response);
            Assert.IsTrue(response.Contains(UUID));

        }
    }
}
