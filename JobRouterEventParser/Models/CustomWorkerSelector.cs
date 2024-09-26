using Azure.Messaging.EventGrid.SystemEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRouterEventParser.Models
{
    public class CustomWorkerSelector
    {
        public string Key { get; set; }

        public AcsRouterLabelOperator LabelOperator { get; set; }

        public object Value { get; set; }

        public double? TTLSeconds { get; set; }

        public AcsRouterWorkerSelectorState State { get; set; }

        public DateTimeOffset? ExpireTime { get; set; }
    }
}
