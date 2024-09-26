using Azure.Communication.JobRouter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public class RouterWorkerRegistered : RouterEventBase
    {
        [JsonPropertyName("data")]
        public RouterWorkerRegisteredData Data { get; set; }
    }

    public class RouterWorkerRegisteredData
    {
        public string WorkerId { get; set; }

        public int TotalCapacity { get; set; }

        public List<CustomRouterQueueDetails> QueueAssignments { get; set; }

        public List<RouterChannel> ChannelConfigurations { get; set; }

        public Dictionary<string, string> Labels { get; set; }

        public Dictionary<string, string> Tags { get; set; }

    }

    public class CustomRouterQueueDetails
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public IReadOnlyDictionary<string, string> Labels { get; set; }
    }
}
