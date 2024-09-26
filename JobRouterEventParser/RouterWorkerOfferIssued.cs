using Azure.Communication.JobRouter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public class RouterWorkerOfferIssued : RouterEventBase
    {
        [JsonPropertyName("data")]
        public RouterWorkerRegisteredData Data { get; set; }
    }

    public class RouterWorkerOfferIssuedData
    {
        public string WorkerId { get; set; }

        public string JobId { get; set; }

        public string ChannelReference { get; set; }

        public string ChannelId { get; set; }

        public string QueueId { get; set; }

        public string OfferId { get; set; }

        public DateTimeOffset OfferedOn { get; set; }

        public DateTimeOffset ExpiresOn { get; set; }

        public int JobPriority { get; set; }

        public Dictionary<string, string> JobLabels { get; set; }

        public Dictionary<string, string> JobTags { get; set; }
    }
}
