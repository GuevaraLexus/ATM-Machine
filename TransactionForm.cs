using ATMMachine_Group3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMMachine_Group3
{
    public partial class frmTransactionForm : Form
    {
        public frmTransactionForm()
        {
            InitializeComponent();
        }

        private void btnBalanceInquiry_Click(object sender, EventArgs e)
        {
            frmBalanceInquiry balance = new frmBalanceInquiry();
            balance.Show();
            this.Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmDeposit deposit = new frmDeposit();
            deposit.Show();
            this.Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            frmWithdraw withdraw = new frmWithdraw();
            withdraw.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to end this transaction?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmMainForm main = new frmMainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                // Don't save the changes.
            }

        }
    }
}
