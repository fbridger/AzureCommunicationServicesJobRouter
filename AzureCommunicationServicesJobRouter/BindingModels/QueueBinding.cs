using Azure.Communication.JobRouter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCommunicationServicesJobRouter.BindingModels
{
    public class QueueBinding
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string DistributionPolicyId { get; set; }

        public string ExceptionPolicyId { get; set; }

        public string Labels { get; set; }

        public string ETag { get; set; }
    }

    public static class QueueBindingExtensions
    {
        public static QueueBinding ToQueueBinding(this RouterQueue queue)
        {
            return new QueueBinding()
            {
                DistributionPolicyId = queue.DistributionPolicyId,
                ExceptionPolicyId = queue.ExceptionPolicyId,
                Id = queue.Id,
                Labels = JsonConvert.SerializeObject(queue.Labels),
                Name = queue.Name,
                ETag = queue.ETag.ToString()
            };
        }
    }
}
