using Azure.Communication.JobRouter;
using Azure.Messaging.EventGrid.SystemEvents;
using JobRouterEventParser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public class RouterJobQueued : RouterEventBase
    {
        [JsonPropertyName("data")]
        public RouterJobQueuedData Data { get; set; }
    }

    public class RouterJobQueuedData
    {
        public string JobId { get; set; }

        public string ChannelReference { get; set; }

        public string ChannelId { get; set; }

        public string QueueId { get; set; }

        public int Priority { get; set; }

        public Dictionary<string, string> Labels { get; set; }

        public Dictionary<string, string> Tags { get; set; }

        public List<CustomWorkerSelector> RequestedWorkerSelectors { get; set; }

        public List<CustomWorkerSelector> AttachedWorkerSelectors { get; set; }
    }
}
