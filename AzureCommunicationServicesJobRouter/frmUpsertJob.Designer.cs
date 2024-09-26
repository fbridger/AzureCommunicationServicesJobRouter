namespace AzureCommunicationServicesJobRouter
{
    partial class frmUpsertJob
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtJobId = new TextBox();
            drpChannelId = new ComboBox();
            drpQueueId = new ComboBox();
            btnUpsert = new Button();
            grpPriority = new GroupBox();
            numPriority = new NumericUpDown();
            chkAddPriority = new CheckBox();
            dgWorkerSelector = new DataGridView();
            colSelectorKey = new DataGridViewTextBoxColumn();
            colSelectorOperator = new DataGridViewComboBoxColumn();
            colSelectorValue = new DataGridViewTextBoxColumn();
            colSelectorValueType = new DataGridViewComboBoxColumn();
            grpRequestedWorkerSelectors = new GroupBox();
            grpNotes = new GroupBox();
            dgNotes = new DataGridView();
            colNoteValue = new DataGridViewTextBoxColumn();
            colNoteAddedAt = new DataGridViewTextBoxColumn();
            grpPriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPriority).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgWorkerSelector).BeginInit();
            grpRequestedWorkerSelectors.SuspendLayout();
            grpNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgNotes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Job Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 38);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Channel Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 67);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "QueueId";
            // 
            // txtJobId
            // 
            txtJobId.Location = new Point(94, 6);
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(230, 23);
            txtJobId.TabIndex = 0;
            // 
            // drpChannelId
            // 
            drpChannelId.DropDownStyle = ComboBoxStyle.DropDownList;
            drpChannelId.FormattingEnabled = true;
            drpChannelId.Location = new Point(94, 35);
            drpChannelId.Name = "drpChannelId";
            drpChannelId.Size = new Size(230, 23);
            drpChannelId.TabIndex = 1;
            // 
            // drpQueueId
            // 
            drpQueueId.DropDownStyle = ComboBoxStyle.DropDownList;
            drpQueueId.FormattingEnabled = true;
            drpQueueId.Location = new Point(94, 64);
            drpQueueId.Name = "drpQueueId";
            drpQueueId.Size = new Size(230, 23);
            drpQueueId.TabIndex = 2;
            // 
            // btnUpsert
            // 
            btnUpsert.Location = new Point(434, 523);
            btnUpsert.Name = "btnUpsert";
            btnUpsert.Size = new Size(75, 23);
            btnUpsert.TabIndex = 5;
            btnUpsert.Text = "Create";
            btnUpsert.UseVisualStyleBackColor = true;
            btnUpsert.Click += btnUpsert_Click;
            // 
            // grpPriority
            // 
            grpPriority.Controls.Add(numPriority);
            grpPriority.Controls.Add(chkAddPriority);
            grpPriority.Location = new Point(36, 93);
            grpPriority.Name = "grpPriority";
            grpPriority.Size = new Size(288, 51);
            grpPriority.TabIndex = 3;
            grpPriority.TabStop = false;
            grpPriority.Text = "Priority";
            // 
            // numPriority
            // 
            numPriority.Enabled = false;
            numPriority.Location = new Point(110, 18);
            numPriority.Name = "numPriority";
            numPriority.Size = new Size(120, 23);
            numPriority.TabIndex = 1;
            // 
            // chkAddPriority
            // 
            chkAddPriority.AutoSize = true;
            chkAddPriority.Location = new Point(3, 19);
            chkAddPriority.Name = "chkAddPriority";
            chkAddPriority.Size = new Size(89, 19);
            chkAddPriority.TabIndex = 0;
            chkAddPriority.Text = "Add priority";
            chkAddPriority.UseVisualStyleBackColor = true;
            chkAddPriority.CheckedChanged += chkAddPriority_CheckedChanged;
            // 
            // dgWorkerSelector
            // 
            dgWorkerSelector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWorkerSelector.Columns.AddRange(new DataGridViewColumn[] { colSelectorKey, colSelectorOperator, colSelectorValue, colSelectorValueType });
            dgWorkerSelector.Location = new Point(6, 22);
            dgWorkerSelector.Name = "dgWorkerSelector";
            dgWorkerSelector.Size = new Size(461, 150);
            dgWorkerSelector.TabIndex = 9;
            // 
            // colSelectorKey
            // 
            colSelectorKey.HeaderText = "Key";
            colSelectorKey.Name = "colSelectorKey";
            // 
            // colSelectorOperator
            // 
            colSelectorOperator.HeaderText = "Operator";
            colSelectorOperator.Items.AddRange(new object[] { "==", "!=", ">", ">=", "<", "<=" });
            colSelectorOperator.Name = "colSelectorOperator";
            colSelectorOperator.Resizable = DataGridViewTriState.True;
            colSelectorOperator.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colSelectorValue
            // 
            colSelectorValue.HeaderText = "Value";
            colSelectorValue.Name = "colSelectorValue";
            // 
            // colSelectorValueType
            // 
            colSelectorValueType.HeaderText = "Value type";
            colSelectorValueType.Items.AddRange(new object[] { "Number", "String", "Boolean" });
            colSelectorValueType.Name = "colSelectorValueType";
            // 
            // grpRequestedWorkerSelectors
            // 
            grpRequestedWorkerSelectors.Controls.Add(dgWorkerSelector);
            grpRequestedWorkerSelectors.Location = new Point(36, 150);
            grpRequestedWorkerSelectors.Name = "grpRequestedWorkerSelectors";
            grpRequestedWorkerSelectors.Size = new Size(473, 182);
            grpRequestedWorkerSelectors.TabIndex = 4;
            grpRequestedWorkerSelectors.TabStop = false;
            grpRequestedWorkerSelectors.Text = "Requested worker selectors";
            // 
            // grpNotes
            // 
            grpNotes.Controls.Add(dgNotes);
            grpNotes.Location = new Point(36, 338);
            grpNotes.Name = "grpNotes";
            grpNotes.Size = new Size(473, 179);
            grpNotes.TabIndex = 6;
            grpNotes.TabStop = false;
            grpNotes.Text = "Notes";
            // 
            // dgNotes
            // 
            dgNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNotes.Columns.AddRange(new DataGridViewColumn[] { colNoteValue, colNoteAddedAt });
            dgNotes.Location = new Point(3, 19);
            dgNotes.Name = "dgNotes";
            dgNotes.Size = new Size(464, 150);
            dgNotes.TabIndex = 0;
            dgNotes.CellEndEdit += dgNotes_CellEndEdit;
            // 
            // colNoteValue
            // 
            colNoteValue.HeaderText = "Note";
            colNoteValue.Name = "colNoteValue";
            colNoteValue.Width = 270;
            // 
            // colNoteAddedAt
            // 
            dataGridViewCellStyle1.Format = "yyyy-MM-dd HH:mm:ss";
            dataGridViewCellStyle1.NullValue = null;
            colNoteAddedAt.DefaultCellStyle = dataGridViewCellStyle1;
            colNoteAddedAt.HeaderText = "Added at (UTC)";
            colNoteAddedAt.Name = "colNoteAddedAt";
            colNoteAddedAt.ReadOnly = true;
            colNoteAddedAt.Width = 130;
            // 
            // frmUpsertJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(519, 558);
            Controls.Add(grpNotes);
            Controls.Add(grpRequestedWorkerSelectors);
            Controls.Add(grpPriority);
            Controls.Add(btnUpsert);
            Controls.Add(drpQueueId);
            Controls.Add(drpChannelId);
            Controls.Add(txtJobId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUpsertJob";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Job";
            grpPriority.ResumeLayout(false);
            grpPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPriority).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgWorkerSelector).EndInit();
            grpRequestedWorkerSelectors.ResumeLayout(false);
            grpNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtJobId;
        private ComboBox drpChannelId;
        private ComboBox drpQueueId;
        private Button btnUpsert;
        private GroupBox grpPriority;
        private NumericUpDown numPriority;
        private CheckBox chkAddPriority;
        private DataGridView dgWorkerSelector;
        private GroupBox grpRequestedWorkerSelectors;
        private GroupBox grpNotes;
        private DataGridView dgNotes;
        private DataGridViewTextBoxColumn colSelectorKey;
        private DataGridViewComboBoxColumn colSelectorOperator;
        private DataGridViewTextBoxColumn colSelectorValue;
        private DataGridViewComboBoxColumn colSelectorValueType;
        private DataGridViewTextBoxColumn colNoteValue;
        private DataGridViewTextBoxColumn colNoteAddedAt;
    }
}