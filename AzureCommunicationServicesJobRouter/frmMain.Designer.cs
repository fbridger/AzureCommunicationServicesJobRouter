namespace AzureCommunicationServicesJobRouter
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtTrace = new TextBox();
            btnStart = new Button();
            btnCreateDistPolicy = new Button();
            grpDistributionPolicies = new GroupBox();
            btnUpdateDistPolicy = new Button();
            btnDeleteDistPolicy = new Button();
            dgDistributionPolicies = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minConcurrentOffersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxConcurrentOffersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            byPassSelectorsDataGridViewCheckBoxColumn = new DataGridViewTextBoxColumn();
            kindDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expireAfterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ETag = new DataGridViewTextBoxColumn();
            distributionPolicyBindingBindingSource = new BindingSource(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            grpQueues = new GroupBox();
            btnUpdateQueue = new Button();
            dgQueues = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            distributionPolicyIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            labelsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            queueBindingBindingSource = new BindingSource(components);
            btnCreateQueue = new Button();
            btnDeleteQueue = new Button();
            tabPage2 = new TabPage();
            grpWorkers = new GroupBox();
            btnUpdateWorker = new Button();
            btnDeregisterWorker = new Button();
            btnRespondToOffer = new Button();
            btnRegisterWorker = new Button();
            btnCreateWorker = new Button();
            dgWorkers = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            offersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            assignedJobsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxConcurrentOffersDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            queuesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            channelsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            labelsDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            loadRatioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Tags = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            workerBindingBindingSource = new BindingSource(components);
            btnWorkerClearQueueAssignments = new Button();
            btnDeleteWorker = new Button();
            grpJobs = new GroupBox();
            btnUpdateJob = new Button();
            btnCreateJob = new Button();
            btnCancelJob = new Button();
            dgJobs = new DataGridView();
            idDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dispositionCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            assignmentsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enqueueAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scheduleAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            channelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            queueIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matchingModeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            requestedWorkerSelectorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jobBindingBindingSource = new BindingSource(components);
            btnDeleteJob = new Button();
            btnCloseJob = new Button();
            btnCompleteJob = new Button();
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            legendToolStripMenuItem = new ToolStripMenuItem();
            grpTraces = new GroupBox();
            grpDistributionPolicies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDistributionPolicies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)distributionPolicyBindingBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            grpQueues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgQueues).BeginInit();
            ((System.ComponentModel.ISupportInitialize)queueBindingBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            grpWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgWorkers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workerBindingBindingSource).BeginInit();
            grpJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgJobs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jobBindingBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            grpTraces.SuspendLayout();
            SuspendLayout();
            // 
            // txtTrace
            // 
            txtTrace.Location = new Point(6, 22);
            txtTrace.Multiline = true;
            txtTrace.Name = "txtTrace";
            txtTrace.ScrollBars = ScrollBars.Vertical;
            txtTrace.Size = new Size(1580, 372);
            txtTrace.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(1610, 522);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "button1";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCreateDistPolicy
            // 
            btnCreateDistPolicy.Location = new Point(6, 178);
            btnCreateDistPolicy.Name = "btnCreateDistPolicy";
            btnCreateDistPolicy.Size = new Size(110, 23);
            btnCreateDistPolicy.TabIndex = 1;
            btnCreateDistPolicy.Text = "Create";
            btnCreateDistPolicy.UseVisualStyleBackColor = true;
            btnCreateDistPolicy.Click += btnCreateDistPolicy_Click;
            // 
            // grpDistributionPolicies
            // 
            grpDistributionPolicies.Controls.Add(btnUpdateDistPolicy);
            grpDistributionPolicies.Controls.Add(btnDeleteDistPolicy);
            grpDistributionPolicies.Controls.Add(btnCreateDistPolicy);
            grpDistributionPolicies.Controls.Add(dgDistributionPolicies);
            grpDistributionPolicies.Location = new Point(6, 6);
            grpDistributionPolicies.Name = "grpDistributionPolicies";
            grpDistributionPolicies.Size = new Size(1448, 207);
            grpDistributionPolicies.TabIndex = 0;
            grpDistributionPolicies.TabStop = false;
            grpDistributionPolicies.Text = "Distribution Policies";
            // 
            // btnUpdateDistPolicy
            // 
            btnUpdateDistPolicy.Location = new Point(122, 178);
            btnUpdateDistPolicy.Name = "btnUpdateDistPolicy";
            btnUpdateDistPolicy.Size = new Size(110, 23);
            btnUpdateDistPolicy.TabIndex = 2;
            btnUpdateDistPolicy.Text = "Update";
            btnUpdateDistPolicy.UseVisualStyleBackColor = true;
            btnUpdateDistPolicy.Click += btnUpdateDistPolicy_Click;
            // 
            // btnDeleteDistPolicy
            // 
            btnDeleteDistPolicy.Location = new Point(238, 178);
            btnDeleteDistPolicy.Name = "btnDeleteDistPolicy";
            btnDeleteDistPolicy.Size = new Size(110, 23);
            btnDeleteDistPolicy.TabIndex = 3;
            btnDeleteDistPolicy.Text = "Delete";
            btnDeleteDistPolicy.UseVisualStyleBackColor = true;
            btnDeleteDistPolicy.Click += btnDeleteDistPolicy_Click;
            // 
            // dgDistributionPolicies
            // 
            dgDistributionPolicies.AllowUserToAddRows = false;
            dgDistributionPolicies.AllowUserToDeleteRows = false;
            dgDistributionPolicies.AutoGenerateColumns = false;
            dgDistributionPolicies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDistributionPolicies.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, minConcurrentOffersDataGridViewTextBoxColumn, maxConcurrentOffersDataGridViewTextBoxColumn, byPassSelectorsDataGridViewCheckBoxColumn, kindDataGridViewTextBoxColumn, expireAfterDataGridViewTextBoxColumn, ETag });
            dgDistributionPolicies.DataSource = distributionPolicyBindingBindingSource;
            dgDistributionPolicies.Location = new Point(6, 22);
            dgDistributionPolicies.Name = "dgDistributionPolicies";
            dgDistributionPolicies.ReadOnly = true;
            dgDistributionPolicies.Size = new Size(1436, 150);
            dgDistributionPolicies.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 240;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 240;
            // 
            // minConcurrentOffersDataGridViewTextBoxColumn
            // 
            minConcurrentOffersDataGridViewTextBoxColumn.DataPropertyName = "MinConcurrentOffers";
            minConcurrentOffersDataGridViewTextBoxColumn.HeaderText = "Min Concurrent Offers";
            minConcurrentOffersDataGridViewTextBoxColumn.Name = "minConcurrentOffersDataGridViewTextBoxColumn";
            minConcurrentOffersDataGridViewTextBoxColumn.ReadOnly = true;
            minConcurrentOffersDataGridViewTextBoxColumn.Width = 160;
            // 
            // maxConcurrentOffersDataGridViewTextBoxColumn
            // 
            maxConcurrentOffersDataGridViewTextBoxColumn.DataPropertyName = "MaxConcurrentOffers";
            maxConcurrentOffersDataGridViewTextBoxColumn.HeaderText = "Max Concurrent Offers";
            maxConcurrentOffersDataGridViewTextBoxColumn.Name = "maxConcurrentOffersDataGridViewTextBoxColumn";
            maxConcurrentOffersDataGridViewTextBoxColumn.ReadOnly = true;
            maxConcurrentOffersDataGridViewTextBoxColumn.Width = 160;
            // 
            // byPassSelectorsDataGridViewCheckBoxColumn
            // 
            byPassSelectorsDataGridViewCheckBoxColumn.DataPropertyName = "ByPassSelectors";
            byPassSelectorsDataGridViewCheckBoxColumn.HeaderText = "By Pass Selectors";
            byPassSelectorsDataGridViewCheckBoxColumn.Name = "byPassSelectorsDataGridViewCheckBoxColumn";
            byPassSelectorsDataGridViewCheckBoxColumn.ReadOnly = true;
            byPassSelectorsDataGridViewCheckBoxColumn.Resizable = DataGridViewTriState.True;
            byPassSelectorsDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            byPassSelectorsDataGridViewCheckBoxColumn.Width = 120;
            // 
            // kindDataGridViewTextBoxColumn
            // 
            kindDataGridViewTextBoxColumn.DataPropertyName = "Kind";
            kindDataGridViewTextBoxColumn.HeaderText = "Kind";
            kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            kindDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expireAfterDataGridViewTextBoxColumn
            // 
            expireAfterDataGridViewTextBoxColumn.DataPropertyName = "ExpireAfter";
            expireAfterDataGridViewTextBoxColumn.HeaderText = "Expire After";
            expireAfterDataGridViewTextBoxColumn.Name = "expireAfterDataGridViewTextBoxColumn";
            expireAfterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ETag
            // 
            ETag.DataPropertyName = "ETag";
            ETag.HeaderText = "ETag";
            ETag.Name = "ETag";
            ETag.ReadOnly = true;
            ETag.Width = 250;
            // 
            // distributionPolicyBindingBindingSource
            // 
            distributionPolicyBindingBindingSource.DataSource = typeof(BindingModels.DistributionPolicyBinding);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 33);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1673, 461);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(grpDistributionPolicies);
            tabPage1.Controls.Add(grpQueues);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1665, 433);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Policies & Queues";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpQueues
            // 
            grpQueues.Controls.Add(btnUpdateQueue);
            grpQueues.Controls.Add(dgQueues);
            grpQueues.Controls.Add(btnCreateQueue);
            grpQueues.Controls.Add(btnDeleteQueue);
            grpQueues.Location = new Point(6, 219);
            grpQueues.Name = "grpQueues";
            grpQueues.Size = new Size(1448, 207);
            grpQueues.TabIndex = 1;
            grpQueues.TabStop = false;
            grpQueues.Text = "Queues";
            // 
            // btnUpdateQueue
            // 
            btnUpdateQueue.Location = new Point(122, 178);
            btnUpdateQueue.Name = "btnUpdateQueue";
            btnUpdateQueue.Size = new Size(110, 23);
            btnUpdateQueue.TabIndex = 2;
            btnUpdateQueue.Text = "Update";
            btnUpdateQueue.UseVisualStyleBackColor = true;
            btnUpdateQueue.Click += btnUpdateQueue_Click;
            // 
            // dgQueues
            // 
            dgQueues.AllowUserToAddRows = false;
            dgQueues.AllowUserToDeleteRows = false;
            dgQueues.AutoGenerateColumns = false;
            dgQueues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgQueues.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, distributionPolicyIdDataGridViewTextBoxColumn, labelsDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1 });
            dgQueues.DataSource = queueBindingBindingSource;
            dgQueues.Location = new Point(6, 22);
            dgQueues.Name = "dgQueues";
            dgQueues.ReadOnly = true;
            dgQueues.Size = new Size(1436, 150);
            dgQueues.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 240;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            nameDataGridViewTextBoxColumn1.Width = 240;
            // 
            // distributionPolicyIdDataGridViewTextBoxColumn
            // 
            distributionPolicyIdDataGridViewTextBoxColumn.DataPropertyName = "DistributionPolicyId";
            distributionPolicyIdDataGridViewTextBoxColumn.HeaderText = "Distribution Policy Id";
            distributionPolicyIdDataGridViewTextBoxColumn.Name = "distributionPolicyIdDataGridViewTextBoxColumn";
            distributionPolicyIdDataGridViewTextBoxColumn.ReadOnly = true;
            distributionPolicyIdDataGridViewTextBoxColumn.Width = 240;
            // 
            // labelsDataGridViewTextBoxColumn
            // 
            labelsDataGridViewTextBoxColumn.DataPropertyName = "Labels";
            labelsDataGridViewTextBoxColumn.HeaderText = "Labels";
            labelsDataGridViewTextBoxColumn.Name = "labelsDataGridViewTextBoxColumn";
            labelsDataGridViewTextBoxColumn.ReadOnly = true;
            labelsDataGridViewTextBoxColumn.Width = 390;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ETag";
            dataGridViewTextBoxColumn1.HeaderText = "ETag";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 255;
            // 
            // queueBindingBindingSource
            // 
            queueBindingBindingSource.DataSource = typeof(BindingModels.QueueBinding);
            // 
            // btnCreateQueue
            // 
            btnCreateQueue.Location = new Point(6, 178);
            btnCreateQueue.Name = "btnCreateQueue";
            btnCreateQueue.Size = new Size(110, 23);
            btnCreateQueue.TabIndex = 1;
            btnCreateQueue.Text = "Create";
            btnCreateQueue.UseVisualStyleBackColor = true;
            btnCreateQueue.Click += btnCreateQueue_Click;
            // 
            // btnDeleteQueue
            // 
            btnDeleteQueue.Location = new Point(238, 178);
            btnDeleteQueue.Name = "btnDeleteQueue";
            btnDeleteQueue.Size = new Size(110, 23);
            btnDeleteQueue.TabIndex = 3;
            btnDeleteQueue.Text = "Delete";
            btnDeleteQueue.UseVisualStyleBackColor = true;
            btnDeleteQueue.Click += btnDeleteQueue_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(grpWorkers);
            tabPage2.Controls.Add(grpJobs);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1665, 433);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Workers & Jobs";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpWorkers
            // 
            grpWorkers.Controls.Add(btnUpdateWorker);
            grpWorkers.Controls.Add(btnDeregisterWorker);
            grpWorkers.Controls.Add(btnRespondToOffer);
            grpWorkers.Controls.Add(btnRegisterWorker);
            grpWorkers.Controls.Add(btnCreateWorker);
            grpWorkers.Controls.Add(dgWorkers);
            grpWorkers.Controls.Add(btnWorkerClearQueueAssignments);
            grpWorkers.Controls.Add(btnDeleteWorker);
            grpWorkers.Location = new Point(6, 6);
            grpWorkers.Name = "grpWorkers";
            grpWorkers.Size = new Size(1651, 207);
            grpWorkers.TabIndex = 0;
            grpWorkers.TabStop = false;
            grpWorkers.Text = "Workers";
            // 
            // btnUpdateWorker
            // 
            btnUpdateWorker.Location = new Point(122, 178);
            btnUpdateWorker.Name = "btnUpdateWorker";
            btnUpdateWorker.Size = new Size(110, 23);
            btnUpdateWorker.TabIndex = 2;
            btnUpdateWorker.Text = "Update";
            btnUpdateWorker.UseVisualStyleBackColor = true;
            btnUpdateWorker.Click += btnUpdateWorker_Click;
            // 
            // btnDeregisterWorker
            // 
            btnDeregisterWorker.Location = new Point(586, 178);
            btnDeregisterWorker.Name = "btnDeregisterWorker";
            btnDeregisterWorker.Size = new Size(110, 23);
            btnDeregisterWorker.TabIndex = 6;
            btnDeregisterWorker.Text = "Deregister";
            btnDeregisterWorker.UseVisualStyleBackColor = true;
            btnDeregisterWorker.Click += btnDeregisterWorker_Click;
            // 
            // btnRespondToOffer
            // 
            btnRespondToOffer.Location = new Point(354, 178);
            btnRespondToOffer.Name = "btnRespondToOffer";
            btnRespondToOffer.Size = new Size(110, 23);
            btnRespondToOffer.TabIndex = 4;
            btnRespondToOffer.Text = "Respond to Offer";
            btnRespondToOffer.UseVisualStyleBackColor = true;
            btnRespondToOffer.Click += btnRespondToOffer_Click;
            // 
            // btnRegisterWorker
            // 
            btnRegisterWorker.Location = new Point(470, 178);
            btnRegisterWorker.Name = "btnRegisterWorker";
            btnRegisterWorker.Size = new Size(110, 23);
            btnRegisterWorker.TabIndex = 5;
            btnRegisterWorker.Text = "Register";
            btnRegisterWorker.UseVisualStyleBackColor = true;
            btnRegisterWorker.Click += btnRegisterWorker_Click;
            // 
            // btnCreateWorker
            // 
            btnCreateWorker.Location = new Point(6, 178);
            btnCreateWorker.Name = "btnCreateWorker";
            btnCreateWorker.Size = new Size(110, 23);
            btnCreateWorker.TabIndex = 1;
            btnCreateWorker.Text = "Create";
            btnCreateWorker.UseVisualStyleBackColor = true;
            btnCreateWorker.Click += btnCreateWorker_Click;
            // 
            // dgWorkers
            // 
            dgWorkers.AllowUserToAddRows = false;
            dgWorkers.AllowUserToDeleteRows = false;
            dgWorkers.AutoGenerateColumns = false;
            dgWorkers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWorkers.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, stateDataGridViewTextBoxColumn, offersDataGridViewTextBoxColumn, assignedJobsDataGridViewTextBoxColumn, capacityDataGridViewTextBoxColumn, maxConcurrentOffersDataGridViewTextBoxColumn1, queuesDataGridViewTextBoxColumn, channelsDataGridViewTextBoxColumn, labelsDataGridViewTextBoxColumn1, loadRatioDataGridViewTextBoxColumn, Tags, dataGridViewTextBoxColumn2 });
            dgWorkers.DataSource = workerBindingBindingSource;
            dgWorkers.Location = new Point(6, 22);
            dgWorkers.Name = "dgWorkers";
            dgWorkers.ReadOnly = true;
            dgWorkers.Size = new Size(1639, 150);
            dgWorkers.TabIndex = 0;
            dgWorkers.DataBindingComplete += dgWorkers_DataBindingComplete;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.ReadOnly = true;
            idDataGridViewTextBoxColumn2.Width = 200;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "State";
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.ReadOnly = true;
            stateDataGridViewTextBoxColumn.Width = 75;
            // 
            // offersDataGridViewTextBoxColumn
            // 
            offersDataGridViewTextBoxColumn.DataPropertyName = "Offers";
            offersDataGridViewTextBoxColumn.HeaderText = "Offers";
            offersDataGridViewTextBoxColumn.Name = "offersDataGridViewTextBoxColumn";
            offersDataGridViewTextBoxColumn.ReadOnly = true;
            offersDataGridViewTextBoxColumn.Width = 130;
            // 
            // assignedJobsDataGridViewTextBoxColumn
            // 
            assignedJobsDataGridViewTextBoxColumn.DataPropertyName = "AssignedJobs";
            assignedJobsDataGridViewTextBoxColumn.HeaderText = "Assigned Jobs";
            assignedJobsDataGridViewTextBoxColumn.Name = "assignedJobsDataGridViewTextBoxColumn";
            assignedJobsDataGridViewTextBoxColumn.ReadOnly = true;
            assignedJobsDataGridViewTextBoxColumn.Width = 130;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            capacityDataGridViewTextBoxColumn.ReadOnly = true;
            capacityDataGridViewTextBoxColumn.Width = 70;
            // 
            // maxConcurrentOffersDataGridViewTextBoxColumn1
            // 
            maxConcurrentOffersDataGridViewTextBoxColumn1.DataPropertyName = "MaxConcurrentOffers";
            maxConcurrentOffersDataGridViewTextBoxColumn1.HeaderText = "Max Offers";
            maxConcurrentOffersDataGridViewTextBoxColumn1.Name = "maxConcurrentOffersDataGridViewTextBoxColumn1";
            maxConcurrentOffersDataGridViewTextBoxColumn1.ReadOnly = true;
            maxConcurrentOffersDataGridViewTextBoxColumn1.Width = 90;
            // 
            // queuesDataGridViewTextBoxColumn
            // 
            queuesDataGridViewTextBoxColumn.DataPropertyName = "Queues";
            queuesDataGridViewTextBoxColumn.HeaderText = "Queues";
            queuesDataGridViewTextBoxColumn.Name = "queuesDataGridViewTextBoxColumn";
            queuesDataGridViewTextBoxColumn.ReadOnly = true;
            queuesDataGridViewTextBoxColumn.Width = 150;
            // 
            // channelsDataGridViewTextBoxColumn
            // 
            channelsDataGridViewTextBoxColumn.DataPropertyName = "Channels";
            channelsDataGridViewTextBoxColumn.HeaderText = "Channels";
            channelsDataGridViewTextBoxColumn.Name = "channelsDataGridViewTextBoxColumn";
            channelsDataGridViewTextBoxColumn.ReadOnly = true;
            channelsDataGridViewTextBoxColumn.Width = 135;
            // 
            // labelsDataGridViewTextBoxColumn1
            // 
            labelsDataGridViewTextBoxColumn1.DataPropertyName = "Labels";
            labelsDataGridViewTextBoxColumn1.HeaderText = "Labels";
            labelsDataGridViewTextBoxColumn1.Name = "labelsDataGridViewTextBoxColumn1";
            labelsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // loadRatioDataGridViewTextBoxColumn
            // 
            loadRatioDataGridViewTextBoxColumn.DataPropertyName = "LoadRatio";
            loadRatioDataGridViewTextBoxColumn.HeaderText = "Load Ratio";
            loadRatioDataGridViewTextBoxColumn.Name = "loadRatioDataGridViewTextBoxColumn";
            loadRatioDataGridViewTextBoxColumn.ReadOnly = true;
            loadRatioDataGridViewTextBoxColumn.Width = 90;
            // 
            // Tags
            // 
            Tags.DataPropertyName = "Tags";
            Tags.HeaderText = "Tags";
            Tags.Name = "Tags";
            Tags.ReadOnly = true;
            Tags.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "ETag";
            dataGridViewTextBoxColumn2.HeaderText = "ETag";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 250;
            // 
            // workerBindingBindingSource
            // 
            workerBindingBindingSource.DataSource = typeof(BindingModels.WorkerBinding);
            // 
            // btnWorkerClearQueueAssignments
            // 
            btnWorkerClearQueueAssignments.Location = new Point(702, 178);
            btnWorkerClearQueueAssignments.Name = "btnWorkerClearQueueAssignments";
            btnWorkerClearQueueAssignments.Size = new Size(110, 23);
            btnWorkerClearQueueAssignments.TabIndex = 7;
            btnWorkerClearQueueAssignments.Text = "Clear Queues";
            btnWorkerClearQueueAssignments.UseVisualStyleBackColor = true;
            btnWorkerClearQueueAssignments.Click += btnWorkerClearQueueAssignments_Click;
            // 
            // btnDeleteWorker
            // 
            btnDeleteWorker.Location = new Point(238, 178);
            btnDeleteWorker.Name = "btnDeleteWorker";
            btnDeleteWorker.Size = new Size(110, 23);
            btnDeleteWorker.TabIndex = 3;
            btnDeleteWorker.Text = "Delete";
            btnDeleteWorker.UseVisualStyleBackColor = true;
            btnDeleteWorker.Click += btnDeleteWorker_Click;
            // 
            // grpJobs
            // 
            grpJobs.Controls.Add(btnUpdateJob);
            grpJobs.Controls.Add(btnCreateJob);
            grpJobs.Controls.Add(btnCancelJob);
            grpJobs.Controls.Add(dgJobs);
            grpJobs.Controls.Add(btnDeleteJob);
            grpJobs.Controls.Add(btnCloseJob);
            grpJobs.Controls.Add(btnCompleteJob);
            grpJobs.Location = new Point(8, 219);
            grpJobs.Name = "grpJobs";
            grpJobs.Size = new Size(1651, 207);
            grpJobs.TabIndex = 1;
            grpJobs.TabStop = false;
            grpJobs.Text = "Jobs";
            // 
            // btnUpdateJob
            // 
            btnUpdateJob.Location = new Point(122, 178);
            btnUpdateJob.Name = "btnUpdateJob";
            btnUpdateJob.Size = new Size(110, 23);
            btnUpdateJob.TabIndex = 2;
            btnUpdateJob.Text = "Update";
            btnUpdateJob.UseVisualStyleBackColor = true;
            btnUpdateJob.Click += btnUpdateJob_Click;
            // 
            // btnCreateJob
            // 
            btnCreateJob.Location = new Point(6, 178);
            btnCreateJob.Name = "btnCreateJob";
            btnCreateJob.Size = new Size(110, 23);
            btnCreateJob.TabIndex = 1;
            btnCreateJob.Text = "Create";
            btnCreateJob.UseVisualStyleBackColor = true;
            btnCreateJob.Click += btnCreateJob_Click;
            // 
            // btnCancelJob
            // 
            btnCancelJob.Location = new Point(354, 178);
            btnCancelJob.Name = "btnCancelJob";
            btnCancelJob.Size = new Size(110, 23);
            btnCancelJob.TabIndex = 4;
            btnCancelJob.Text = "Cancel Job";
            btnCancelJob.UseVisualStyleBackColor = true;
            btnCancelJob.Click += btnCancelJob_Click;
            // 
            // dgJobs
            // 
            dgJobs.AllowUserToAddRows = false;
            dgJobs.AllowUserToDeleteRows = false;
            dgJobs.AutoGenerateColumns = false;
            dgJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgJobs.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn3, statusDataGridViewTextBoxColumn, dispositionCodeDataGridViewTextBoxColumn, assignmentsDataGridViewTextBoxColumn, enqueueAtDataGridViewTextBoxColumn, scheduleAtDataGridViewTextBoxColumn, priorityDataGridViewTextBoxColumn, channelIdDataGridViewTextBoxColumn, queueIdDataGridViewTextBoxColumn, matchingModeDataGridViewTextBoxColumn, requestedWorkerSelectorDataGridViewTextBoxColumn, notesDataGridViewTextBoxColumn });
            dgJobs.DataSource = jobBindingBindingSource;
            dgJobs.Location = new Point(6, 22);
            dgJobs.Name = "dgJobs";
            dgJobs.ReadOnly = true;
            dgJobs.Size = new Size(1639, 150);
            dgJobs.TabIndex = 0;
            dgJobs.DataBindingComplete += dgJobs_DataBindingComplete;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn3.HeaderText = "Id";
            idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            idDataGridViewTextBoxColumn3.ReadOnly = true;
            idDataGridViewTextBoxColumn3.Width = 180;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 135;
            // 
            // dispositionCodeDataGridViewTextBoxColumn
            // 
            dispositionCodeDataGridViewTextBoxColumn.DataPropertyName = "DispositionCode";
            dispositionCodeDataGridViewTextBoxColumn.HeaderText = "Disposition Code";
            dispositionCodeDataGridViewTextBoxColumn.Name = "dispositionCodeDataGridViewTextBoxColumn";
            dispositionCodeDataGridViewTextBoxColumn.ReadOnly = true;
            dispositionCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // assignmentsDataGridViewTextBoxColumn
            // 
            assignmentsDataGridViewTextBoxColumn.DataPropertyName = "Assignments";
            assignmentsDataGridViewTextBoxColumn.HeaderText = "Assignments";
            assignmentsDataGridViewTextBoxColumn.Name = "assignmentsDataGridViewTextBoxColumn";
            assignmentsDataGridViewTextBoxColumn.ReadOnly = true;
            assignmentsDataGridViewTextBoxColumn.Width = 120;
            // 
            // enqueueAtDataGridViewTextBoxColumn
            // 
            enqueueAtDataGridViewTextBoxColumn.DataPropertyName = "EnqueueAt";
            dataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm";
            dataGridViewCellStyle3.NullValue = null;
            enqueueAtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            enqueueAtDataGridViewTextBoxColumn.HeaderText = "Enqueue UTC";
            enqueueAtDataGridViewTextBoxColumn.Name = "enqueueAtDataGridViewTextBoxColumn";
            enqueueAtDataGridViewTextBoxColumn.ReadOnly = true;
            enqueueAtDataGridViewTextBoxColumn.Width = 105;
            // 
            // scheduleAtDataGridViewTextBoxColumn
            // 
            scheduleAtDataGridViewTextBoxColumn.DataPropertyName = "ScheduleAt";
            dataGridViewCellStyle4.Format = "yyyy-MM-dd HH:mm";
            dataGridViewCellStyle4.NullValue = null;
            scheduleAtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            scheduleAtDataGridViewTextBoxColumn.HeaderText = "Schedule UTC";
            scheduleAtDataGridViewTextBoxColumn.Name = "scheduleAtDataGridViewTextBoxColumn";
            scheduleAtDataGridViewTextBoxColumn.ReadOnly = true;
            scheduleAtDataGridViewTextBoxColumn.Width = 105;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            priorityDataGridViewTextBoxColumn.ReadOnly = true;
            priorityDataGridViewTextBoxColumn.Width = 55;
            // 
            // channelIdDataGridViewTextBoxColumn
            // 
            channelIdDataGridViewTextBoxColumn.DataPropertyName = "ChannelId";
            channelIdDataGridViewTextBoxColumn.HeaderText = "Channel Id";
            channelIdDataGridViewTextBoxColumn.Name = "channelIdDataGridViewTextBoxColumn";
            channelIdDataGridViewTextBoxColumn.ReadOnly = true;
            channelIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // queueIdDataGridViewTextBoxColumn
            // 
            queueIdDataGridViewTextBoxColumn.DataPropertyName = "QueueId";
            queueIdDataGridViewTextBoxColumn.HeaderText = "Queue Id";
            queueIdDataGridViewTextBoxColumn.Name = "queueIdDataGridViewTextBoxColumn";
            queueIdDataGridViewTextBoxColumn.ReadOnly = true;
            queueIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // matchingModeDataGridViewTextBoxColumn
            // 
            matchingModeDataGridViewTextBoxColumn.DataPropertyName = "MatchingMode";
            matchingModeDataGridViewTextBoxColumn.HeaderText = "Matching Mode";
            matchingModeDataGridViewTextBoxColumn.Name = "matchingModeDataGridViewTextBoxColumn";
            matchingModeDataGridViewTextBoxColumn.ReadOnly = true;
            matchingModeDataGridViewTextBoxColumn.Width = 115;
            // 
            // requestedWorkerSelectorDataGridViewTextBoxColumn
            // 
            requestedWorkerSelectorDataGridViewTextBoxColumn.DataPropertyName = "RequestedWorkerSelector";
            requestedWorkerSelectorDataGridViewTextBoxColumn.HeaderText = "Req. Worker Selector";
            requestedWorkerSelectorDataGridViewTextBoxColumn.Name = "requestedWorkerSelectorDataGridViewTextBoxColumn";
            requestedWorkerSelectorDataGridViewTextBoxColumn.ReadOnly = true;
            requestedWorkerSelectorDataGridViewTextBoxColumn.Width = 160;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            notesDataGridViewTextBoxColumn.ReadOnly = true;
            notesDataGridViewTextBoxColumn.Width = 175;
            // 
            // jobBindingBindingSource
            // 
            jobBindingBindingSource.DataSource = typeof(BindingModels.JobBinding);
            // 
            // btnDeleteJob
            // 
            btnDeleteJob.Location = new Point(238, 178);
            btnDeleteJob.Name = "btnDeleteJob";
            btnDeleteJob.Size = new Size(110, 23);
            btnDeleteJob.TabIndex = 3;
            btnDeleteJob.Text = "Delete";
            btnDeleteJob.UseVisualStyleBackColor = true;
            btnDeleteJob.Click += btnDeleteJob_Click;
            // 
            // btnCloseJob
            // 
            btnCloseJob.Location = new Point(586, 178);
            btnCloseJob.Name = "btnCloseJob";
            btnCloseJob.Size = new Size(110, 23);
            btnCloseJob.TabIndex = 6;
            btnCloseJob.Text = "Close job";
            btnCloseJob.UseVisualStyleBackColor = true;
            btnCloseJob.Click += btnCloseJob_Click;
            // 
            // btnCompleteJob
            // 
            btnCompleteJob.Location = new Point(470, 178);
            btnCompleteJob.Name = "btnCompleteJob";
            btnCompleteJob.Size = new Size(110, 23);
            btnCompleteJob.TabIndex = 5;
            btnCompleteJob.Text = "Complete Job";
            btnCompleteJob.UseVisualStyleBackColor = true;
            btnCompleteJob.Click += btnCompleteJob_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1697, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, legendToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            refreshToolStripMenuItem.Size = new Size(154, 22);
            refreshToolStripMenuItem.Text = "&Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // legendToolStripMenuItem
            // 
            legendToolStripMenuItem.Name = "legendToolStripMenuItem";
            legendToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            legendToolStripMenuItem.Size = new Size(154, 22);
            legendToolStripMenuItem.Text = "&Legend";
            legendToolStripMenuItem.Click += legendToolStripMenuItem_Click;
            // 
            // grpTraces
            // 
            grpTraces.Controls.Add(txtTrace);
            grpTraces.Location = new Point(12, 500);
            grpTraces.Name = "grpTraces";
            grpTraces.Size = new Size(1592, 400);
            grpTraces.TabIndex = 30;
            grpTraces.TabStop = false;
            grpTraces.Text = "Traces";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1697, 912);
            Controls.Add(grpTraces);
            Controls.Add(tabControl1);
            Controls.Add(btnStart);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Azure Communication Services Job Router Visulaizing Tool";
            Load += frmMain_Load;
            grpDistributionPolicies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDistributionPolicies).EndInit();
            ((System.ComponentModel.ISupportInitialize)distributionPolicyBindingBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            grpQueues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgQueues).EndInit();
            ((System.ComponentModel.ISupportInitialize)queueBindingBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            grpWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgWorkers).EndInit();
            ((System.ComponentModel.ISupportInitialize)workerBindingBindingSource).EndInit();
            grpJobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgJobs).EndInit();
            ((System.ComponentModel.ISupportInitialize)jobBindingBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpTraces.ResumeLayout(false);
            grpTraces.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTrace;
        private Button btnStart;
        private Button btnCreateDistPolicy;
        private GroupBox grpDistributionPolicies;
        private Button btnDeleteDistPolicy;
        private GroupBox grpQueues;
        private Button btnDeleteQueue;
        private GroupBox grpWorkers;
        private Button btnDeleteWorker;
        private Button btnWorkerClearQueueAssignments;
        private GroupBox grpJobs;
        private Button btnCompleteJob;
        private Button btnCloseJob;
        private Button btnDeleteJob;
        private Button btnCreateQueue;
        private DataGridView dgDistributionPolicies;
        private BindingSource distributionPolicyBindingBindingSource;
        private DataGridView dgQueues;
        private BindingSource queueBindingBindingSource;
        private DataGridView dgWorkers;
        private BindingSource workerBindingBindingSource;
        private Button btnCreateWorker;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private DataGridView dgJobs;
        private BindingSource jobBindingBindingSource;
        private Button btnCancelJob;
        private Button btnCreateJob;
        private Button btnRegisterWorker;
        private Button btnRespondToOffer;
        private Button btnDeregisterWorker;
        private Button btnUpdateDistPolicy;
        private Button btnUpdateQueue;
        private Button btnUpdateWorker;
        private Button btnUpdateJob;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox grpTraces;
        private ToolStripMenuItem legendToolStripMenuItem;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minConcurrentOffersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxConcurrentOffersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn byPassSelectorsDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expireAfterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ETag;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn offersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn assignedJobsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxConcurrentOffersDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn queuesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn channelsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn labelsDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn loadRatioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Tags;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn distributionPolicyIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn labelsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dispositionCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn assignmentsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enqueueAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scheduleAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn channelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn queueIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matchingModeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn requestedWorkerSelectorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}
