using Azure.Communication.JobRouter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCommunicationServicesJobRouter.BindingModels
{
    public class WorkerBinding
    {
        public string Id { get; set; }

        public string Queues { get; set; }

        public bool IsAvailableForOffer { get; set; }

        public string Offers { get; set; }

        public string AssignedJobs { get; set; }

        public int Capacity { get; set; }

        public string Channels { get; set; }

        public List<RouterChannel> ChannlesList { get; set; }

        public string Labels { get; set; }

        public double LoadRatio { get; set; }

        public int MaxConcurrentOffers { get; set; }

        public string State { get; set; }

        public string ETag { get; set; }

        public string Tags { get; set; }
    }

    internal static class WorkerBindingExtenstions
    {
        public static WorkerBinding ToWorkerBinding(this RouterWorker worker)
        {
            return new WorkerBinding()
            {
                AssignedJobs = JsonConvert.SerializeObject(worker.AssignedJobs),
                Capacity = worker.Capacity.Value,
                Channels = JsonConvert.SerializeObject(worker.Channels),
                ChannlesList = worker.Channels.ToList(),
                Id = worker.Id,
                IsAvailableForOffer = worker.AvailableForOffers ?? false,
                Labels = JsonConvert.SerializeObject(worker.Labels),
                LoadRatio = worker.LoadRatio.Value,
                MaxConcurrentOffers = worker.MaxConcurrentOffers ?? 0,
                Offers = JsonConvert.SerializeObject(worker.Offers),
                Queues = JsonConvert.SerializeObject(worker.Queues),
                State = worker.State.Value.ToString(),
                ETag = worker.ETag.ToString(),
                Tags = JsonConvert.SerializeObject(worker.Tags)
            };
        }
    }
}
