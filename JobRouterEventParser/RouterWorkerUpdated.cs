using Azure.Communication.JobRouter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public class RouterWorkerUpdated : RouterEventBase
    {
        [JsonPropertyName("data")]
        public RouterWorkerUpdateddData Data { get; set; }
    }

    public class RouterWorkerUpdateddData
    {
        public string WorkerId { get; set; }

        public bool AvailableForOffers { get; set; }

        public int TotalCapacity { get; set; }

        public List<CustomRouterQueueDetails> QueueAssignments { get; set; }

        public List<RouterChannel> ChannelConfigurations { get; set; }

        public Dictionary<string, string> Labels { get; set; }

        public Dictionary<string, string> Tags { get; set; }

        public List<string> UpdatedWorkerProperties { get; set; }

    }
}
