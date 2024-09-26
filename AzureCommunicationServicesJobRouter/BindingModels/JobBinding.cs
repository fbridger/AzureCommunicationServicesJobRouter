using Azure.Communication.JobRouter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AzureCommunicationServicesJobRouter.BindingModels
{
    public class JobBinding
    {
        public string Id { get; set; }

        public string Assignments { get; set; }

        public string AttachedWorkerSelectors { get; set; }

        public string ChannelId { get; set; }

        public string ChannelReference { get; set; }

        public string ClassificationPolicyId { get; set; }

        public DateTimeOffset? EnqueueAt { get; set; }

        public string Labels { get; set; }

        public string MatchingMode { get; set; }

        public string Notes { get; set; }

        public int? Priority { get; set; }

        public string QueueId { get; set; }

        public string RequestedWorkerSelector { get; set; }

        public DateTimeOffset? ScheduleAt { get; set; }

        public string Status { get; set; }

        public string Tags { get; set; }

        public string DispositionCode { get; set; }
    }

    internal static class JobBindingExtensions
    {
        public static JobBinding ToJobBinding(this RouterJob job)
        {
            return new JobBinding()
            {
                Assignments = JsonConvert.SerializeObject(job.Assignments.Select(a => a.Value)),
                AttachedWorkerSelectors = JsonConvert.SerializeObject(job.AttachedWorkerSelectors),
                ChannelId = job.ChannelId,
                ChannelReference = job.ChannelReference,
                ClassificationPolicyId = job.ClassificationPolicyId,
                EnqueueAt = job.EnqueuedAt,
                Id = job.Id,
                Labels = JsonConvert.SerializeObject(job.Labels),
                MatchingMode = job.MatchingMode.Kind.ToString(),
                Notes = JsonConvert.SerializeObject(job.Notes),
                Priority = job.Priority,
                QueueId = job.QueueId,
                RequestedWorkerSelector = JsonConvert.SerializeObject(job.RequestedWorkerSelectors),
                ScheduleAt = job.ScheduledAt,
                Status = job.Status?.ToString(),
                Tags = JsonConvert.SerializeObject(job.Tags),
                DispositionCode = job.DispositionCode,
            };
        }
    }
}
