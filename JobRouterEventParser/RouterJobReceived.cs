using Azure.Communication.JobRouter;
using Azure.Messaging.EventGrid.SystemEvents;
using JobRouterEventParser.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
//using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public class RouterJobReceived : RouterEventBase
    {
        [JsonProperty("data")]
        public RouterJobRecievedData Data { get; set; }
    }

    public class RouterJobRecievedData
    {
        public string JobId { get; set; }

        public string ChannelReference { get; set; }

        public int Jobstatus { get; set; }

        public string ChannelId { get; set; }

        public string ClassificationPolicyId { get; set; }

        public string QueueId { get; set; }

        public int Priority { get; set; }

        public Dictionary<string, string> Labels { get; set; }

        public Dictionary<string, string> Tags { get; set; }

        public List<CustomWorkerSelector> RequestedWorkerSelectors { get; set; }

        public DateTimeOffset ScheduledOn { get; set; }

        public bool UnavailableForMatching { get; set; }
    }
}
