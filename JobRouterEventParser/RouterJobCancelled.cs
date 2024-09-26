using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public class RouterJobCancelled : RouterEventBase
    {
        [JsonPropertyName("data")]
        public RouterJobCancelledData Data { get; set; }
    }

    public class RouterJobCancelledData
    {
        public string JobId { get; set; }

        public string ChannelReference { get; set; }

        public string ChannelId { get; set; }

        public string DispositionCode { get; set; }

        public Dictionary<string, string> Labels { get; set; }

        public Dictionary<string, string> Tags { get; set; }

        public string Note { get; set; }

        public string QueueId { get; set; }
    }
}
