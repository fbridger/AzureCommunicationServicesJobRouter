using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public abstract class RouterEventBase
    {
        public string Id { get; set; }

        public string Topic { get; set; }

        public string Subject { get; set; }

        public string EventType { get; set; }

        public string DataVersion { get; set; }

        public int MetadataVersion { get; set; }

        public DateTime EventTime { get; set; }
    }
}
