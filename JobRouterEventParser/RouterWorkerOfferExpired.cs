using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public class RouterWorkerOfferExpired : RouterEventBase
    {
        [JsonPropertyName("data")]
        public RouterWorkerOfferExpiredData Data { get; set; }
    }

    public class RouterWorkerOfferExpiredData
    {
        public string WorkerId { get; set; }

        public string JobId { get; set; }

        public string ChannelReference { get; set; }

        public string ChannelId { get; set; }

        public string QueueId { get; set; }

        public string OfferId { get; set; }
    }
}
