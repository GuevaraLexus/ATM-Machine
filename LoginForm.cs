using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ATMMachine_Group3
{
    public partial class frmLoginForm : Form
    {
        int counter = 0;
        string pin = null;
        public frmLoginForm()
        {
            InitializeComponent();

            txtPin.Focus();

        }
        MySqlConnection connection;
        MySqlCommand mycommand;
        MySqlDataReader rdr;
        string myconnection = "Server=127.0.0.1;Port=3307; Database=dbatm; Uid=root; pwd=;";

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (string.IsNullOrEmpty(txtPin.Text))
                {
                    MessageBox.Show("PLEASE ENTER YOUR PIN!");
                }
                else
                {
                        String sql = "SELECT * FROM tblaccounts WHERE acc_pin = '" + txtPin.Text + "'";
                        connection = new MySqlConnection(myconnection);

                        try
                        {
                            connection.Open();
                            mycommand = new MySqlCommand(sql, connection);
                            rdr = mycommand.ExecuteReader();
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    frmTransactionForm transaction = new frmTransactionForm();
                                    transaction.Show();
                                    this.Hide();
                                    pin = rdr.GetString(1);
                                    frmBalanceInquiry frmBalanceInquiry = new frmBalanceInquiry();
                                    frmBalanceInquiry.getPin(pin);
                                }
                            }
                            else{
                                MessageBox.Show("INCORRECT PIN!");
                                txtPin.Clear();
                                counter++;

                            if (counter == 3 )
                            {
                                MessageBox.Show("CAPTURED CARD..Please Call 143-5254");
                                

                                frmMainForm main = new frmMainForm();
                                main.Show();
                                this.Hide();
                            }
                        }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                }
            }
        }

        private void frmLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}