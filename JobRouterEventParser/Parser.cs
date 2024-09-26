using Azure.Messaging.EventGrid;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public class Parser
    {
        private JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings()
        {
            DateTimeZoneHandling = DateTimeZoneHandling.Local,
        };

        public RouterEventBase Parse(string json)
        {
            RouterEventBase jobRouterEventBase = null;

            EventGridEvent egEvents = EventGridEvent.Parse(BinaryData.FromString(json));

            switch (egEvents.EventType)
            {
                case RouterEventType.RouterWorkerRegistered:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterWorkerRegistered>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterWorkerDeregistered:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterWorkerDeregistered>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterWorkerOfferIssued:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterWorkerOfferIssued>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterWorkerOfferAccepted:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterWorkerOfferAccepted>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterWorkerOfferDeclined:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterWorkerOfferDeclined>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterWorkerOfferExpired:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterWorkerOfferExpired>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterWorkerOfferRevoked:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterWorkerOfferRevoked>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterWorkerUpdated:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterWorkerUpdated>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterJobReceived:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterJobReceived>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterJobQueued:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterJobQueued>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterJobCompleted:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterJobCompleted>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterJobCancelled:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterJobCancelled>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterJobClosed:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterJobClosed>(json, _jsonSerializerSettings);
                    break;

                case RouterEventType.RouterJobWaitingForActivation:
                    jobRouterEventBase = JsonConvert.DeserializeObject<RouterJobWaitingForActivation>(json, _jsonSerializerSettings);
                    break;
            }

            return jobRouterEventBase;

        }
    }
}
