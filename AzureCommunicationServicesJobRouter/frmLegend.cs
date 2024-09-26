using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureCommunicationServicesJobRouter
{
    public partial class frmLegend : Form
    {
        public frmLegend()
        {
            InitializeComponent();
        }

        private void frmLegend_Load(object sender, EventArgs e)
        {
            lblWorkerActive.BackColor = Legend.WorkerLegend.Active;
            lblWorkerInactive.BackColor = Legend.WorkerLegend.Inactive;
            lblWorkerDraining.BackColor = Legend.WorkerLegend.Draining;
            lblWorkerHasJobs.BackColor = Legend.WorkerLegend.HasAssignedJobs;
            lblWorkerHasOffers.BackColor = Legend.WorkerLegend.HasOffers;

            lblJobAssigned.BackColor = Legend.JobLegend.Assigned;
            lblJobCancelled.BackColor = Legend.JobLegend.Cancelled;
            lblJobClassificationFailed.BackColor = Legend.JobLegend.ClassificationFailed;
            lblJobClosed.BackColor = Legend.JobLegend.Closed;
            lblJobCompleted.BackColor = Legend.JobLegend.Completed;
            lblJobCreated.BackColor = Legend.JobLegend.Created;
            lblJobPendingClassification.BackColor = Legend.JobLegend.PendingClassification;
            lblJobPendingSchedule.BackColor = Legend.JobLegend.PendingSchedule;
            lblJobQueued.BackColor = Legend.JobLegend.Queued;
            lblJobScheduled.BackColor = Legend.JobLegend.Scheduled;
            lblJobScheudledFailed.BackColor = Legend.JobLegend.ScheduledFailed;
            lblJobWaitingForActiviation.BackColor = Legend.JobLegend.WaitingForActivation;
        }
    }
}
