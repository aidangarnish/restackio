using Newtonsoft.Json;
using RestackIO.Net.Enums;
using RestackIO.Net.Models;
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
    public class Restack : RestBase
    {
        private string _AccountKey { get; set; }
        private string baseUrl = Constants.BaseUrl;

        private string data = "?";

        public Restack(string AccountKey)
            : base(Constants.BaseUrl)
        {
            _AccountKey = AccountKey;
        }

        ////Device API Methods////

        public Device GetDevice(string deviceId)
        {
            Device result = CallGetRestService<Device>("device/" + deviceId, string.Empty, _AccountKey);

            return result;
        }
        public List<Device> GetDevices()
        {
            List<Device> devices = CallGetRestService<List<Device>>("devices", string.Empty, _AccountKey);
            return devices;
        }

        public List<Device> GetPublicDevices()
        {
            List<Device> devices = CallGetRestService<List<Device>>("devices/list", string.Empty, _AccountKey);
            return devices;
        }

        public string CreateDevice(string name, string description, bool isPublic)
        {
            string visibilty = isPublic ? "public" : "private";
            string data = "{\"name\": \"" + name + "\", \"description\": \"" + description + "\", \"visibility\": \"" + visibilty + "\"}";

           string result = CallPostRestService("device", data, _AccountKey);

           return result;
        }
       
        public string UpdateDevice(string deviceId, string name, string description, bool isPublic)
        {
            string visibilty = isPublic ? "public" : "private";
            string data = "{\"name\": \"" + name + "\", \"description\": \"" + description + "\", \"visibility\": \"" + visibilty + "\"}";

            string result = CallPutRestService("device/" + deviceId, data, _AccountKey);

            return result;
        }

        public string DeleteDevice(string deviceId)
        {
            string result = CallDeleteRestService("device/" + deviceId, string.Empty, _AccountKey);

            return result;
        }
       
        ////Stack API Methods/////

        public string CreateStack(string deviceId, string name)
        {
            string result = CallPutRestService("device/" + deviceId + "/stack/" + name, string.Empty, _AccountKey);

            return result;
        }

        public List<Stack> GetStacks(string deviceId)
        {
            List<Stack> stacks = CallGetRestService<List<Stack>>("device/" + deviceId + "/stacks", string.Empty, _AccountKey);
            return stacks;
        }

        public Stack GetStack(string deviceId, string name)
        {
            Stack stack = CallGetRestService<Stack>("device/" + deviceId + "/stack/" + name, string.Empty, _AccountKey);
            return stack;
        }

        public string DeleteStack(string deviceId, string name)
        {
            string result = CallDeleteRestService("device/" + deviceId + "/stack/" + name, string.Empty, _AccountKey);

            return result;
        }

        public string SaveData(string deviceId, string name, Value value)
        {
          string result = CallPostRestService("device/" + deviceId + "/stack/" + name + "/value", JsonConvert.SerializeObject(value), _AccountKey);

          return result;
        }

        public string UpdateCurrentData(string deviceId, string name, Value value)
        {
            string result = CallPutRestService("device/" + deviceId + "/stack/" + name + "/value", JsonConvert.SerializeObject(value), _AccountKey);

            return result;
        }

        public string DeleteData(string deviceId, string name)
        {
            string result = CallDeleteRestService("device/" + deviceId + "/stack/" + name + "/values", string.Empty, _AccountKey);
            return result;
        }
        public Values GetValues(string deviceId, string name)
        {
            Values values = CallGetRestService<Values>("device/" + deviceId + "/stack/" + name + "/values", string.Empty, _AccountKey);

            return values;
        }

        public string GetStackStats(string deviceId, string name)
        {
            return CallGetRestService("device/" + deviceId + "/stack/" + name + "/stats", string.Empty, _AccountKey);
        }
    }
}
