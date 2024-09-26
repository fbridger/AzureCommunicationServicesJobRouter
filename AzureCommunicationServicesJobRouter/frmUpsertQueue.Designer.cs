namespace AzureCommunicationServicesJobRouter
{
    partial class frmUpsertQueue
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
            txtQueueId = new TextBox();
            drpDistPolicy = new ComboBox();
            label3 = new Label();
            txtQueueName = new TextBox();
            btnUpsert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 15);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Distribution Policy:";
            // 
            // txtQueueId
            // 
            txtQueueId.Location = new Point(125, 12);
            txtQueueId.Name = "txtQueueId";
            txtQueueId.Size = new Size(230, 23);
            txtQueueId.TabIndex = 0;
            // 
            // drpDistPolicy
            // 
            drpDistPolicy.DropDownStyle = ComboBoxStyle.DropDownList;
            drpDistPolicy.FormattingEnabled = true;
            drpDistPolicy.Location = new Point(125, 70);
            drpDistPolicy.Name = "drpDistPolicy";
            drpDistPolicy.Size = new Size(230, 23);
            drpDistPolicy.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 44);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // txtQueueName
            // 
            txtQueueName.Location = new Point(125, 41);
            txtQueueName.Name = "txtQueueName";
            txtQueueName.Size = new Size(230, 23);
            txtQueueName.TabIndex = 1;
            // 
            // btnUpsert
            // 
            btnUpsert.Location = new Point(280, 99);
            btnUpsert.Name = "btnUpsert";
            btnUpsert.Size = new Size(75, 23);
            btnUpsert.TabIndex = 6;
            btnUpsert.Text = "Create";
            btnUpsert.UseVisualStyleBackColor = true;
            btnUpsert.Click += btnUpsert_Click;
            // 
            // frmUpsertQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 136);
            Controls.Add(btnUpsert);
            Controls.Add(txtQueueName);
            Controls.Add(label3);
            Controls.Add(drpDistPolicy);
            Controls.Add(txtQueueId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUpsertQueue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Queue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtQueueId;
        private ComboBox drpDistPolicy;
        private Label label3;
        private TextBox txtQueueName;
        private Button btnUpsert;
    }
}