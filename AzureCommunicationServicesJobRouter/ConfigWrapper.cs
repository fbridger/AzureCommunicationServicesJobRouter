using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AzureCommunicationServicesJobRouter
{
    internal class ConfigWrapper
    {
        private readonly IConfiguration _config;

        public ConfigWrapper(IConfiguration config)
        {
            _config = config;

            AcsConnectionString = _config["AcsConnectionString"];
            ServiceBusConnectionString = _config["ServiceBusConnectionString"];
            ServiceBusQueueName = _config["ServiceBusQueueName"];
        }

        public string AcsConnectionString { get; private set; }

        public string ServiceBusConnectionString { get; private set; }

        public string ServiceBusQueueName { get; private set; }
    }
}
