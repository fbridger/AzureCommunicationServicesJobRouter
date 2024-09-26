using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCommunicationServicesJobRouter
{
    internal class Legend
    {
        public class WorkerLegend
        {
            public static Color Active = Color.White;
            public static Color Inactive = Color.LightYellow;
            public static Color Draining = Color.MediumVioletRed;
            public static Color HasOffers = Color.Yellow;
            public static Color HasAssignedJobs = Color.LightGreen;
        }

        public class JobLegend
        {
            public static Color Assigned = Color.LightGreen;
            public static Color Cancelled = Color.LightGray;
            public static Color ClassificationFailed = Color.Orange;
            public static Color Closed = Color.DarkGray;
            public static Color Completed = Color.ForestGreen;
            public static Color Created = Color.White;
            public static Color PendingClassification = Color.BlanchedAlmond;
            public static Color PendingSchedule = Color.IndianRed;
            public static Color Queued = Color.GreenYellow;
            public static Color Scheduled = Color.PaleVioletRed;
            public static Color ScheduledFailed = Color.DarkOrange;
            public static Color WaitingForActivation = Color.CornflowerBlue;
        }
    }
}
