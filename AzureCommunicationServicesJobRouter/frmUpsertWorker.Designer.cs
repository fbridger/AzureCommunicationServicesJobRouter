namespace AzureCommunicationServicesJobRouter
{
    partial class frmUpsertWorker
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtWorkerId = new TextBox();
            numWorkerCapacity = new NumericUpDown();
            chkIsAvailableForOffers = new CheckBox();
            btnUpsert = new Button();
            lstQueues = new CheckedListBox();
            dgLabels = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colValue = new DataGridViewTextBoxColumn();
            colLabelValueType = new DataGridViewComboBoxColumn();
            dgChannels = new DataGridView();
            colChannelChecked = new DataGridViewCheckBoxColumn();
            colChannelId = new DataGridViewTextBoxColumn();
            colChannelCapacity = new DataGridViewTextBoxColumn();
            colChannelMaxNumOfJobs = new DataGridViewTextBoxColumn();
            numMaxConcurrentOffers = new NumericUpDown();
            grpMaxConcurrentOffers = new GroupBox();
            chkAddMaxConcurrentOffers = new CheckBox();
            grpAssignedQueues = new GroupBox();
            grpLabels = new GroupBox();
            grpChannels = new GroupBox();
            grpTags = new GroupBox();
            dgTags = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numWorkerCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLabels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgChannels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxConcurrentOffers).BeginInit();
            grpMaxConcurrentOffers.SuspendLayout();
            grpAssignedQueues.SuspendLayout();
            grpLabels.SuspendLayout();
            grpChannels.SuspendLayout();
            grpTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTags).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 15);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 43);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Capacity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 69);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 2;
            label3.Text = "Available for offers:";
            // 
            // txtWorkerId
            // 
            txtWorkerId.Location = new Point(147, 12);
            txtWorkerId.Name = "txtWorkerId";
            txtWorkerId.Size = new Size(230, 23);
            txtWorkerId.TabIndex = 0;
            // 
            // numWorkerCapacity
            // 
            numWorkerCapacity.Location = new Point(147, 41);
            numWorkerCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numWorkerCapacity.Name = "numWorkerCapacity";
            numWorkerCapacity.Size = new Size(230, 23);
            numWorkerCapacity.TabIndex = 1;
            numWorkerCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkIsAvailableForOffers
            // 
            chkIsAvailableForOffers.AutoSize = true;
            chkIsAvailableForOffers.Checked = true;
            chkIsAvailableForOffers.CheckState = CheckState.Checked;
            chkIsAvailableForOffers.Location = new Point(146, 70);
            chkIsAvailableForOffers.Name = "chkIsAvailableForOffers";
            chkIsAvailableForOffers.Size = new Size(15, 14);
            chkIsAvailableForOffers.TabIndex = 2;
            chkIsAvailableForOffers.UseVisualStyleBackColor = true;
            // 
            // btnUpsert
            // 
            btnUpsert.Location = new Point(550, 858);
            btnUpsert.Name = "btnUpsert";
            btnUpsert.Size = new Size(75, 23);
            btnUpsert.TabIndex = 8;
            btnUpsert.Text = "Create";
            btnUpsert.UseVisualStyleBackColor = true;
            btnUpsert.Click += btnUpsert_Click;
            // 
            // lstQueues
            // 
            lstQueues.FormattingEnabled = true;
            lstQueues.Location = new Point(6, 22);
            lstQueues.Name = "lstQueues";
            lstQueues.Size = new Size(311, 112);
            lstQueues.TabIndex = 8;
            // 
            // dgLabels
            // 
            dgLabels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLabels.Columns.AddRange(new DataGridViewColumn[] { colName, colValue, colLabelValueType });
            dgLabels.Location = new Point(6, 22);
            dgLabels.Name = "dgLabels";
            dgLabels.Size = new Size(554, 150);
            dgLabels.TabIndex = 10;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.Width = 192;
            // 
            // colValue
            // 
            colValue.HeaderText = "Value";
            colValue.Name = "colValue";
            colValue.Width = 192;
            // 
            // colLabelValueType
            // 
            colLabelValueType.HeaderText = "Value type";
            colLabelValueType.Items.AddRange(new object[] { "Number", "String", "Boolean" });
            colLabelValueType.Name = "colLabelValueType";
            // 
            // dgChannels
            // 
            dgChannels.AllowUserToDeleteRows = false;
            dgChannels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgChannels.Columns.AddRange(new DataGridViewColumn[] { colChannelChecked, colChannelId, colChannelCapacity, colChannelMaxNumOfJobs });
            dgChannels.Location = new Point(8, 22);
            dgChannels.Name = "dgChannels";
            dgChannels.Size = new Size(553, 150);
            dgChannels.TabIndex = 12;
            // 
            // colChannelChecked
            // 
            colChannelChecked.HeaderText = "Link";
            colChannelChecked.Name = "colChannelChecked";
            colChannelChecked.Width = 35;
            // 
            // colChannelId
            // 
            colChannelId.HeaderText = "Id";
            colChannelId.Name = "colChannelId";
            colChannelId.Resizable = DataGridViewTriState.True;
            colChannelId.SortMode = DataGridViewColumnSortMode.NotSortable;
            colChannelId.Width = 230;
            // 
            // colChannelCapacity
            // 
            colChannelCapacity.HeaderText = "Capacity per job";
            colChannelCapacity.Name = "colChannelCapacity";
            colChannelCapacity.Resizable = DataGridViewTriState.True;
            colChannelCapacity.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colChannelMaxNumOfJobs
            // 
            colChannelMaxNumOfJobs.HeaderText = "Max Num of Jobs";
            colChannelMaxNumOfJobs.Name = "colChannelMaxNumOfJobs";
            colChannelMaxNumOfJobs.Width = 125;
            // 
            // numMaxConcurrentOffers
            // 
            numMaxConcurrentOffers.Enabled = false;
            numMaxConcurrentOffers.Location = new Point(62, 22);
            numMaxConcurrentOffers.Name = "numMaxConcurrentOffers";
            numMaxConcurrentOffers.Size = new Size(255, 23);
            numMaxConcurrentOffers.TabIndex = 14;
            numMaxConcurrentOffers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // grpMaxConcurrentOffers
            // 
            grpMaxConcurrentOffers.Controls.Add(chkAddMaxConcurrentOffers);
            grpMaxConcurrentOffers.Controls.Add(numMaxConcurrentOffers);
            grpMaxConcurrentOffers.Location = new Point(54, 90);
            grpMaxConcurrentOffers.Name = "grpMaxConcurrentOffers";
            grpMaxConcurrentOffers.Size = new Size(323, 53);
            grpMaxConcurrentOffers.TabIndex = 3;
            grpMaxConcurrentOffers.TabStop = false;
            grpMaxConcurrentOffers.Text = "Max Concurrent Offers";
            // 
            // chkAddMaxConcurrentOffers
            // 
            chkAddMaxConcurrentOffers.AutoSize = true;
            chkAddMaxConcurrentOffers.Location = new Point(8, 23);
            chkAddMaxConcurrentOffers.Name = "chkAddMaxConcurrentOffers";
            chkAddMaxConcurrentOffers.Size = new Size(48, 19);
            chkAddMaxConcurrentOffers.TabIndex = 0;
            chkAddMaxConcurrentOffers.Text = "Add";
            chkAddMaxConcurrentOffers.UseVisualStyleBackColor = true;
            chkAddMaxConcurrentOffers.CheckedChanged += chkAddMaxConcurrentOffers_CheckedChanged;
            // 
            // grpAssignedQueues
            // 
            grpAssignedQueues.Controls.Add(lstQueues);
            grpAssignedQueues.Location = new Point(54, 149);
            grpAssignedQueues.Name = "grpAssignedQueues";
            grpAssignedQueues.Size = new Size(323, 143);
            grpAssignedQueues.TabIndex = 4;
            grpAssignedQueues.TabStop = false;
            grpAssignedQueues.Text = "Assigned queues";
            // 
            // grpLabels
            // 
            grpLabels.Controls.Add(dgLabels);
            grpLabels.Location = new Point(54, 298);
            grpLabels.Name = "grpLabels";
            grpLabels.Size = new Size(571, 180);
            grpLabels.TabIndex = 5;
            grpLabels.TabStop = false;
            grpLabels.Text = "Labels";
            // 
            // grpChannels
            // 
            grpChannels.Controls.Add(dgChannels);
            grpChannels.Location = new Point(53, 484);
            grpChannels.Name = "grpChannels";
            grpChannels.Size = new Size(572, 182);
            grpChannels.TabIndex = 6;
            grpChannels.TabStop = false;
            grpChannels.Text = "Channels";
            // 
            // grpTags
            // 
            grpTags.Controls.Add(dgTags);
            grpTags.Location = new Point(54, 672);
            grpTags.Name = "grpTags";
            grpTags.Size = new Size(571, 180);
            grpTags.TabIndex = 7;
            grpTags.TabStop = false;
            grpTags.Text = "Tags";
            // 
            // dgTags
            // 
            dgTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTags.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewComboBoxColumn1 });
            dgTags.Location = new Point(6, 22);
            dgTags.Name = "dgTags";
            dgTags.Size = new Size(554, 150);
            dgTags.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 192;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Value";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 192;
            // 
            // dataGridViewComboBoxColumn1
            // 
            dataGridViewComboBoxColumn1.HeaderText = "Value type";
            dataGridViewComboBoxColumn1.Items.AddRange(new object[] { "Number", "String", "Boolean" });
            dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // frmUpsertWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(637, 893);
            Controls.Add(grpTags);
            Controls.Add(grpChannels);
            Controls.Add(grpAssignedQueues);
            Controls.Add(grpLabels);
            Controls.Add(grpMaxConcurrentOffers);
            Controls.Add(btnUpsert);
            Controls.Add(chkIsAvailableForOffers);
            Controls.Add(numWorkerCapacity);
            Controls.Add(txtWorkerId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUpsertWorker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Worker";
            ((System.ComponentModel.ISupportInitialize)numWorkerCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLabels).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgChannels).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxConcurrentOffers).EndInit();
            grpMaxConcurrentOffers.ResumeLayout(false);
            grpMaxConcurrentOffers.PerformLayout();
            grpAssignedQueues.ResumeLayout(false);
            grpLabels.ResumeLayout(false);
            grpChannels.ResumeLayout(false);
            grpTags.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgTags).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtWorkerId;
        private NumericUpDown numWorkerCapacity;
        private CheckBox chkIsAvailableForOffers;
        private Button btnUpsert;
        private CheckedListBox lstQueues;
        private DataGridView dgLabels;
        private Label label5;
        private DataGridView dgChannels;
        private NumericUpDown numMaxConcurrentOffers;
        private Label label7;
        private GroupBox grpMaxConcurrentOffers;
        private CheckBox chkAddMaxConcurrentOffers;
        private GroupBox grpAssignedQueues;
        private GroupBox grpLabels;
        private GroupBox grpChannels;
        private DataGridViewCheckBoxColumn colChannelChecked;
        private DataGridViewTextBoxColumn colChannelId;
        private DataGridViewTextBoxColumn colChannelCapacity;
        private DataGridViewTextBoxColumn colChannelMaxNumOfJobs;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colValue;
        private DataGridViewComboBoxColumn colLabelValueType;
        private GroupBox grpTags;
        private DataGridView dgTags;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
    }
}