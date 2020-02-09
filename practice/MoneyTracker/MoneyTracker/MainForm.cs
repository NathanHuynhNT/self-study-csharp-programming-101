using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            decimal TransAmount = Convert.ToDecimal(txtTransactionAmount.Text);
            string TransDescription = txtDescription.Text;
            DateTime TransDate = dtpDate.Value;
            
            int TransType = 0;
            if (rbPayment.Checked)
                TransType = 0;
            if (rbIncome.Checked)
                TransType = 1;

            DataSet1TableAdapters.TransactionTableTableAdapter myAdapter = new DataSet1TableAdapters.TransactionTableTableAdapter();
            myAdapter.InsertTransaction(TransAmount, TransDescription, TransDate, Convert.ToBoolean(TransType));

            MessageBox.Show("Well Done");
            this.transactionTableTableAdapter.Fill(this.dataSet1.TransactionTable);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TransactionTable' table. You can move, or remove it, as needed.
            this.transactionTableTableAdapter.Fill(this.dataSet1.TransactionTable);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            transactionTableTableAdapter.Update(dataSet1);
            dgvMyTransaction.EndEdit();
            this.transactionTableTableAdapter.Fill(this.dataSet1.TransactionTable);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
