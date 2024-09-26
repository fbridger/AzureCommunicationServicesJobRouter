using Azure.Communication.JobRouter;
using JobRouterEventParser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureCommunicationServicesJobRouter
{
    public partial class frmUpsertWorker : Form
    {
        public RouterWorker? Worker { get; private set; } = null;

        private List<string> _labelsToSkipOnEdit = new List<string>() { "id" };

        private class DgLabelColumnId
        {
            public const int Name = 0;
            public const int Value = 1;
            public const int ValueType = 2;
        }

        private class DgTagColumnId
        {
            public const int Name = 0;
            public const int Value = 1;
            public const int ValueType = 2;
        }

        private class DgChannelColumnId
        {
            public const int Link = 0;
            public const int Id = 1;
            public const int CapacityCostPerJob = 2;
            public const int MaxNumOfJobs = 3;
        }

        public frmUpsertWorker(bool isUpdate, List<string> queueIds, List<RouterChannel> channels, RouterWorker routerWorkerToUpdate = null)
        {
            InitializeComponent();

            //Fill queues
            lstQueues.Items.AddRange(queueIds.ToArray());

            //Add channels
            foreach (var channel in channels)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgChannels);

                row.Cells[DgChannelColumnId.Id].Value = channel.ChannelId;
                row.Cells[DgChannelColumnId.CapacityCostPerJob].Value = channel.CapacityCostPerJob;
                row.Cells[DgChannelColumnId.MaxNumOfJobs].Value = channel.MaxNumberOfJobs ?? null;

                dgChannels.Rows.Add(row);
            }

            if (isUpdate)
            {
                FillUpdateForm(routerWorkerToUpdate);
            }
            else
            {
                FillCreateForm();
            }
        }

        private void FillUpdateForm(RouterWorker routerWorkerToUpdate)
        {
            Worker = routerWorkerToUpdate;

            Text = "Update Worker";
            btnUpsert.Text = "Update";
            txtWorkerId.ReadOnly = true;

            txtWorkerId.Text = routerWorkerToUpdate.Id;
            numWorkerCapacity.Value = routerWorkerToUpdate.Capacity.Value;

            if (routerWorkerToUpdate.MaxConcurrentOffers != null)
            {
                chkAddMaxConcurrentOffers.Checked = true;
                numMaxConcurrentOffers.Value = routerWorkerToUpdate.MaxConcurrentOffers.Value;
            }

            chkIsAvailableForOffers.Checked = routerWorkerToUpdate.AvailableForOffers == null ? false : routerWorkerToUpdate.AvailableForOffers.Value;

            //Check assigned queues
            List<int> assignedQueuesIndex = GetAssignedQueuesIndex(routerWorkerToUpdate.Queues);
            foreach (var queueIndex in assignedQueuesIndex)
            {
                lstQueues.SetItemChecked(queueIndex, true);
            }

            //Fill Labels
            foreach (var label in routerWorkerToUpdate.Labels)
            {
                //Skip id label to prevent duplicates
                if (!_labelsToSkipOnEdit.Contains(label.Key.ToLower()))
                {
                    AddLabelRow(label);
                }
            }

            //Check assigned channels
            foreach (DataGridViewRow channelRow in dgChannels.Rows)
            {
                if (channelRow.IsNewRow == false && routerWorkerToUpdate.Channels.Any(c => c.ChannelId == channelRow.Cells[DgChannelColumnId.Id].Value.ToString()))
                {
                    ((DataGridViewCheckBoxCell)channelRow.Cells[DgChannelColumnId.Link]).Value = true;
                }
            }

            //Fill Tags
            foreach (var tag in routerWorkerToUpdate.Tags)
            {
                AddTagRow(tag);
            }
        }

        private void FillCreateForm()
        {
            txtWorkerId.Text = "worker-" + Helper.GetUniqueId();

            //Add default skills
            foreach (var label in Helper.GetWorkerDefaultLabels())
            {
                AddLabelRow(label);
            }
        }

        private List<int> GetAssignedQueuesIndex(IList<string> assignedQueuesId)
        {
            List<int> assignedQueuesIndex = new List<int>();

            for (int i = 0; i < lstQueues.Items.Count; i++)
            {
                if (assignedQueuesId.Contains(lstQueues.Items[i]))
                {
                    assignedQueuesIndex.Add(i);
                }
            }

            return assignedQueuesIndex;
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Worker == null)
                {
                    Worker = new RouterWorker(txtWorkerId.Text);
                }

                Worker.AvailableForOffers = chkIsAvailableForOffers.Checked;
                Worker.Capacity = (int)numWorkerCapacity.Value;
                Worker.MaxConcurrentOffers = chkAddMaxConcurrentOffers.Checked ? (int)numMaxConcurrentOffers.Value : null;

                Worker.Queues.Clear();
                foreach (var queue in lstQueues.CheckedItems)
                {
                    Worker.Queues.Add(queue.ToString());
                }

                Worker.Labels.Clear();
                foreach (DataGridViewRow labelRow in dgLabels.Rows)
                {
                    if (labelRow.IsNewRow == false)
                    {
                        string labelName = labelRow.Cells[DgLabelColumnId.Name].Value.ToString();
                        string labelValue = labelRow.Cells[DgLabelColumnId.Value].Value.ToString();
                        string labelValueType = labelRow.Cells[DgLabelColumnId.ValueType].Value.ToString();

                        Worker.Labels.Add(Helper.GetRouterValueEntry(labelName, labelValue, labelValueType));
                    }
                }

                Worker.Channels.Clear();
                foreach (DataGridViewRow channelRow in dgChannels.Rows)
                {
                    if (channelRow.IsNewRow == false && channelRow.Cells[DgChannelColumnId.Link].Value != null && (bool)channelRow.Cells[DgChannelColumnId.Link].Value == true)
                    {
                        string channelId = channelRow.Cells[DgChannelColumnId.Id].Value.ToString();
                        int capacityPerJob = Convert.ToInt32(channelRow.Cells[DgChannelColumnId.CapacityCostPerJob].Value);
                        int? maxNumberOfJobs = channelRow.Cells[DgChannelColumnId.MaxNumOfJobs].Value == null ? null : Convert.ToInt32(channelRow.Cells[DgChannelColumnId.MaxNumOfJobs].Value);

                        Worker.Channels.Add(new RouterChannel(channelId, capacityPerJob) { MaxNumberOfJobs = maxNumberOfJobs });
                    }
                }

                Worker.Tags.Clear();
                foreach (DataGridViewRow tagRow in dgTags.Rows)
                {
                    if (tagRow.IsNewRow == false)
                    {
                        string tageName = tagRow.Cells[DgTagColumnId.Name].Value.ToString();
                        string tagValue = tagRow.Cells[DgTagColumnId.Value].Value.ToString();
                        string tagValueType = tagRow.Cells[DgTagColumnId.ValueType].Value.ToString();

                        Worker.Tags.Add(Helper.GetRouterValueEntry(tageName, tagValue, tagValueType));
                    }
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Worker = null;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkAddMaxConcurrentOffers_CheckedChanged(object sender, EventArgs e)
        {
            numMaxConcurrentOffers.Enabled = chkAddMaxConcurrentOffers.Checked;
        }

        private void AddLabelRow(KeyValuePair<string, RouterValue> label)
        {
            DataGridViewRow labelRow = new DataGridViewRow();
            labelRow.CreateCells(dgLabels);
            labelRow.Cells[DgLabelColumnId.Name].Value = label.Key;
            labelRow.Cells[DgLabelColumnId.Value].Value = label.Value.Value;
            labelRow.Cells[DgLabelColumnId.ValueType].Value = Helper.GetValueTypeString(label.Key, label.Value.Value);
            dgLabels.Rows.Add(labelRow);
        }

        private void AddTagRow(KeyValuePair<string, RouterValue> tag)
        {
            DataGridViewRow tagRow = new DataGridViewRow();
            tagRow.CreateCells(dgTags);
            tagRow.Cells[DgLabelColumnId.Name].Value = tag.Key;
            tagRow.Cells[DgLabelColumnId.Value].Value = tag.Value.Value;
            tagRow.Cells[DgLabelColumnId.ValueType].Value = Helper.GetValueTypeString(tag.Key, tag.Value.Value);
            dgTags.Rows.Add(tagRow);
        }
    }
}
