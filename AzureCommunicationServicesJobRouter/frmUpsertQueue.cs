using Azure.Communication.JobRouter;
using System;
using System.Collections;
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
    public partial class frmUpsertQueue : Form
    {
        public RouterQueue? Queue { get; private set; } = null;

        public frmUpsertQueue(bool isUpdate, List<string> policyIds, RouterQueue queueToUpdate = null)
        {
            InitializeComponent();

            drpDistPolicy.DataSource = policyIds;

            if (isUpdate)
            {
                FillUpdateForm(queueToUpdate);
            }
            else
            {
                FillCreateQueue();
            }
        }

        private void FillUpdateForm(RouterQueue queueToUpdate)
        {
            Queue = queueToUpdate;

            txtQueueId.Text = queueToUpdate.Id;
            txtQueueName.Text = queueToUpdate.Name;
            drpDistPolicy.SelectedItem = queueToUpdate.DistributionPolicyId;

            txtQueueId.ReadOnly = true;

            Text = "Update Queue";
            btnUpsert.Text = "Update";
        }

        private void FillCreateQueue()
        {
            string uniqueId = Helper.GetUniqueId();

            txtQueueId.Text = "queue-" + uniqueId;
            txtQueueName.Text = "Queue " + uniqueId;
            drpDistPolicy.SelectedIndex = 0;
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Queue == null)
                {
                    Queue = new RouterQueue(txtQueueId.Text);
                }

                Queue.DistributionPolicyId = drpDistPolicy.Text;
                Queue.Name = txtQueueName.Text;
                
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Queue = null;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
