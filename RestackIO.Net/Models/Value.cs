using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestackIO.Net.Models
{
    public class Value
    {
        public Value()
        {
            timestamp = DateTime.UtcNow;
        }
        public decimal value { get; set; }
        public DateTime timestamp { get; set; }
    }
}
