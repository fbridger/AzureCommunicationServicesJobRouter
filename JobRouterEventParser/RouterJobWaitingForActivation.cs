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
    public class RouterJobWaitingForActivation : RouterEventBase
    {
        [JsonPropertyName("data")]
        public RouterJobWaitingForActivationData Data { get; set; }
    }

    public class RouterJobWaitingForActivationData
    {
        public string JobId { get; set; }

        public string ChannelReference { get; set; }

        public string ChannelId { get; set; }

        public string QueueId { get; set; }

        public int Priority { get; set; }

        public Dictionary<string, string> Labels { get; set; }

        public Dictionary<string, string> Tags { get; set; }

        public List<CustomWorkerSelector> RequestedWorkerSelectorsExpired { get; set; }

        public List<CustomWorkerSelector> AttachedWorkerSelectorsExpired { get; set; }

        public DateTimeOffset ScheduledOn { get; set; }

        public bool UnavailableForMatching { get; set; }
    }
}
