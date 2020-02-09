namespace MoneyTracker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rbPayment = new System.Windows.Forms.RadioButton();
            this.rbIncome = new System.Windows.Forms.RadioButton();
            this.dgvMyTransaction = new System.Windows.Forms.DataGridView();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataSet1 = new MoneyTracker.DataSet1();
            this.transactionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTableTableAdapter = new MoneyTracker.DataSet1TableAdapters.TransactionTableTableAdapter();
            this.transactionValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.counterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Location = new System.Drawing.Point(130, 56);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(541, 22);
            this.txtTransactionAmount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(130, 105);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(541, 83);
            this.txtDescription.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(130, 215);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(241, 22);
            this.dtpDate.TabIndex = 5;
            // 
            // rbPayment
            // 
            this.rbPayment.AutoSize = true;
            this.rbPayment.Checked = true;
            this.rbPayment.Location = new System.Drawing.Point(130, 263);
            this.rbPayment.Name = "rbPayment";
            this.rbPayment.Size = new System.Drawing.Size(84, 21);
            this.rbPayment.TabIndex = 6;
            this.rbPayment.TabStop = true;
            this.rbPayment.Text = "Payment";
            this.rbPayment.UseVisualStyleBackColor = true;
            // 
            // rbIncome
            // 
            this.rbIncome.AutoSize = true;
            this.rbIncome.Location = new System.Drawing.Point(243, 263);
            this.rbIncome.Name = "rbIncome";
            this.rbIncome.Size = new System.Drawing.Size(74, 21);
            this.rbIncome.TabIndex = 7;
            this.rbIncome.Text = "Income";
            this.rbIncome.UseVisualStyleBackColor = true;
            // 
            // dgvMyTransaction
            // 
            this.dgvMyTransaction.AutoGenerateColumns = false;
            this.dgvMyTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionValueDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.transDateDataGridViewTextBoxColumn,
            this.transTypeDataGridViewCheckBoxColumn,
            this.counterIDDataGridViewTextBoxColumn});
            this.dgvMyTransaction.DataSource = this.transactionTableBindingSource;
            this.dgvMyTransaction.Location = new System.Drawing.Point(130, 369);
            this.dgvMyTransaction.Name = "dgvMyTransaction";
            this.dgvMyTransaction.RowHeadersWidth = 51;
            this.dgvMyTransaction.RowTemplate.Height = 24;
            this.dgvMyTransaction.Size = new System.Drawing.Size(543, 371);
            this.dgvMyTransaction.TabIndex = 8;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(390, 258);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(281, 31);
            this.btnAddTransaction.TabIndex = 9;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "My Transaction";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTableBindingSource
            // 
            this.transactionTableBindingSource.DataMember = "TransactionTable";
            this.transactionTableBindingSource.DataSource = this.dataSet1;
            // 
            // transactionTableTableAdapter
            // 
            this.transactionTableTableAdapter.ClearBeforeFill = true;
            // 
            // transactionValueDataGridViewTextBoxColumn
            // 
            this.transactionValueDataGridViewTextBoxColumn.DataPropertyName = "TransactionValue";
            this.transactionValueDataGridViewTextBoxColumn.HeaderText = "TransactionValue";
            this.transactionValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionValueDataGridViewTextBoxColumn.Name = "transactionValueDataGridViewTextBoxColumn";
            this.transactionValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // transDateDataGridViewTextBoxColumn
            // 
            this.transDateDataGridViewTextBoxColumn.DataPropertyName = "TransDate";
            this.transDateDataGridViewTextBoxColumn.HeaderText = "TransDate";
            this.transDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transDateDataGridViewTextBoxColumn.Name = "transDateDataGridViewTextBoxColumn";
            this.transDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // transTypeDataGridViewCheckBoxColumn
            // 
            this.transTypeDataGridViewCheckBoxColumn.DataPropertyName = "TransType";
            this.transTypeDataGridViewCheckBoxColumn.HeaderText = "TransType";
            this.transTypeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.transTypeDataGridViewCheckBoxColumn.Name = "transTypeDataGridViewCheckBoxColumn";
            this.transTypeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // counterIDDataGridViewTextBoxColumn
            // 
            this.counterIDDataGridViewTextBoxColumn.DataPropertyName = "CounterID";
            this.counterIDDataGridViewTextBoxColumn.HeaderText = "CounterID";
            this.counterIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.counterIDDataGridViewTextBoxColumn.Name = "counterIDDataGridViewTextBoxColumn";
            this.counterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.counterIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(511, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 31);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 774);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.dgvMyTransaction);
            this.Controls.Add(this.rbIncome);
            this.Controls.Add(this.rbPayment);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransactionAmount);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "My Transactions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rbPayment;
        private System.Windows.Forms.RadioButton rbIncome;
        private System.Windows.Forms.DataGridView dgvMyTransaction;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Label label4;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource transactionTableBindingSource;
        private DataSet1TableAdapters.TransactionTableTableAdapter transactionTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transTypeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
    }
}