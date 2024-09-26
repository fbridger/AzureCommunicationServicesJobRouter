using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public class RouterWorkerDeregistered : RouterEventBase
    {
        [JsonPropertyName("data")]
        public RouterWorkerDeregisteredData Data { get; set; }
    }

    public class RouterWorkerDeregisteredData
    {
        public string WorkerId { get; set; }
    }
}
