using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestackIO.Net;
using RestackIO.Net.Models;
using System.Collections.Generic;
using System.Configuration;

namespace RestackTests
{
    [TestClass]
    public class StackTest
    {
        private string acctKey = ConfigurationManager.AppSettings["accountKey"];

        [TestMethod]
        public void Create_Stack()
        {
            Restack restack = new Restack(acctKey);

            string name = "TestStack";
            string deviceId = "c031d8bd7bdc48d8992cf58ff39fc43f";
            string response = restack.CreateStack(deviceId, name);

            Assert.IsFalse(response.Contains("errors"));
        }

        [TestMethod]
        public void Delete_Stack()
        {
            Restack restack = new Restack(acctKey);

            string name = "TestStack";
            string deviceId = "c031d8bd7bdc48d8992cf58ff39fc43f";
            string response = restack.DeleteStack(deviceId, name);

            Assert.AreEqual(string.Empty, response);
        }

        [TestMethod]
        public void Get_Stacks()
        {
            Restack restack = new Restack(acctKey);

            List<Stack> stacks = restack.GetStacks("c031d8bd7bdc48d8992cf58ff39fc43f");

            Assert.IsTrue(stacks.Count >= 1);

        }

        [TestMethod]
        public void Get_Stack()
        {
            Restack restack = new Restack(acctKey);
            string deviceId = "c031d8bd7bdc48d8992cf58ff39fc43f";
            string stackName = "hellostack";
            Stack stack = restack.GetStack(deviceId, stackName);

            Assert.AreEqual(stackName, stack.Name.ToLower());
        }

        [TestMethod]
        public void Save_Data()
        {
            Restack restack = new Restack(acctKey);
            string deviceId = "c031d8bd7bdc48d8992cf58ff39fc43f";
            string stackName = "hellostack";

            Value value = new Value
            {
                value = new decimal(97.3)
            };

            string result = restack.SaveData(deviceId, stackName, value);

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void Update_Data()
        {
            Restack restack = new Restack(acctKey);
            string deviceId = "c031d8bd7bdc48d8992cf58ff39fc43f";
            string stackName = "hellostack";

            Value value = new Value
            {
                value = new decimal(97.2)
            };

            string result = restack.UpdateCurrentData(deviceId, stackName, value);

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void Get_Values()
        {
            Restack restack = new Restack(acctKey);
            string deviceId = "c031d8bd7bdc48d8992cf58ff39fc43f";
            string stackName = "hellostack";

            
            Values result = restack.GetValues(deviceId, stackName);

            Assert.IsTrue(result.values.Count >= 1);
        }

        [TestMethod]
        public void Get_Stats()
        {
            Restack restack = new Restack(acctKey);
            string deviceId = "c031d8bd7bdc48d8992cf58ff39fc43f";
            string stackName = "hellostack";


            string result = restack.GetStackStats(deviceId, stackName);

            Assert.IsTrue(result.Contains("values"));
        }
    }
}
