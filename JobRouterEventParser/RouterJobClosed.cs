using Azure.Communication.JobRouter;
using Azure.Messaging.EventGrid.SystemEvents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public class RouterJobClosed : RouterEventBase
    {
        [JsonPropertyName("data")]
        public RouterJobClosedData Data { get; set; }
    }

    public class RouterJobClosedData
    {
        public string JobId { get; set; }

        public string ChannelReference { get; set; }

        public string ChannelId { get; set; }

        public string QueueId { get; set; }

        public string DispositionCode { get; set; }

        public string WorkerId { get; set; }

        public string AssignmentId { get; set; }

        public Dictionary<string, string> Labels { get; set; }

        public Dictionary<string, string> Tags { get; set; }
    }
}
