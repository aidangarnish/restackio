using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestackIO.Net;
using RestackIO.Net.Models;
using System.Collections.Generic;

namespace RestackTests
{
    [TestClass]
    public class DeviceTest
    {
        private string acctKey = "c684132b4a8a49178d14214cb6390482";

        [TestMethod]
        public void Get_Devices()
        {
            Restack restack = new Restack(acctKey);
            List<Device> devices = restack.GetDevices();

            Assert.IsTrue(devices.Count >= 1);

        }

        [TestMethod]
        public void Get_Public_Devices()
        {
            Restack restack = new Restack(acctKey);
            List<Device> devices = restack.GetPublicDevices();

            Assert.IsTrue(devices.Count >= 1);

        }

        [TestMethod]
        public void Get_Device()
        {
            Restack restack = new Restack(acctKey);
            string deviceId = "c031d8bd7bdc48d8992cf58ff39fc43f";
            Device device = restack.GetDevice(deviceId);

            Assert.AreEqual(deviceId, device.Id);
        }

        [TestMethod]
        public void Create_Device()
        {

            Restack restack = new Restack(acctKey);

            string name = "Test device 2";
            string description = "Description of test device 2";
            string response = restack.CreateDevice(name, description, false);

            Assert.IsFalse(response.Contains("errors"));
            Assert.IsTrue(response.Contains(name));
            Assert.IsTrue(response.Contains(description));
        }

        [TestMethod]
        public void Update_Device()
        {

            Restack restack = new Restack(acctKey);

            string deviceId = "c1567b934d4344fc8b8052f305cad9a1";
            string name = "Test device updated";
            string description = "Description of test device 2 updated";
            string response = restack.UpdateDevice(deviceId, name, description, false);

            Assert.IsFalse(response.Contains("errors"));
            Assert.IsTrue(response.Contains(name));
            Assert.IsTrue(response.Contains(description));
        }

        [TestMethod]
        public void Delete_Device()
        {
            Restack restack = new Restack(acctKey);
            string deviceId = "d100ed03fb3d488d957eab51bb917079";
            string result = restack.DeleteDevice(deviceId);

            Assert.IsTrue(result.Contains("204"));
        }
    }
}
