using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCommunicationServicesJobRouter.Models
{
    public class RespondToJobOfferResponse
    {
        public string JobId { get; set; }

        public string OfferId { get; set; }

        public bool AcceptOffer { get; set; }

        public DateTimeOffset? RetryAfter { get; set; }
    }
}
