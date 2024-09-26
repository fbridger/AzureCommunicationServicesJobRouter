using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRouterEventParser
{
    public static class RouterEventType
    {
        public const string RouterJobReceived = "Microsoft.Communication.RouterJobReceived";
        public const string RouterJobClacified = "Microsoft.Communication.RouterJobClassified";
        public const string RouterJobQueued = "Microsoft.Communication.RouterJobQueued";
        public const string RouterJobClassificationFailed = "Microsoft.Communication.RouterJobClassificationFailed";
        public const string RouterJobCompleted = "Microsoft.Communication.RouterJobCompleted";
        public const string RouterJobClosed = "Microsoft.Communication.RouterJobClosed";
        public const string RouterJobCancelled = "Microsoft.Communication.RouterJobCancelled";
        public const string RouterJobExceptionTriggered = "Microsoft.Communication.RouterJobExceptionTriggered";
        public const string RouterJobWorkerSelectorExpired = "Microsoft.Communication.RouterJobWorkerSelectorsExpired";
        public const string RouterJobUnassigned = "Microsoft.Communication.RouterJobUnassigned";
        public const string RouterJobWaitingForActivation = "Microsoft.Communication.RouterJobWaitingForActivation";
        public const string RouterJobSchedulingFailed = "Microsoft.Communication.RouterJobSchedulingFailed";
        public const string RouterJobDeleted = "Microsoft.Communication.RouterJobDeleted";

        public const string RouterWorkerOfferIssued = "Microsoft.Communication.RouterWorkerOfferIssued";
        public const string RouterWorkerOfferAccepted = "Microsoft.Communication.RouterWorkerOfferAccepted";
        public const string RouterWorkerOfferDeclined = "Microsoft.Communication.RouterWorkerOfferDeclined";
        public const string RouterWorkerOfferRevoked = "Microsoft.Communication.RouterWorkerOfferRevoked";
        public const string RouterWorkerOfferExpired = "Microsoft.Communication.RouterWorkerOfferExpired";
        public const string RouterWorkerRegistered = "Microsoft.Communication.RouterWorkerRegistered";
        public const string RouterWorkerDeregistered = "Microsoft.Communication.RouterWorkerDeregistered";
        public const string RouterWorkerDeleted = "Microsoft.Communication.RouterWorkerDeleted";

        public const string RouterWorkerUpdated = "Microsoft.Communication.RouterWorkerUpdated";
    }
}
