using Azure.Communication.JobRouter;

namespace AzureCommunicationServicesJobRouter
{
    public partial class frmUpsertDistributionPolicy : Form
    {
        public DistributionPolicy? Policy { get; private set; } = null;

        private class DistributionPolicyKind
        {
            public const string BestWorker = "Best worker";
            public const string LongestIdle = "Longest idle";
            public const string RoundRobin = "Round robin";
        }

        public frmUpsertDistributionPolicy(bool isUpdate, DistributionPolicy distributionPolicyToUpdate = null)
        {
            InitializeComponent();

            drpMode.Items.AddRange(new string[] { DistributionPolicyKind.BestWorker, DistributionPolicyKind.LongestIdle, DistributionPolicyKind.RoundRobin });

            if (isUpdate)
            {
                FillUpdateForm(distributionPolicyToUpdate);
            }
            else
            {
                FillCreateForm();
            }
        }

        private void FillUpdateForm(DistributionPolicy distPolicyToUpdate)
        {
            Text = "Update Distribution Policy";
            btnUpsert.Text = "Update";
            txtPolicyId.Text = distPolicyToUpdate.Id;
            txtPolicyId.ReadOnly = true;
            txtPolicyName.Text = distPolicyToUpdate.Name;

            numOfferExpiry.Value = (int)distPolicyToUpdate.OfferExpiresAfter.Value.TotalSeconds;

            numMax.Value = distPolicyToUpdate.Mode.MaxConcurrentOffers;
            numMin.Value = distPolicyToUpdate.Mode.MinConcurrentOffers;
            chkByPassSelector.Checked = distPolicyToUpdate.Mode.BypassSelectors.Value;

            if (distPolicyToUpdate.Mode.Kind.ToString().Equals(DistributionModeKind.BestWorker.ToString(), StringComparison.InvariantCultureIgnoreCase))
            {
                drpMode.SelectedItem = DistributionPolicyKind.BestWorker;
            }
            else if (distPolicyToUpdate.Mode.Kind.ToString().Equals(DistributionModeKind.LongestIdle.ToString(), StringComparison.InvariantCultureIgnoreCase))
            {
                drpMode.SelectedItem = DistributionPolicyKind.LongestIdle;
            }
            else if (distPolicyToUpdate.Mode.Kind.ToString().Equals(DistributionModeKind.RoundRobin.ToString(), StringComparison.InvariantCultureIgnoreCase))
            {
                drpMode.SelectedItem = DistributionPolicyKind.RoundRobin;
            }

            Policy = distPolicyToUpdate;
        }

        private void FillCreateForm()
        {
            string uniqueId = Helper.GetUniqueId();

            txtPolicyId.Text = "distPolicy-" + uniqueId;
            txtPolicyName.Text = "Distribution Policy " + uniqueId;

            drpMode.SelectedIndex = 0;
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Policy == null)
                {
                    Policy = new DistributionPolicy(txtPolicyId.Text);
                }

                Policy.Name = txtPolicyId.Text;
                Policy.OfferExpiresAfter = TimeSpan.FromSeconds((double)numOfferExpiry.Value);

                switch (drpMode.SelectedItem.ToString())
                {
                    case DistributionPolicyKind.BestWorker:
                        Policy.Mode = new BestWorkerMode();
                        break;

                    case DistributionPolicyKind.LongestIdle:
                        Policy.Mode = new LongestIdleMode();
                        break;

                    case DistributionPolicyKind.RoundRobin:
                        Policy.Mode = new RoundRobinMode();
                        break;
                }

                Policy.Mode.MaxConcurrentOffers = (int)numMax.Value;
                Policy.Mode.MinConcurrentOffers = (int)numMin.Value;
                Policy.Mode.BypassSelectors = chkByPassSelector.Checked;
                Policy.Name = txtPolicyName.Text;

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Policy = null;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
