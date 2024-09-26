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
    public class RouterJobCompleted : RouterEventBase
    {
        [JsonPropertyName("data")]
        public RouterJobCompletedData Data { get; set; }
    }

    public class RouterJobCompletedData
    {
        public string JobId { get; set; }

        public string ChannelReference { get; set; }

        public string ChannelId { get; set; }

        public string QueueId { get; set; }

        public string AssignmentId { get; set; }

        public Dictionary<string, string> Labels { get; set; }

        public Dictionary<string, string> Tags { get; set; }

        public string WorkerId { get; set; }
    }
}
