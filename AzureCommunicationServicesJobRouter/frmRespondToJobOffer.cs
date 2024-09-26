using AzureCommunicationServicesJobRouter.Models;
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
    public partial class frmRespondToJobOffer : Form
    {
        public RespondToJobOfferResponse JobOfferRespone { get; private set; }

        private class DgOfferColumnId
        {
            public const int OfferId = 0;
            public const int JobId = 1;
            public const int CapacityCost = 2;
            public const int OfferedAt = 3;
            public const int ExpiresAt = 4;
        }

        public frmRespondToJobOffer(List<frmMain.WorkerOfferCustom> workerOfferCustom)
        {
            InitializeComponent();

            JobOfferRespone = null;

            foreach (var offer in workerOfferCustom)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgOffers);

                row.Cells[DgOfferColumnId.OfferId].Value = offer.OfferId;
                row.Cells[DgOfferColumnId.JobId].Value = offer.JobId;
                row.Cells[DgOfferColumnId.CapacityCost].Value = offer.CapacityCost;
                row.Cells[DgOfferColumnId.OfferedAt].Value = offer.OfferedAt.ToString("yyyy-MM-dd HH:mm:ss");
                row.Cells[DgOfferColumnId.ExpiresAt].Value = offer.ExpiresAt.ToString("yyyy-MM-dd HH:mm:ss");

                dgOffers.Rows.Add(row);
            }
        }

        private void btnRespond_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            JobOfferRespone = new RespondToJobOfferResponse()
            {
                OfferId = dgOffers.SelectedRows[0].Cells[DgOfferColumnId.OfferId].Value.ToString(),
                JobId = dgOffers.SelectedRows[0].Cells[DgOfferColumnId.JobId].Value.ToString(),
                AcceptOffer = rdoAccept.Checked,
                RetryAfter = rdoDecline.Checked && chkDeclineRetryAfter.Checked ? DateTimeOffset.UtcNow.AddSeconds((double)numRetryAfterSeconds.Value) : null
            };

            Close();
        }

        private void rdoDecline_CheckedChanged(object sender, EventArgs e)
        {
            grpDeclineOffer.Enabled = rdoDecline.Checked;
        }

        private void chkDeclineRetryAfter_CheckedChanged(object sender, EventArgs e)
        {
            numRetryAfterSeconds.Enabled = chkDeclineRetryAfter.Checked;
        }
    }
}
