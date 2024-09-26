using Azure.Communication.JobRouter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AzureCommunicationServicesJobRouter.BindingModels
{
    public class DistributionPolicyBinding
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int MinConcurrentOffers { get; set; }

        public int MaxConcurrentOffers { get; set; }

        public bool ByPassSelectors { get; set; }

        public string Kind { get; set; }

        public TimeSpan ExpireAfter { get; set; }

        public string ETag { get; set; }
    }

    public static class DistributionPolicyBindingExtensions
    {
        public static DistributionPolicyBinding ToDistributionPolicyBinding(this DistributionPolicy policy)
        {
            return new DistributionPolicyBinding()
            {
                ByPassSelectors = policy.Mode.BypassSelectors.Value,
                ExpireAfter = policy.OfferExpiresAfter.Value,
                Id = policy.Id,
                Kind = policy.Mode.Kind.ToString(),
                MaxConcurrentOffers = policy.Mode.MaxConcurrentOffers,
                MinConcurrentOffers = policy.Mode.MinConcurrentOffers,
                Name = policy.Name,
                ETag = policy.ETag.ToString()
            };
        }
    }
}
