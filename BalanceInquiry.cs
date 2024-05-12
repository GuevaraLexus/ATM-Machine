using MySql.Data.MySqlClient;
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
    public partial class frmBalanceInquiry : Form
    {
        static string acc_pin;

        public frmBalanceInquiry()
        {
            InitializeComponent();
        }
        MySqlConnection connection;
        MySqlCommand mycommand;
        MySqlDataReader rdr;
        string myconnection = "Server=127.0.0.1;Port=3307; Database=dbatm; Uid=root; pwd=;";

        public static string getPin(string pin)
        {
            acc_pin = pin;
            return acc_pin;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTransactionForm frmTransactionForm = new frmTransactionForm();
            frmTransactionForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainForm frmMainForm = new frmMainForm();
            frmMainForm.Show();
        }

        private void setBalanceInquiry(string pin)
        {
            string sql = "SELECT * FROM tblAccounts WHERE acc_pin='" + acc_pin + "'";
            connection = new MySqlConnection(myconnection);

            try
            {
                connection.Open();
                mycommand = new MySqlCommand(sql, connection);
                rdr = mycommand.ExecuteReader();

                if (rdr.HasRows)
                {
                    while(rdr.Read())
                    {
                        txtAccountNumber.Text = rdr.GetString(2);
                        txtAccountName.Text = rdr.GetString(3);
                        txtAccountBalance.Text = rdr.GetString(4);

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBalanceInquiry_Load(object sender, EventArgs e)
        {
            setBalanceInquiry(acc_pin);
        }
    }
}
