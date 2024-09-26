using Azure.Communication.JobRouter;
using System.Globalization;

namespace AzureCommunicationServicesJobRouter
{
    public partial class frmUpsertJob : Form
    {
        public RouterJob? Job { get; private set; } = null;

        private class DgWorkerSelectorColumnId
        {
            public const int Key = 0;
            public const int Operator = 1;
            public const int Value = 2;
            public const int ValueType = 3;
        }

        private class DgNoteColumnId
        {
            public const int Note = 0;
            public const int AddedAt = 1;
        }

        public frmUpsertJob(bool isUpdate, List<string> channelIds, List<string> queueIds, RouterJob routerJobToUpdate = null)
        {
            InitializeComponent();

            drpChannelId.Items.AddRange(channelIds.ToArray());
            drpQueueId.Items.AddRange(queueIds.ToArray());

            if (isUpdate)
            {
                FillUpdateForm(routerJobToUpdate);
            }
            else
            {
                FillCreateForm();
            }
        }

        private void FillUpdateForm(RouterJob routerJobToUpdate)
        {
            Job = routerJobToUpdate;
            Text = "Update job";
            btnUpsert.Text = "Update";
            txtJobId.ReadOnly = true;

            txtJobId.Text = routerJobToUpdate.Id;
            drpChannelId.SelectedItem = routerJobToUpdate.ChannelId;
            drpQueueId.SelectedItem = routerJobToUpdate.QueueId;

            if (routerJobToUpdate.Priority != null)
            {
                chkAddPriority.Checked = true;
                numPriority.Value = routerJobToUpdate.Priority.Value;
            }

            foreach (var selector in routerJobToUpdate.RequestedWorkerSelectors)
            {
                AddWorkerSelectorRow(selector);
            }

            foreach (var note in routerJobToUpdate.Notes)
            {
                DataGridViewRow noteRow = new DataGridViewRow();
                noteRow.CreateCells(dgNotes);
                noteRow.Cells[DgNoteColumnId.Note].Value = note.Message;
                noteRow.Cells[DgNoteColumnId.AddedAt].Value = note.AddedAt;
                dgNotes.Rows.Add(noteRow);
            }
        }

        private void FillCreateForm()
        {
            txtJobId.Text = "job-" + Helper.GetUniqueId(); ;

            //Add default selectors
            foreach (var selector in Helper.GetJobDefaultRequestedWorkerSelectors())
            {
                AddWorkerSelectorRow(selector);
            }
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Job == null)
                {
                    Job = new RouterJob(txtJobId.Text);
                }

                Job.ChannelId = drpChannelId.Text;
                Job.QueueId = drpQueueId.Text;
                Job.Priority = chkAddPriority.Checked ? (int)numPriority.Value : null;

                Job.RequestedWorkerSelectors.Clear();
                foreach (DataGridViewRow selector in dgWorkerSelector.Rows)
                {
                    if (!selector.IsNewRow)
                    {
                        LabelOperator labelOperator = GetLabelOperator(selector.Cells[DgWorkerSelectorColumnId.Operator].Value.ToString());
                        string key = selector.Cells[DgWorkerSelectorColumnId.Key].Value.ToString();
                        RouterValue routerValue = Helper.GetRouterValue(key, selector.Cells[DgWorkerSelectorColumnId.ValueType].Value.ToString(), selector.Cells[DgWorkerSelectorColumnId.Value].Value.ToString());

                        Job.RequestedWorkerSelectors.Add(new RouterWorkerSelector(key, labelOperator, routerValue));
                    }
                }

                Job.Notes.Clear();
                foreach (DataGridViewRow noteRow in dgNotes.Rows)
                {
                    if (!noteRow.IsNewRow)
                    {
                        Job.Notes.Add(new RouterJobNote(noteRow.Cells[DgNoteColumnId.Note].Value.ToString()) { AddedAt = DateTimeOffset.Parse(noteRow.Cells[DgNoteColumnId.AddedAt].Value.ToString(), CultureInfo.CurrentCulture.DateTimeFormat) });
                    }
                }

                //Job.MatchingMode =  new SuspendMode();// ScheduleAndSuspendMode(DateTimeOffset.UtcNow.AddSeconds(30));
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                Job = null;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkAddPriority_CheckedChanged(object sender, EventArgs e)
        {
            numPriority.Enabled = chkAddPriority.Checked;
        }

        private void dgNotes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgNotes.Rows[e.RowIndex].IsNewRow == false && e.ColumnIndex == 0 && dgNotes.Rows[e.RowIndex].Cells[DgNoteColumnId.AddedAt].Value == null)
            {
                dgNotes.Rows[e.RowIndex].Cells[DgNoteColumnId.AddedAt].Value = DateTimeOffset.UtcNow;
            }
        }

        private string GetLabelOperatorString(LabelOperator labelOperator)
        {
            string label = "";

            if (labelOperator.Equals(LabelOperator.Equal))
            {
                label = "=";
            }
            else if (labelOperator.Equals(LabelOperator.NotEqual))
            {
                label = "!=";
            }
            else if (labelOperator.Equals(LabelOperator.GreaterThan))
            {
                label = ">";
            }
            else if (labelOperator.Equals(LabelOperator.GreaterThanOrEqual))
            {
                label = ">=";
            }
            else if (labelOperator.Equals(LabelOperator.LessThan))
            {
                label = "<";
            }
            else if (labelOperator.Equals(LabelOperator.LessThanOrEqual))
            {
                label = "<=";
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(labelOperator), labelOperator, "Value is out of range.");
            }

            return label;
        }

        private LabelOperator GetLabelOperator(string labelOperatorString)
        {
            LabelOperator labelOperator;

            switch (labelOperatorString)
            {
                case "=":
                    labelOperator = LabelOperator.Equal;
                    break;

                case "!=":
                    labelOperator = LabelOperator.NotEqual;
                    break;

                case ">":
                    labelOperator = LabelOperator.GreaterThan;
                    break;

                case ">=":
                    labelOperator = LabelOperator.GreaterThanOrEqual;
                    break;

                case "<":
                    labelOperator = LabelOperator.LessThan;
                    break;

                case "<=":
                    labelOperator = LabelOperator.LessThanOrEqual;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(labelOperatorString), labelOperatorString, "Value is out of range.");
            }

            return labelOperator;
        }

        private void AddWorkerSelectorRow(RouterWorkerSelector selector)
        {
            DataGridViewRow workerSelectorRow = new DataGridViewRow();
            workerSelectorRow.CreateCells(dgWorkerSelector);
            workerSelectorRow.Cells[DgWorkerSelectorColumnId.Key].Value = selector.Key;
            workerSelectorRow.Cells[DgWorkerSelectorColumnId.Operator].Value = GetLabelOperatorString(selector.LabelOperator);
            workerSelectorRow.Cells[DgWorkerSelectorColumnId.Value].Value = selector.Value.Value;
            workerSelectorRow.Cells[DgWorkerSelectorColumnId.ValueType].Value = Helper.GetValueTypeString(selector.Key, selector.Value.Value);
            dgWorkerSelector.Rows.Add(workerSelectorRow);
        }
    }
}

