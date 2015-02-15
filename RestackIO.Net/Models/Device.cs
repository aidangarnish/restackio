using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestackIO.Net.Models
{
    public class Device
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Visibility { get; set; }
        public string Status { get; set; }
        public string Url { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
    }
}
