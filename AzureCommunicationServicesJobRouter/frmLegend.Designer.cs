namespace AzureCommunicationServicesJobRouter
{
    partial class frmLegend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpWorker = new GroupBox();
            lblWorkerInactive = new Label();
            lblWorkerActive = new Label();
            lblWorkerHasJobs = new Label();
            lblWorkerHasOffers = new Label();
            lblWorkerDraining = new Label();
            grpJob = new GroupBox();
            lblJobWaitingForActiviation = new Label();
            lblJobScheudledFailed = new Label();
            lblJobScheduled = new Label();
            lblJobQueued = new Label();
            lblJobPendingSchedule = new Label();
            lblJobPendingClassification = new Label();
            lblJobCreated = new Label();
            lblJobCompleted = new Label();
            lblJobClosed = new Label();
            lblJobClassificationFailed = new Label();
            lblJobCancelled = new Label();
            lblJobAssigned = new Label();
            grpWorker.SuspendLayout();
            grpJob.SuspendLayout();
            SuspendLayout();
            // 
            // grpWorker
            // 
            grpWorker.Controls.Add(lblWorkerInactive);
            grpWorker.Controls.Add(lblWorkerActive);
            grpWorker.Controls.Add(lblWorkerHasJobs);
            grpWorker.Controls.Add(lblWorkerHasOffers);
            grpWorker.Controls.Add(lblWorkerDraining);
            grpWorker.Location = new Point(12, 12);
            grpWorker.Name = "grpWorker";
            grpWorker.Size = new Size(792, 60);
            grpWorker.TabIndex = 0;
            grpWorker.TabStop = false;
            grpWorker.Text = "Worker";
            // 
            // lblWorkerInactive
            // 
            lblWorkerInactive.BorderStyle = BorderStyle.FixedSingle;
            lblWorkerInactive.Location = new Point(474, 19);
            lblWorkerInactive.Name = "lblWorkerInactive";
            lblWorkerInactive.Size = new Size(150, 23);
            lblWorkerInactive.TabIndex = 2;
            lblWorkerInactive.Text = "Inactive";
            lblWorkerInactive.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWorkerActive
            // 
            lblWorkerActive.BorderStyle = BorderStyle.FixedSingle;
            lblWorkerActive.Location = new Point(324, 19);
            lblWorkerActive.Name = "lblWorkerActive";
            lblWorkerActive.Size = new Size(144, 23);
            lblWorkerActive.TabIndex = 1;
            lblWorkerActive.Text = "Active";
            lblWorkerActive.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWorkerHasJobs
            // 
            lblWorkerHasJobs.BorderStyle = BorderStyle.FixedSingle;
            lblWorkerHasJobs.Location = new Point(162, 19);
            lblWorkerHasJobs.Name = "lblWorkerHasJobs";
            lblWorkerHasJobs.Size = new Size(156, 23);
            lblWorkerHasJobs.TabIndex = 5;
            lblWorkerHasJobs.Text = "Has jobs";
            lblWorkerHasJobs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWorkerHasOffers
            // 
            lblWorkerHasOffers.BorderStyle = BorderStyle.FixedSingle;
            lblWorkerHasOffers.Location = new Point(6, 19);
            lblWorkerHasOffers.Name = "lblWorkerHasOffers";
            lblWorkerHasOffers.Size = new Size(150, 23);
            lblWorkerHasOffers.TabIndex = 4;
            lblWorkerHasOffers.Text = "Has offers";
            lblWorkerHasOffers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWorkerDraining
            // 
            lblWorkerDraining.BorderStyle = BorderStyle.FixedSingle;
            lblWorkerDraining.Location = new Point(630, 19);
            lblWorkerDraining.Name = "lblWorkerDraining";
            lblWorkerDraining.Size = new Size(150, 23);
            lblWorkerDraining.TabIndex = 3;
            lblWorkerDraining.Text = "Draining";
            lblWorkerDraining.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpJob
            // 
            grpJob.Controls.Add(lblJobWaitingForActiviation);
            grpJob.Controls.Add(lblJobScheudledFailed);
            grpJob.Controls.Add(lblJobScheduled);
            grpJob.Controls.Add(lblJobQueued);
            grpJob.Controls.Add(lblJobPendingSchedule);
            grpJob.Controls.Add(lblJobPendingClassification);
            grpJob.Controls.Add(lblJobCreated);
            grpJob.Controls.Add(lblJobCompleted);
            grpJob.Controls.Add(lblJobClosed);
            grpJob.Controls.Add(lblJobClassificationFailed);
            grpJob.Controls.Add(lblJobCancelled);
            grpJob.Controls.Add(lblJobAssigned);
            grpJob.Location = new Point(12, 78);
            grpJob.Name = "grpJob";
            grpJob.Size = new Size(792, 107);
            grpJob.TabIndex = 0;
            grpJob.TabStop = false;
            grpJob.Text = "Job";
            // 
            // lblJobWaitingForActiviation
            // 
            lblJobWaitingForActiviation.BorderStyle = BorderStyle.FixedSingle;
            lblJobWaitingForActiviation.Location = new Point(162, 75);
            lblJobWaitingForActiviation.Name = "lblJobWaitingForActiviation";
            lblJobWaitingForActiviation.Size = new Size(150, 23);
            lblJobWaitingForActiviation.TabIndex = 17;
            lblJobWaitingForActiviation.Text = "Waiting for activiation";
            lblJobWaitingForActiviation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJobScheudledFailed
            // 
            lblJobScheudledFailed.BorderStyle = BorderStyle.FixedSingle;
            lblJobScheudledFailed.Location = new Point(6, 75);
            lblJobScheudledFailed.Name = "lblJobScheudledFailed";
            lblJobScheudledFailed.Size = new Size(150, 23);
            lblJobScheudledFailed.TabIndex = 16;
            lblJobScheudledFailed.Text = "Scheulded failed";
            lblJobScheudledFailed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJobScheduled
            // 
            lblJobScheduled.BorderStyle = BorderStyle.FixedSingle;
            lblJobScheduled.Location = new Point(630, 47);
            lblJobScheduled.Name = "lblJobScheduled";
            lblJobScheduled.Size = new Size(150, 23);
            lblJobScheduled.TabIndex = 15;
            lblJobScheduled.Text = "Scheduled";
            lblJobScheduled.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJobQueued
            // 
            lblJobQueued.BorderStyle = BorderStyle.FixedSingle;
            lblJobQueued.Location = new Point(474, 47);
            lblJobQueued.Name = "lblJobQueued";
            lblJobQueued.Size = new Size(150, 23);
            lblJobQueued.TabIndex = 14;
            lblJobQueued.Text = "Queued";
            lblJobQueued.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJobPendingSchedule
            // 
            lblJobPendingSchedule.BorderStyle = BorderStyle.FixedSingle;
            lblJobPendingSchedule.Location = new Point(318, 47);
            lblJobPendingSchedule.Name = "lblJobPendingSchedule";
            lblJobPendingSchedule.Size = new Size(150, 23);
            lblJobPendingSchedule.TabIndex = 13;
            lblJobPendingSchedule.Text = "Pending schedule";
            lblJobPendingSchedule.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJobPendingClassification
            // 
            lblJobPendingClassification.BorderStyle = BorderStyle.FixedSingle;
            lblJobPendingClassification.Location = new Point(162, 47);
            lblJobPendingClassification.Name = "lblJobPendingClassification";
            lblJobPendingClassification.Size = new Size(150, 23);
            lblJobPendingClassification.TabIndex = 12;
            lblJobPendingClassification.Text = "Pending classification";
            lblJobPendingClassification.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJobCreated
            // 
            lblJobCreated.BorderStyle = BorderStyle.FixedSingle;
            lblJobCreated.Location = new Point(6, 47);
            lblJobCreated.Name = "lblJobCreated";
            lblJobCreated.Size = new Size(150, 23);
            lblJobCreated.TabIndex = 11;
            lblJobCreated.Text = "Created";
            lblJobCreated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJobCompleted
            // 
            lblJobCompleted.BorderStyle = BorderStyle.FixedSingle;
            lblJobCompleted.Location = new Point(630, 19);
            lblJobCompleted.Name = "lblJobCompleted";
            lblJobCompleted.Size = new Size(150, 23);
            lblJobCompleted.TabIndex = 10;
            lblJobCompleted.Text = "Completed";
            lblJobCompleted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJobClosed
            // 
            lblJobClosed.BorderStyle = BorderStyle.FixedSingle;
            lblJobClosed.Location = new Point(474, 19);
            lblJobClosed.Name = "lblJobClosed";
            lblJobClosed.Size = new Size(150, 23);
            lblJobClosed.TabIndex = 9;
            lblJobClosed.Text = "Closed";
            lblJobClosed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJobClassificationFailed
            // 
            lblJobClassificationFailed.BorderStyle = BorderStyle.FixedSingle;
            lblJobClassificationFailed.Location = new Point(318, 19);
            lblJobClassificationFailed.Name = "lblJobClassificationFailed";
            lblJobClassificationFailed.Size = new Size(150, 23);
            lblJobClassificationFailed.TabIndex = 8;
            lblJobClassificationFailed.Text = "Classification failed";
            lblJobClassificationFailed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJobCancelled
            // 
            lblJobCancelled.BorderStyle = BorderStyle.FixedSingle;
            lblJobCancelled.Location = new Point(162, 19);
            lblJobCancelled.Name = "lblJobCancelled";
            lblJobCancelled.Size = new Size(150, 23);
            lblJobCancelled.TabIndex = 7;
            lblJobCancelled.Text = "Cancelled";
            lblJobCancelled.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJobAssigned
            // 
            lblJobAssigned.BorderStyle = BorderStyle.FixedSingle;
            lblJobAssigned.Location = new Point(6, 19);
            lblJobAssigned.Name = "lblJobAssigned";
            lblJobAssigned.Size = new Size(150, 23);
            lblJobAssigned.TabIndex = 6;
            lblJobAssigned.Text = "Assigned";
            lblJobAssigned.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLegend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(814, 196);
            Controls.Add(grpJob);
            Controls.Add(grpWorker);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLegend";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Legend";
            Load += frmLegend_Load;
            grpWorker.ResumeLayout(false);
            grpJob.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpWorker;
        private Label lblWorkerInactive;
        private Label lblWorkerActive;
        private GroupBox grpJob;
        private Label lblWorkerHasJobs;
        private Label lblWorkerHasOffers;
        private Label lblWorkerDraining;
        private Label lblJobAssigned;
        private Label lblJobCreated;
        private Label lblJobCompleted;
        private Label lblJobClosed;
        private Label lblJobClassificationFailed;
        private Label lblJobCancelled;
        private Label lblJobWaitingForActiviation;
        private Label lblJobScheudledFailed;
        private Label lblJobScheduled;
        private Label lblJobQueued;
        private Label lblJobPendingSchedule;
        private Label lblJobPendingClassification;
    }
}