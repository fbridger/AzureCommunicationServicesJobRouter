using Azure.Communication.JobRouter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public class RouterWorkerOfferDeclined : RouterEventBase
    {
        [JsonPropertyName("data")]
        public RouterWorkerOfferDeclinedData Data { get; set; }
    }

    public class RouterWorkerOfferDeclinedData
    {
        public string WorkerId { get; set; }

        public string JobId { get; set; }

        public string ChannelReference { get; set; }

        public string ChannelId { get; set; }

        public string QueueId { get; set; }

        public string OfferId { get; set; }
    }
}
